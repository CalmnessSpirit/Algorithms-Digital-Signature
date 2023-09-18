using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Numerics;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Algorithms_Digital_Signature__RSA__El_Gamal__DSA_
{
    public partial class RSA : Form
    {
        public long p, q, n, m, d, e_;
        public string message, hash, result, hashCh, fileOptions;
        char[] characters = new char[] { '#', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-' };
        public RSA()
        {
            InitializeComponent();
        }
        public void signButton_Click(object sender, EventArgs e)
        {
            if ((txtP.Text.Length > 0) && (txtQ.Text.Length > 0) && (textBoxM.Text.Length > 0))
            {
                p = Convert.ToInt64(txtP.Text);
                q = Convert.ToInt64(txtQ.Text);

                if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
                {
                    message = textBoxM.Text;
                    hash = message.GetHashCode().ToString();
                    n = p * q;
                    m = (p - 1) * (q - 1);
                    d = Calculate_d(m);
                    e_ = Calculate_e(d, m);
                    List<string> hashE = RSA_Endoce(hash, e_, n);
                    StreamWriter sw = new StreamWriter(fileOptions);
                    foreach (string item in hashE)
                        sw.WriteLine(item);
                    sw.Close();
                    txtD.Text = d.ToString();
                    txtN.Text = n.ToString();


                    List<string> hashD = new List<string>();
                    StreamReader sr = new StreamReader(fileOptions);
                    while (!sr.EndOfStream) { hashD.Add(sr.ReadLine()); }
                    sr.Close();

                    result = RSA_Decode(hashD, d, n);
                    hashCh = textBoxCheck.Text.GetHashCode().ToString();
                    textBoxHash.Text = hashCh;
                    textBoxDS.Text = result;
                }
                else
                    MessageBox.Show("p или q - не простые числа!");
            }
            else
                MessageBox.Show("Введите p, q и сообщение!");
        }
        public void checkButton_Click(object sender, EventArgs e)
        {
            if ((txtP.Text.Length > 0) && (txtQ.Text.Length > 0) && (textBoxM.Text.Length > 0))
            {
                if (result.Equals(hashCh))
                    MessageBox.Show("Подпись верна.", "Сообщение о проверке");
                else
                    MessageBox.Show("Подпись неверна", "Сообщение о проверке");
            }
            else
                MessageBox.Show("Введите секретный ключ и сообщение!");

            ToFile();
        }
        public void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileOptions = ofd.FileName;
            }
        }
        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        private List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }
        private string RSA_Decode(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }
        private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }

            return d;
        }
        private long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }
        private void ToFile()
        {
            string filePath = Path.Combine(fileOptions);
            using (StreamWriter DATA = new StreamWriter(filePath))
            {
                DATA.WriteLine("Program results: ");
                DATA.WriteLine("Message: " + textBoxM.Text);
                DATA.WriteLine("Hash: " + textBoxHash.Text);
                DATA.WriteLine("Sign: " + textBoxDS.Text);
                DATA.WriteLine("--------------------");
                DATA.WriteLine("Key P: " + txtP.Text);
                DATA.WriteLine("Key Q: " + txtQ.Text);
                DATA.WriteLine("Key D: " + txtD.Text);
                DATA.WriteLine("Key N: " + txtN.Text);

                MessageBox.Show("Results saved: " + filePath);
            }
        }
        private void RSA_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

    }
}
