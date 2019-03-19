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
    public partial class frmSifreDegistir : Form
    {
        public frmSifreDegistir()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (tEskiSifre.Equals("") || tYeniSifre.Equals("") || tYeniSifre2.Equals(""))
            {
                MessageBox.Show("Eksik Bilgi Girildi !");
            }
            else
            {
                if (tYeniSifre.Text == tYeniSifre2.Text)
                {
                    if (Kullanici.KullaniciSifreDegistir(frmGiris.kullaniciAdi, frmGiris.kullaniciSifresi,tYeniSifre))
                    {
                        MessageBox.Show("Şifre Değiştirildi");
                    }
                    else
                        MessageBox.Show("Şifre Değiştirilemedi!");
                }
                else
                    MessageBox.Show("Yeni Şifre ve Tekrarı Aynı Degil ! ");
            }


        }
    }
}