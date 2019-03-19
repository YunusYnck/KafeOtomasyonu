namespace KafeOtomasyonu1
{
    partial class frmKullaniciEkle
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
            this.label4 = new System.Windows.Forms.Label();
            this.kAdi = new System.Windows.Forms.TextBox();
            this.kSifre = new System.Windows.Forms.TextBox();
            this.tAd = new System.Windows.Forms.TextBox();
            this.tSoyad = new System.Windows.Forms.TextBox();
            this.bKullaniciEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Sifresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad";
            // 
            // kAdi
            // 
            this.kAdi.Location = new System.Drawing.Point(124, 52);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(100, 20);
            this.kAdi.TabIndex = 4;
            // 
            // kSifre
            // 
            this.kSifre.Location = new System.Drawing.Point(124, 78);
            this.kSifre.Name = "kSifre";
            this.kSifre.Size = new System.Drawing.Size(100, 20);
            this.kSifre.TabIndex = 5;
            // 
            // tAd
            // 
            this.tAd.Location = new System.Drawing.Point(124, 104);
            this.tAd.Name = "tAd";
            this.tAd.Size = new System.Drawing.Size(100, 20);
            this.tAd.TabIndex = 6;
            // 
            // tSoyad
            // 
            this.tSoyad.Location = new System.Drawing.Point(124, 126);
            this.tSoyad.Name = "tSoyad";
            this.tSoyad.Size = new System.Drawing.Size(100, 20);
            this.tSoyad.TabIndex = 7;
            // 
            // bKullaniciEkle
            // 
            this.bKullaniciEkle.Location = new System.Drawing.Point(82, 180);
            this.bKullaniciEkle.Name = "bKullaniciEkle";
            this.bKullaniciEkle.Size = new System.Drawing.Size(112, 23);
            this.bKullaniciEkle.TabIndex = 8;
            this.bKullaniciEkle.Text = "Kullanıcı Ekle";
            this.bKullaniciEkle.UseVisualStyleBackColor = true;
            this.bKullaniciEkle.Click += new System.EventHandler(this.bKullaniciEkle_Click);
            // 
            // frmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bKullaniciEkle);
            this.Controls.Add(this.tSoyad);
            this.Controls.Add(this.tAd);
            this.Controls.Add(this.kSifre);
            this.Controls.Add(this.kAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKullaniciEkle";
            this.Text = "frmKullaniciEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.TextBox kSifre;
        private System.Windows.Forms.TextBox tAd;
        private System.Windows.Forms.TextBox tSoyad;
        private System.Windows.Forms.Button bKullaniciEkle;
    }
}