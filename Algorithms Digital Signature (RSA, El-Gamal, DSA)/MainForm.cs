using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms_Digital_Signature__RSA__El_Gamal__DSA_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonRSA_Click(object sender, EventArgs e)
        {
            RSA MainForm = new RSA();
            MainForm.MdiParent = this;
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            MainForm.Show();
        }

        private void buttonElGamale_Click(object sender, EventArgs e)
        {
            ElGamal MainForm = new ElGamal();
            MainForm.MdiParent = this;
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            MainForm.Show();
        }

        private void buttonDSA_Click(object sender, EventArgs e)
        {
            DSA MainForm = new DSA();
            MainForm.MdiParent = this;
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            MainForm.Show();
        }
    }
}
