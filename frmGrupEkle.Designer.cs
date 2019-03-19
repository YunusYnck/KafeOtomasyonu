namespace KafeOtomasyonu1
{
    partial class frmGrupEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tGrupEkle = new System.Windows.Forms.TextBox();
            this.bGrupEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bGrupDuzenle = new System.Windows.Forms.Button();
            this.tDGrupAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGruplar = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tGrupEkle);
            this.groupBox1.Controls.Add(this.bGrupEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grup Ekle";
            // 
            // tGrupEkle
            // 
            this.tGrupEkle.Location = new System.Drawing.Point(84, 32);
            this.tGrupEkle.Name = "tGrupEkle";
            this.tGrupEkle.Size = new System.Drawing.Size(100, 20);
            this.tGrupEkle.TabIndex = 2;
            // 
            // bGrupEkle
            // 
            this.bGrupEkle.Location = new System.Drawing.Point(9, 69);
            this.bGrupEkle.Name = "bGrupEkle";
            this.bGrupEkle.Size = new System.Drawing.Size(65, 23);
            this.bGrupEkle.TabIndex = 1;
            this.bGrupEkle.Text = "Ekle";
            this.bGrupEkle.UseVisualStyleBackColor = true;
            this.bGrupEkle.Click += new System.EventHandler(this.bGrupEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bGrupDuzenle);
            this.groupBox2.Controls.Add(this.tDGrupAdi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboGruplar);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grup Düzenle";
            // 
            // bGrupDuzenle
            // 
            this.bGrupDuzenle.Location = new System.Drawing.Point(6, 83);
            this.bGrupDuzenle.Name = "bGrupDuzenle";
            this.bGrupDuzenle.Size = new System.Drawing.Size(65, 23);
            this.bGrupDuzenle.TabIndex = 3;
            this.bGrupDuzenle.Text = "Düzenle";
            this.bGrupDuzenle.UseVisualStyleBackColor = true;
            this.bGrupDuzenle.Click += new System.EventHandler(this.bGrupDuzenle_Click);
            // 
            // tDGrupAdi
            // 
            this.tDGrupAdi.Location = new System.Drawing.Point(84, 61);
            this.tDGrupAdi.Name = "tDGrupAdi";
            this.tDGrupAdi.Size = new System.Drawing.Size(121, 20);
            this.tDGrupAdi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gruplar :";
            // 
            // comboGruplar
            // 
            this.comboGruplar.FormattingEnabled = true;
            this.comboGruplar.Location = new System.Drawing.Point(84, 28);
            this.comboGruplar.Name = "comboGruplar";
            this.comboGruplar.Size = new System.Drawing.Size(121, 21);
            this.comboGruplar.TabIndex = 0;
            // 
            // frmGrupEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGrupEkle";
            this.Text = "frmGrupEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tGrupEkle;
        private System.Windows.Forms.Button bGrupEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bGrupDuzenle;
        private System.Windows.Forms.TextBox tDGrupAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGruplar;
    }
}