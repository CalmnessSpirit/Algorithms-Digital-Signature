using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System;
using ElgamalEncryption.Algorithm;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Security.Policy;


namespace Algorithms_Digital_Signature__RSA__El_Gamal__DSA_
{
    public partial class ElGamal : Form
    {
        MD5 md5 = MD5.Create();
        Random rand = new Random();
        ElgamalEncryption.Algorithm.ElGamal x_sign_alg = new ElGamalManaged();


        long p_, g_, x_, y_;
        byte[] hashM, hashC, signByte, checkByte;
        public string fileOptions, strsign, strcheck;
        public ElGamal()
        {
            InitializeComponent();
        }

        public void BSign_Click(object sender, EventArgs e)
        {

            byte[] inputBytes = Encoding.Default.GetBytes(textBoxM.Text);
            hashM = md5.ComputeHash(inputBytes);

            textBoxHash.Text = BitConverter.ToString(hashM).Replace("-", " ");

            EGKeys();
            signByte = x_sign_alg.Sign(hashM);

            textBoxDS.Text = BitConverter.ToString(signByte).Replace("-", " ");

            strsign = BitConverter.ToString(signByte).Replace("-", "");
        }

        public void BCheck_Click(object sender, EventArgs e)
        {
            byte[] outputBytes = Encoding.Default.GetBytes(textBoxCheck.Text);
            hashC = md5.ComputeHash(outputBytes);
            EGKeys();
            signByte = x_sign_alg.Sign(hashM);
            checkByte = x_sign_alg.Sign(hashC);
            textBoxDS.Text = BitConverter.ToString(signByte).Replace("-", " ");

            strsign = BitConverter.ToString(signByte).Replace("-", "");
            strcheck = BitConverter.ToString(checkByte).Replace("-", "");

            if (strsign == strcheck)
            {
                MessageBox.Show("Подпись верна.", "Сообщение о проверке");
            }
            else
            {
                MessageBox.Show("Подпись неверна.", "Сообщение о проверке");
            }
            ToFile();
        }

        public void EGKeys()
        {
            p_ = Convert.ToInt32(txtPublicP.Text);
            g_ = Convert.ToInt32(txtPublicG.Text);
            x_ = rand.Next(1, ((int)p_)); txtPrivateKey.Text = x_.ToString();
            y_ = (long)Math.Pow(g_, x_) % p_; txtPublicKey.Text = y_.ToString();

            ElGamalKeyStruct keys = new ElGamalKeyStruct();
            try
            {
                keys.P = new BigInteger(txtPublicP.Text, 10);
                keys.G = new BigInteger(txtPublicG.Text, 10);
                keys.Y = new BigInteger(txtPublicKey.Text, 10);
                keys.X = new BigInteger(txtPrivateKey.Text, 10);
            }
            catch (Exception ex)
            {
                return;
            }

            x_sign_alg.ImportParameters(keys);
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
        public void ToFile()
        {
            string filePath = Path.Combine(fileOptions);
            using (StreamWriter DATA = new StreamWriter(filePath))
            {
                DATA.WriteLine("Program results: ");
                DATA.WriteLine("Message: " + textBoxM.Text);
                DATA.WriteLine("Hash: " + textBoxHash.Text);
                DATA.WriteLine("Sign: " + textBoxDS.Text);
                DATA.WriteLine("--------------------");
                DATA.WriteLine("Key P: " + txtPublicP.Text);
                DATA.WriteLine("Key G: " + txtPublicG.Text);
                DATA.WriteLine("Key Y: " + txtPublicKey.Text);
                DATA.WriteLine("Key X: " + txtPrivateKey.Text);

                MessageBox.Show("Results saved: " + filePath);
            }
        }
        public void ElGamal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
    }
}
