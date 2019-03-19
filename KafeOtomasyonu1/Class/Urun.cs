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
    class Urun
    {
        public static bool urunEkle(TextBox turunAdi, TextBox turunFiyati, int secNo, Label lblResimYolu)
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();

            try
            {
          String sorgu = "insert into Urun (Adi,Fiyati,UrunGrupNo,ResimYolu,SilinmisMi) values (@adi,@fiyati,@urungrupno,@resimyolu,@silinmismi)";
        
                SqlCommand cmd = new SqlCommand(sorgu, Veritabani.conn);
                cmd.Parameters.AddWithValue("@adi",turunAdi.Text );
                cmd.Parameters.AddWithValue("@fiyati", turunFiyati.Text);
                cmd.Parameters.AddWithValue("@urungrupno",secNo);
                cmd.Parameters.AddWithValue("@resimyolu", lblResimYolu.Text);
                cmd.Parameters.AddWithValue("@silinmismi", false);
             
                cmd.ExecuteNonQuery();
               
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool urunDuzenle(object urunNo, object resimYolu, object fiyat, object grupNo, object urunAdi)
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();

            try
            {
                SqlCommand cmd = new SqlCommand("update Urun set ResimYolu=@resimyolu, Fiyati=@fiyati, UrunGrupNo=@urungrupno, Adi=@adi  where UrunNo=@urunno", Veritabani.conn);
                cmd.Parameters.Add("@resimyolu", SqlDbType.NVarChar).Value = resimYolu;
                cmd.Parameters.Add("@fiyati", SqlDbType.Money).Value = fiyat;
                cmd.Parameters.Add("@urungrupno", SqlDbType.Int).Value = grupNo;
                cmd.Parameters.Add("@adi", SqlDbType.NVarChar).Value = urunAdi;
                cmd.Parameters.Add("@urunno", SqlDbType.Int).Value = urunNo;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool urunDuzenle(object UrunNo, bool SilinmisMi)
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();

            try
            {
                SqlCommand cmd = new SqlCommand("update Urun set SilinmisMi=@SilinmisMi where UrunNo=@UrunNo", Veritabani.conn);
                cmd.Parameters.Add("@SilinmisMi", SqlDbType.Bit).Value = SilinmisMi;
                cmd.Parameters.Add("@UrunNo", SqlDbType.Int).Value = UrunNo;
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
