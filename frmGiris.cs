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
    public partial class frmGiris : Form
    {
        public static string kullaniciAdi;
        public static string kullaniciSifresi;
        public frmGiris()
        {
            InitializeComponent();

        }
        private void bGiris_Click(object sender, EventArgs e)
        {
            if(tKullaniciAdi.Text.Equals(""))//Kullanici Adi Boşsa
            {
                MessageBox.Show("Lütfen Kullanici Adi Alanını Boş Bırakmayınız !");
                return;//Programı durdurmak için
            }
            else if(tSifre.Text.Equals(""))//Şifre Boşsa
            {
                MessageBox.Show("Lütfen Kullanici Şifresi Alanını Boş Bırakmayınız !");
                return;//Programı durdurmak için
            }
            if (tKullaniciAdi.Text.Equals("Admin") && tSifre.Text.Equals("sifre"))//KullanıcıAdi ve Şifre Dogruysa
            {
                kullaniciAdi = "Admin";
                kullaniciSifresi = "sifre";
                this.Hide();
                frmAna frmAna = new frmAna();//Diger Forma Geçiş 
                frmAna.ShowDialog();
    

            }
            else //Bilgilerden Herhangi Biri Yanlışsa
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış !");
                
        }
    }
}
