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
    
    class Kontroller
    {     
        public static bool veriVarmi(string sql)
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();
            SqlCommand cmd = new SqlCommand(sql, Veritabani.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool kullaniciKontrolu(string kulAdi, string sifre)//kullanici adi ve şifresini kontrolünü yaptırıyoruz
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();
            SqlCommand cmd = new SqlCommand("select KullaniciNo from Kullanici where KullaniciAdi=@kuladi and Sifre=@sifre", Veritabani.conn);
            cmd.Parameters.Add("@kuladi", SqlDbType.NVarChar).Value = kulAdi;
            cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = sifre;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                Veritabani.conn.Close();
                return true;

            }
            else
            {
                return false;
            }
        }
        public static void SayiKontrol(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08) // 08 del tusunu aktif eder
            {
                e.Handled = true;
            }
        }
        public static void ParaKontrol(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                //text'e sadece sayıların girmesi,geri silme tuşu(ascii kodu:08),virgül(ascii kodu:44) karakterinin girilmesini sağlar.
                e.Handled = true;
            }
        }
    }
}
