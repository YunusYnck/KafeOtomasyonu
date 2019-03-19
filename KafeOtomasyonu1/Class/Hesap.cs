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
    class Hesap
    {
        public static bool hesapOde(object siparisNo, object odemeTuru, object tutar,object tarih)
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();

            try
            {
                SqlCommand cmd = new SqlCommand("update Siparis set Hesap='False' where SiparisNo=" + siparisNo + " ", Veritabani.conn);
                cmd.ExecuteNonQuery();
                SqlCommand Hesap = new SqlCommand("insert into Hesap (SiparisNo,OdemeTuruNo,Tutar,Tarih) values (@siparisNo,@odemeTuruNo,@tutar,@tarih)", Veritabani.conn);
                Hesap.Parameters.AddWithValue("@siparisNo", siparisNo);
                Hesap.Parameters.AddWithValue("@odemeTuruNo", odemeTuru);
                Hesap.Parameters.AddWithValue("@tutar", tutar);
                Hesap.Parameters.AddWithValue("@tarih", tarih);
                Hesap.ExecuteNonQuery();
               
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool satisekle(object masano, object tarih, object odemeTuru, object tutar, object siparisNo)
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();

            try
            {
                SqlCommand cmd = new SqlCommand("insert into Satislar (MasaNumarasi,Tarih,OdemeTuru,Tutar,SiparisNo) values (@masano,@tarih,@odemeTuru,@tutar,@siparisNo)", Veritabani.conn);
                cmd.Parameters.AddWithValue("@masano", masano);
                cmd.Parameters.AddWithValue("@tarih", tarih);
                cmd.Parameters.AddWithValue("@odemeTuru", odemeTuru);
                cmd.Parameters.AddWithValue("@tutar", tutar);
                cmd.Parameters.AddWithValue("@siparisNo", siparisNo);
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
