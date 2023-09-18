namespace Algorithms_Digital_Signature__RSA__El_Gamal__DSA_
{
    partial class ElGamal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BFile = new System.Windows.Forms.Button();
            this.txtPublicG = new System.Windows.Forms.TextBox();
            this.txtPublicP = new System.Windows.Forms.TextBox();
            this.textBoxDS = new System.Windows.Forms.TextBox();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BSign = new System.Windows.Forms.Button();
            this.BCheck = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxCheck = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // BFile
            // 
            this.BFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BFile.Location = new System.Drawing.Point(19, 19);
            this.BFile.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BFile.Name = "BFile";
            this.BFile.Size = new System.Drawing.Size(135, 35);
            this.BFile.TabIndex = 26;
            this.BFile.Text = "File";
            this.BFile.UseVisualStyleBackColor = false;
            this.BFile.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // txtPublicG
            // 
            this.txtPublicG.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublicG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublicG.Location = new System.Drawing.Point(37, 46);
            this.txtPublicG.Name = "txtPublicG";
            this.txtPublicG.Size = new System.Drawing.Size(93, 20);
            this.txtPublicG.TabIndex = 6;
            // 
            // txtPublicP
            // 
            this.txtPublicP.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublicP.Location = new System.Drawing.Point(37, 21);
            this.txtPublicP.Name = "txtPublicP";
            this.txtPublicP.Size = new System.Drawing.Size(93, 20);
            this.txtPublicP.TabIndex = 6;
            // 
            // textBoxDS
            // 
            this.textBoxDS.BackColor = System.Drawing.Color.White;
            this.textBoxDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDS.Location = new System.Drawing.Point(5, 18);
            this.textBoxDS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDS.Multiline = true;
            this.textBoxDS.Name = "textBoxDS";
            this.textBoxDS.ReadOnly = true;
            this.textBoxDS.Size = new System.Drawing.Size(679, 57);
            this.textBoxDS.TabIndex = 0;
            // 
            // textBoxHash
            // 
            this.textBoxHash.BackColor = System.Drawing.Color.White;
            this.textBoxHash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHash.Location = new System.Drawing.Point(5, 18);
            this.textBoxHash.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHash.Multiline = true;
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.ReadOnly = true;
            this.textBoxHash.Size = new System.Drawing.Size(679, 62);
            this.textBoxHash.TabIndex = 3;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrivateKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrivateKey.Location = new System.Drawing.Point(34, 44);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(93, 20);
            this.txtPrivateKey.TabIndex = 6;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtPublicKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublicKey.Location = new System.Drawing.Point(34, 15);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(93, 20);
            this.txtPublicKey.TabIndex = 6;
            // 
            // textBoxM
            // 
            this.textBoxM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxM.Location = new System.Drawing.Point(5, 18);
            this.textBoxM.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxM.Multiline = true;
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(679, 57);
            this.textBoxM.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPublicP);
            this.groupBox1.Controls.Add(this.txtPublicG);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(19, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(135, 80);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "P =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "G =";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.txtPrivateKey);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPublicKey);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(19, 244);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(135, 80);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Public and Private Keys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "X =";
            // 
            // BSign
            // 
            this.BSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSign.Location = new System.Drawing.Point(19, 64);
            this.BSign.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BSign.Name = "BSign";
            this.BSign.Size = new System.Drawing.Size(135, 35);
            this.BSign.TabIndex = 29;
            this.BSign.Text = "Sign Message";
            this.BSign.UseVisualStyleBackColor = false;
            this.BSign.Click += new System.EventHandler(this.BSign_Click);
            // 
            // BCheck
            // 
            this.BCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCheck.Location = new System.Drawing.Point(19, 109);
            this.BCheck.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BCheck.Name = "BCheck";
            this.BCheck.Size = new System.Drawing.Size(135, 35);
            this.BCheck.TabIndex = 30;
            this.BCheck.Text = "Sign Check";
            this.BCheck.UseVisualStyleBackColor = false;
            this.BCheck.Click += new System.EventHandler(this.BCheck_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.textBoxM);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(174, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(689, 80);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.textBoxCheck);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(174, 109);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(689, 84);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sign Message";
            // 
            // textBoxCheck
            // 
            this.textBoxCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCheck.Location = new System.Drawing.Point(5, 18);
            this.textBoxCheck.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCheck.Multiline = true;
            this.textBoxCheck.Name = "textBoxCheck";
            this.textBoxCheck.Size = new System.Drawing.Size(679, 61);
            this.textBoxCheck.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox5.Controls.Add(this.textBoxHash);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Location = new System.Drawing.Point(174, 198);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(689, 85);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hash";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox6.Controls.Add(this.textBoxDS);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox6.Location = new System.Drawing.Point(174, 288);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(689, 80);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Digital Signature";
            // 
            // ElGamal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(998, 422);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BCheck);
            this.Controls.Add(this.BSign);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElGamal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "El-Gamal";
            this.Load += new System.EventHandler(this.ElGamal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BFile;
        private System.Windows.Forms.TextBox txtPublicG;
        private System.Windows.Forms.TextBox txtPublicP;
        private System.Windows.Forms.TextBox textBoxDS;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSign;
        private System.Windows.Forms.Button BCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCheck;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}