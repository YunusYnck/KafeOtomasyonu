namespace KafeOtomasyonu1
{
    partial class frmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // bGiris
            // 
            this.bGiris.Location = new System.Drawing.Point(222, 156);
            this.bGiris.Name = "bGiris";
            this.bGiris.Size = new System.Drawing.Size(88, 28);
            this.bGiris.TabIndex = 1;
            this.bGiris.Text = "Giris Yap";
            this.bGiris.UseVisualStyleBackColor = true;
            this.bGiris.Click += new System.EventHandler(this.bGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // tKullaniciAdi
            // 
            this.tKullaniciAdi.Location = new System.Drawing.Point(263, 78);
            this.tKullaniciAdi.Name = "tKullaniciAdi";
            this.tKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.tKullaniciAdi.TabIndex = 3;
            this.tKullaniciAdi.Text = "Admin";
            // 
            // tSifre
            // 
            this.tSifre.Location = new System.Drawing.Point(263, 111);
            this.tSifre.Name = "tSifre";
            this.tSifre.Size = new System.Drawing.Size(100, 20);
            this.tSifre.TabIndex = 4;
            this.tSifre.Text = "sifre";
            this.tSifre.UseSystemPasswordChar = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KafeOtomasyonu1.Properties.Resources.cafe6;
            this.ClientSize = new System.Drawing.Size(426, 220);
            this.Controls.Add(this.tSifre);
            this.Controls.Add(this.tKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bGiris);
            this.Controls.Add(this.label1);
            this.Name = "frmGiris";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tKullaniciAdi;
        private System.Windows.Forms.TextBox tSifre;
    }
}

