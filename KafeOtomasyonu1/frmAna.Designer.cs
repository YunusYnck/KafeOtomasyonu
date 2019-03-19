namespace KafeOtomasyonu1
{
    partial class frmAna
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunleriGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunleriDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sifreDegistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstMasa = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.masayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunleriGosterToolStripMenuItem,
            this.urunEkleToolStripMenuItem,
            this.urunleriDuzenleToolStripMenuItem});
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ürünToolStripMenuItem.Text = "Ürün";
            // 
            // urunleriGosterToolStripMenuItem
            // 
            this.urunleriGosterToolStripMenuItem.Name = "urunleriGosterToolStripMenuItem";
            this.urunleriGosterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.urunleriGosterToolStripMenuItem.Text = "Ürünleri Göster";
            this.urunleriGosterToolStripMenuItem.Click += new System.EventHandler(this.urunleriGosterToolStripMenuItem_Click);
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.urunEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // urunleriDuzenleToolStripMenuItem
            // 
            this.urunleriDuzenleToolStripMenuItem.Name = "urunleriDuzenleToolStripMenuItem";
            this.urunleriDuzenleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.urunleriDuzenleToolStripMenuItem.Text = "Ürün Düzenle";
            this.urunleriDuzenleToolStripMenuItem.Click += new System.EventHandler(this.urunleriDuzenleToolStripMenuItem_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporToolStripMenuItem});
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.satışToolStripMenuItem.Text = "Satış";
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullaniciEkleToolStripMenuItem,
            this.sifreDegistirToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullaniciEkleToolStripMenuItem
            // 
            this.kullaniciEkleToolStripMenuItem.Name = "kullaniciEkleToolStripMenuItem";
            this.kullaniciEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.kullaniciEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullaniciEkleToolStripMenuItem.Click += new System.EventHandler(this.kullaniciEkleToolStripMenuItem_Click_1);
            // 
            // sifreDegistirToolStripMenuItem
            // 
            this.sifreDegistirToolStripMenuItem.Name = "sifreDegistirToolStripMenuItem";
            this.sifreDegistirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sifreDegistirToolStripMenuItem.Text = "Şifre Değiştir";
            this.sifreDegistirToolStripMenuItem.Click += new System.EventHandler(this.sifreDegistirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lstMasa);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1358, 704);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masalar";
            // 
            // lstMasa
            // 
            this.lstMasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMasa.LargeImageList = this.imageList1;
            this.lstMasa.Location = new System.Drawing.Point(3, 16);
            this.lstMasa.MultiSelect = false;
            this.lstMasa.Name = "lstMasa";
            this.lstMasa.Size = new System.Drawing.Size(1352, 685);
            this.lstMasa.TabIndex = 1;
            this.lstMasa.UseCompatibleStateImageBehavior = false;
            this.lstMasa.SelectedIndexChanged += new System.EventHandler(this.lstMasa_SelectedIndexChanged_1);
            this.lstMasa.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.lstMasa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstMasa_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "doluMasa.png");
            this.imageList1.Images.SetKeyName(1, "bosMasa.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masayiKapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // masayiKapatToolStripMenuItem
            // 
            this.masayiKapatToolStripMenuItem.Name = "masayiKapatToolStripMenuItem";
            this.masayiKapatToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.masayiKapatToolStripMenuItem.Text = "Masayi Kapat";
            this.masayiKapatToolStripMenuItem.Click += new System.EventHandler(this.masayiKapatToolStripMenuItem_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAna";
            this.Text = "frmAna";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunleriGosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunleriDuzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sifreDegistirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ListView lstMasa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masayiKapatToolStripMenuItem;
    }
}