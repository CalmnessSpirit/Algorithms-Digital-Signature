namespace Algorithms_Digital_Signature__RSA__El_Gamal__DSA_
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonRSA = new System.Windows.Forms.Button();
            this.buttonElGamale = new System.Windows.Forms.Button();
            this.buttonDSA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // buttonRSA
            // 
            this.buttonRSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.buttonRSA, "buttonRSA");
            this.buttonRSA.Name = "buttonRSA";
            this.buttonRSA.UseVisualStyleBackColor = false;
            this.buttonRSA.Click += new System.EventHandler(this.buttonRSA_Click);
            // 
            // buttonElGamale
            // 
            this.buttonElGamale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.buttonElGamale, "buttonElGamale");
            this.buttonElGamale.Name = "buttonElGamale";
            this.buttonElGamale.UseVisualStyleBackColor = false;
            this.buttonElGamale.Click += new System.EventHandler(this.buttonElGamale_Click);
            // 
            // buttonDSA
            // 
            this.buttonDSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.buttonDSA, "buttonDSA");
            this.buttonDSA.Name = "buttonDSA";
            this.buttonDSA.UseVisualStyleBackColor = false;
            this.buttonDSA.Click += new System.EventHandler(this.buttonDSA_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonDSA);
            this.Controls.Add(this.buttonElGamale);
            this.Controls.Add(this.buttonRSA);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonRSA;
        private System.Windows.Forms.Button buttonElGamale;
        private System.Windows.Forms.Button buttonDSA;
    }
}

