namespace KafeOtomasyonu1
{
    partial class frmSifreDegistir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tEskiSifre = new System.Windows.Forms.TextBox();
            this.tYeniSifre = new System.Windows.Forms.TextBox();
            this.tYeniSifre2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eski Şifreniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Şifreniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeni Şifreniz Tekrar:";
            // 
            // tEskiSifre
            // 
            this.tEskiSifre.Location = new System.Drawing.Point(119, 40);
            this.tEskiSifre.Name = "tEskiSifre";
            this.tEskiSifre.Size = new System.Drawing.Size(100, 20);
            this.tEskiSifre.TabIndex = 3;
            // 
            // tYeniSifre
            // 
            this.tYeniSifre.Location = new System.Drawing.Point(119, 66);
            this.tYeniSifre.Name = "tYeniSifre";
            this.tYeniSifre.Size = new System.Drawing.Size(100, 20);
            this.tYeniSifre.TabIndex = 4;
            // 
            // tYeniSifre2
            // 
            this.tYeniSifre2.Location = new System.Drawing.Point(119, 93);
            this.tYeniSifre2.Name = "tYeniSifre2";
            this.tYeniSifre2.Size = new System.Drawing.Size(100, 20);
            this.tYeniSifre2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Şifre Degiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tYeniSifre2);
            this.Controls.Add(this.tYeniSifre);
            this.Controls.Add(this.tEskiSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSifreDegistir";
            this.Text = "frmSifreDegistir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tEskiSifre;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tYeniSifre;
        public System.Windows.Forms.TextBox tYeniSifre2;
    }
}