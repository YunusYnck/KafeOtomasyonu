using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace KafeOtomasyonu1
{
    class Kullanici
    {
        public static bool KullaniciEkle(TextBox kAdi, TextBox kSifre, TextBox tAd, TextBox tSoyad)//ilk kısımda kullaniciekle için kullandık.
        {
              Veritabani.conn.Close();
            Veritabani.baglantiKontrol();
            try
            {
                string sorgu = "insert into KullaniciTablosu (KullaniciAdi,Sifre,Adi,Soyadi) values (@KullaniciAdi,@Sifre,@Adi,@Soyadi)";
                SqlCommand cmd = new SqlCommand(sorgu, Veritabani.conn);
      //          MessageBox.Show(""+kAdi.GetType());
                cmd.Parameters.AddWithValue("@KullaniciAdi", kAdi.Text);
                cmd.Parameters.AddWithValue("@Sifre", kSifre.Text);
                cmd.Parameters.AddWithValue("@Adi", tAd.Text);
                cmd.Parameters.AddWithValue("@Soyadi", tSoyad.Text);
                cmd.ExecuteNonQuery();
                Veritabani.conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool KullaniciSifreDegistir(object KullaniciAdi, object Sifre,TextBox tYeniSifre)
        {
            Veritabani.baglantiKontrol();
            try
            {
                SqlCommand cmd = new SqlCommand("update KullaniciTablosu set Sifre=@Sifre where KullaniciAdi=@KullaniciAdi", Veritabani.conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", tYeniSifre.Text);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
