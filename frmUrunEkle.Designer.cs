namespace KafeOtomasyonu1
{
    partial class frmUrunEkle
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
            this.turunAdi = new System.Windows.Forms.TextBox();
            this.turunFiyati = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResimYolu = new System.Windows.Forms.Label();
            this.pUrunResmi = new System.Windows.Forms.PictureBox();
            this.cGrup = new System.Windows.Forms.ComboBox();
            this.bUrunEkle = new System.Windows.Forms.Button();
            this.bFotografSec = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bGrupEkle = new System.Windows.Forms.Button();
            this.bUrunGoster = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUrunResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grubu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fotoğrafı";
            // 
            // turunAdi
            // 
            this.turunAdi.Location = new System.Drawing.Point(96, 9);
            this.turunAdi.Name = "turunAdi";
            this.turunAdi.Size = new System.Drawing.Size(121, 20);
            this.turunAdi.TabIndex = 7;
            // 
            // turunFiyati
            // 
            this.turunFiyati.Location = new System.Drawing.Point(96, 35);
            this.turunFiyati.Name = "turunFiyati";
            this.turunFiyati.Size = new System.Drawing.Size(121, 20);
            this.turunFiyati.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResimYolu);
            this.panel1.Controls.Add(this.pUrunResmi);
            this.panel1.Controls.Add(this.cGrup);
            this.panel1.Controls.Add(this.bUrunEkle);
            this.panel1.Controls.Add(this.bFotografSec);
            this.panel1.Controls.Add(this.turunFiyati);
            this.panel1.Controls.Add(this.turunAdi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 170);
            this.panel1.TabIndex = 2;
            // 
            // lblResimYolu
            // 
            this.lblResimYolu.Location = new System.Drawing.Point(11, 134);
            this.lblResimYolu.Name = "lblResimYolu";
            this.lblResimYolu.Size = new System.Drawing.Size(206, 19);
            this.lblResimYolu.TabIndex = 13;
            // 
            // pUrunResmi
            // 
            this.pUrunResmi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pUrunResmi.Location = new System.Drawing.Point(243, 9);
            this.pUrunResmi.Name = "pUrunResmi";
            this.pUrunResmi.Size = new System.Drawing.Size(100, 105);
            this.pUrunResmi.TabIndex = 12;
            this.pUrunResmi.TabStop = false;
            // 
            // cGrup
            // 
            this.cGrup.FormattingEnabled = true;
            this.cGrup.Location = new System.Drawing.Point(96, 60);
            this.cGrup.Name = "cGrup";
            this.cGrup.Size = new System.Drawing.Size(121, 21);
            this.cGrup.TabIndex = 11;
            this.cGrup.SelectedIndexChanged += new System.EventHandler(this.cGrup_SelectedIndexChanged);
            // 
            // bUrunEkle
            // 
            this.bUrunEkle.Location = new System.Drawing.Point(243, 130);
            this.bUrunEkle.Name = "bUrunEkle";
            this.bUrunEkle.Size = new System.Drawing.Size(100, 23);
            this.bUrunEkle.TabIndex = 6;
            this.bUrunEkle.Text = "Ürün Ekle";
            this.bUrunEkle.UseVisualStyleBackColor = true;
            this.bUrunEkle.Click += new System.EventHandler(this.bUrunEkle_Click);
            // 
            // bFotografSec
            // 
            this.bFotografSec.Location = new System.Drawing.Point(96, 96);
            this.bFotografSec.Name = "bFotografSec";
            this.bFotografSec.Size = new System.Drawing.Size(121, 23);
            this.bFotografSec.TabIndex = 10;
            this.bFotografSec.Text = "Fotoğraf Seç";
            this.bFotografSec.UseVisualStyleBackColor = true;
            this.bFotografSec.Click += new System.EventHandler(this.bFotografSec_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürünün";
            // 
            // bGrupEkle
            // 
            this.bGrupEkle.Location = new System.Drawing.Point(12, 223);
            this.bGrupEkle.Name = "bGrupEkle";
            this.bGrupEkle.Size = new System.Drawing.Size(134, 23);
            this.bGrupEkle.TabIndex = 4;
            this.bGrupEkle.Text = "Grup Ekle";
            this.bGrupEkle.UseVisualStyleBackColor = true;
            this.bGrupEkle.Click += new System.EventHandler(this.bGrupEkle_Click);
            // 
            // bUrunGoster
            // 
            this.bUrunGoster.Location = new System.Drawing.Point(184, 223);
            this.bUrunGoster.Name = "bUrunGoster";
            this.bUrunGoster.Size = new System.Drawing.Size(133, 23);
            this.bUrunGoster.TabIndex = 5;
            this.bUrunGoster.Text = "Ürünleri Göster";
            this.bUrunGoster.UseVisualStyleBackColor = true;
            this.bUrunGoster.Click += new System.EventHandler(this.bUrunGoster_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 274);
            this.Controls.Add(this.bUrunGoster);
            this.Controls.Add(this.bGrupEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "frmUrunEkle";
            this.Text = "frmUrunEkle";
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUrunResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox turunAdi;
        private System.Windows.Forms.TextBox turunFiyati;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bFotografSec;
        private System.Windows.Forms.Button bUrunEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bGrupEkle;
        private System.Windows.Forms.Button bUrunGoster;
        private System.Windows.Forms.ComboBox cGrup;
        private System.Windows.Forms.PictureBox pUrunResmi;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Label lblResimYolu;
    }
}