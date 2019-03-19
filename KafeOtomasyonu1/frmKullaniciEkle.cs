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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void bKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (kAdi.Text.Equals("") || kSifre.Text.Equals("") || tAd.Text.Equals("") || tSoyad.Text.Equals("")) // Bilgiler Boş Girilmediyse..
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Doldurunuz ! ");
                return;
            }
            else // Bilgiler eksiksiz girilmişse
            {
                string sql = "select KullaniciAdi from KullaniciTablosu where KullaniciAdi='" + kAdi.Text + "'";
                if (Kontroller.veriVarmi(sql)) // Veritabaninda Ayni isimde kullanici varsa 
                {
                    MessageBox.Show("Böyle Bir Kullanici Oldugu icin Ekleme islemi Yapamazsınız ! ");

                }
                else // Veritabaninda Ayni isimde kullanici yoksa 
                {
                    if (Kullanici.KullaniciEkle(kAdi, kSifre,tAd, tSoyad)) // Veritabanina ekleme
                    {

                        MessageBox.Show("Başarıyla kullanıcı eklenmiştir.");
                        kAdi.Text = "";
                        tAd.Text = "";
                        tSoyad.Text = "";
                    }
                    else // Vb Hatası olursa vs.
                        MessageBox.Show("Kullanıcı eklenemedi!");
                }

            }

        }
    }
}
