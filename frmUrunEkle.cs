using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeOtomasyonu1
{
    public partial class frmUrunEkle : Form
    {
        object cSecilen;
        private void bFotografSec_Click(object sender, EventArgs e)
        {
            FileDialog.Title = "Resimi Seçiniz";
            FileDialog.Filter = "Tümü|*.png;*.jpg;*ico;*.gif|png|*.png|jpeg|*.jpg|icon|*ico|gif|*.gif"; // Filtreleme yapıyoruz.
            FileDialog.DefaultExt = "jpg";
            FileDialog.RestoreDirectory = true; // Secilen son dizinin gösterilmesini saglıyoruz 
            FileDialog.FileName = "";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.Copy(@FileDialog.FileName, FileDialog.SafeFileName);
                    lblResimYolu.Text = @FileDialog.SafeFileName;
                    pUrunResmi.Image = Image.FromFile(lblResimYolu.Text);
                    pUrunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                }
                catch
                {
                    MessageBox.Show("Ürün Resmi Bulunmaktadır !");
                }
            }
        }

        private void bGrupEkle_Click(object sender, EventArgs e)
        {
            frmGrupEkle frmGrupEkle = new frmGrupEkle();
            frmGrupEkle.Show();
        }

        public frmUrunEkle()// Form acıldıgı zaman yapılacak işlemler 
        {
            InitializeComponent();
            ComboDoldur();// Urun grubunu doldurduk #
        }
         private void bUrunEkle_Click(object sender, EventArgs e)
        {
            int secNo = (int)cSecilen;
            if (turunAdi.Equals("") || turunFiyati.Equals("") || cGrup.Equals(""))//Veriler Boşsa Ekleme Yapılmamalı
            {
                MessageBox.Show("Bilgileri Eksiksiz Giriniz !");
            }
            else
            {

                if (Kontroller.veriVarmi("select Adi from Urun where Adi='" + turunAdi.Text + "'"))// ürünAdı var mı onu kontrol ediyoruz 
                {
                    MessageBox.Show("Bu ürün adi zaten var !");
                }
                else
                {
                        if (lblResimYolu.Text == "") // Resim Seçilmiş Mi ?
                        {
                            MessageBox.Show("Resim Ekleyiniz !");
                            return;
                        }
             
                    if (Urun.urunEkle(turunAdi, turunFiyati, secNo, lblResimYolu))
                        {
                            MessageBox.Show("Ürün Başarıyla Eklenmiştir !!");
                            turunAdi.Clear();
                            turunFiyati.Clear();
                            cGrup.SelectedIndex = 0;
                            pUrunResmi.Image = null;
                            lblResimYolu.Text = "";
                        }
                }
              }
                   /*   else
                        {
                            turunAdi.Clear();
                            turunFiyati.Clear();
                            cGrup.SelectedIndex = 0;
                            pUrunResmi.Image = null;
                            lblResimYolu.Text = "";
                            MessageBox.Show("Ürün Eklenemedi Hata!!");
                        }*/
          }
    
        public void ComboDoldur()
        {
            DataTable dt = Veritabani.VeriGetir("select * from UrunGrubu"); // Urun gruplarını comboBoxa doldurduk..
            cGrup.DataSource = dt;
            cGrup.DisplayMember = "Adi";
            cGrup.ValueMember = "UrunGrupNo";
            cSecilen = cGrup.SelectedValue;  
        }
   /*     private void turunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (turunFiyati.Text.IndexOf(',') != -1)
            {
                if (e.KeyChar == (char)44)
                {
                    e.Handled = true;
                }
            }
            Kontroller.ParaKontrol(e);
        }*/

        private void cGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cSecilen = cGrup.SelectedValue;
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void bUrunGoster_Click(object sender, EventArgs e)
        {
            frmUrunleriGoster frm = new frmUrunleriGoster();
            frm.ShowDialog();
        }
    }
}
