namespace KafeOtomasyonu1
{
    partial class frmUrunleriGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunleriGoster));
            this.lstUrun = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ürünüDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜrünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUrun
            // 
            this.lstUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUrun.LargeImageList = this.imageList1;
            this.lstUrun.Location = new System.Drawing.Point(0, 0);
            this.lstUrun.MultiSelect = false;
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(874, 509);
            this.lstUrun.TabIndex = 1;
            this.lstUrun.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo.png");
            // 
            // ürünüDüzenleToolStripMenuItem
            // 
            this.ürünüDüzenleToolStripMenuItem.Name = "ürünüDüzenleToolStripMenuItem";
            this.ürünüDüzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ürünüDüzenleToolStripMenuItem.Text = "Ürünü Düzenle";
            // 
            // yeniÜrünEkleToolStripMenuItem
            // 
            this.yeniÜrünEkleToolStripMenuItem.Name = "yeniÜrünEkleToolStripMenuItem";
            this.yeniÜrünEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yeniÜrünEkleToolStripMenuItem.Text = "Yeni Ürün Ekle";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünüDüzenleToolStripMenuItem,
            this.yeniÜrünEkleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // frmUrunleriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 509);
            this.Controls.Add(this.lstUrun);
            this.Name = "frmUrunleriGoster";
            this.Text = "frmUrunleriGoster";
            this.Load += new System.EventHandler(this.frmUrunleriGoster_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstUrun;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem ürünüDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÜrünEkleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}