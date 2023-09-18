using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Algorithms_Digital_Signature__RSA__El_Gamal__DSA_
{
    public partial class DSA : Form
    {
        Random rand = new Random();
        public long q, g, y, s, r, p, x, k;
        public string Message, Signature, fileOptions;
        public static string Hash;

        public DSA()
        {
            InitializeComponent();
        }
        public static int hash(string s, long n)
        {
            Hash = ""; char[] b = new char[36];
            b[0] = 'а'; b[1] = 'б'; b[2] = 'в'; b[3] = 'г'; b[4] = 'д'; b[5] = 'е'; b[6] = 'ё'; b[7] = 'ж'; b[8] = 'з'; b[9] = 'и'; b[10] = 'й';
            b[11] = 'к'; b[12] = 'л'; b[13] = 'м'; b[14] = 'н'; b[15] = 'о'; b[16] = 'п'; b[17] = 'р'; b[18] = 'с'; b[19] = 'т'; b[20] = 'у'; b[21] = 'ф';
            b[22] = 'х'; b[23] = 'ц'; b[24] = 'ч'; b[25] = 'ш'; b[26] = 'щ'; b[27] = 'ъ'; b[28] = 'ы'; b[29] = 'ь'; b[30] = 'э'; b[31] = 'ю'; b[32] = 'я'; b[33] = ' '; b[34] = ','; b[35] = '.';
            int k = 150;
            int f = 0;
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < 36; j++)
                {
                    if (b[j] == s[i])
                    {
                        f = j;
                    }
                    else
                    {
                        continue;
                    }
                }
                k = Convert.ToInt32(Math.Pow(k + f, 2) % n);
                Hash = Hash + k.ToString();
            }
            return k;
        }
        private void BSign_Click(object sender, EventArgs e)
        {
            g = 0; y = 0; s = 0; r = 0;
            Message = textBoxM.Text;

            q = Convert.ToInt32(textBoxQ.Text); // q = Convert.ToInt32(textBoxQ.Text);
            p = Convert.ToInt32(textBoxP.Text); // p = (q * 2) + 1;
            g = Convert.ToInt32(textBoxG.Text); // while (g < 1) {g = (long)Math.Pow(rand.Next(1, (int)(p - 1)), (p - 1) / q);}

            x = Convert.ToInt32(textBoxX.Text); //x = rand.Next(0, ((int)q));
            y =(long) Math.Pow(g, x) % p; textBoxY.Text = y.ToString();

            while (true)
            {
                k = rand.Next(0, ((int)q));
                r=(long)(Math.Pow(g,k)%p)% q; 

                long k1 = 0;
                k1 = (long)Math.Pow(k, q - 2) % q;

                s = Convert.ToInt32(k1 * (hash(Message, q) + x * r)) % q;
                if (r != 0 && s != 0)
                {
                    textBoxDS.Text = ""+r+s;
                    break;
                }
                else
                {
                    continue;
                }
            }
            textBoxHash.Text = Hash;
        }
        private void BCheck_Click(object sender, EventArgs e)
        {
            r = Convert.ToInt32(textBoxDS.Text[0].ToString());
            s = Convert.ToInt32(textBoxDS.Text[1].ToString());

            y = Convert.ToInt64(textBoxY.Text);
            Signature = textBoxCheck.Text;

            long s1 = 0; 
            s1 = (long)Math.Pow(s, q - 2) % q;
            long w = s1 % q;
            long u1 = (hash(Signature, q) * w) % q;
            long u2 = (r * w) % q;

            textBoxHash.Text = Hash;

            long v = (long)(Math.Pow(g, u1) * Math.Pow(y, u2) % p) % q;
            if (v == r)
            {
                MessageBox.Show("Подпись верна.", "Сообщение о проверке");
            }
            else
            {
                MessageBox.Show("Подпись неверна.", "Сообщение о проверке");
            }
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
                DATA.WriteLine("Key Q: " + textBoxQ.Text);
                DATA.WriteLine("Key P: " + textBoxP.Text);
                DATA.WriteLine("Key G: " + textBoxG.Text);
                DATA.WriteLine("Key Y: " + textBoxY.Text);
                DATA.WriteLine("Key X: " + textBoxX.Text);

                MessageBox.Show("Results saved: " + filePath);
            }
        }
        private void DSA_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
    }
}
