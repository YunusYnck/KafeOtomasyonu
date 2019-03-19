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
    class Siparis
    {
        public static bool siparisEkle(int masaNo)//Siparis tablosuna siparisleri ekliyor
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();
            try
            {
              
              SqlCommand cmd = new SqlCommand("insert into Siparis (MasaNo,Hesap) values (@masaNo, @hesap)", Veritabani.conn);
                cmd.Parameters.AddWithValue("@masano", masaNo);
                cmd.Parameters.AddWithValue("@hesap",'1');
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ ex);
                return false;

            }
        }
        public static bool siparisUrunEkle(object siparisNo, object urunNo, object urunAdet)
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into SiparisUrun (SiparisNo,UrunNo,UrunAdet) values (@siparisNo,@urunNo,@urunAdet)", Veritabani.conn);
                cmd.Parameters.AddWithValue("@siparisNo", siparisNo);
                cmd.Parameters.AddWithValue("@urunNo", urunNo);
                cmd.Parameters.AddWithValue("@urunAdet", urunAdet);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool siparisUrunTemizle(object siparisNo)
        {
            Veritabani.baglantiKontrol();
            try
            {
                SqlCommand cmd = new SqlCommand("delete from SiparisUrun where SiparisNo=@siparisNo", Veritabani.conn);
                cmd.Parameters.AddWithValue("@siparisNo", siparisNo);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool siparisTemizle(int siparisNo)
        {

            Veritabani.baglantiKontrol();
            try
            {

                SqlCommand cmd = new SqlCommand("delete from Siparis where SiparisNo=@siparisNo", Veritabani.conn);
                cmd.Parameters.AddWithValue("@siparisNo", siparisNo);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int siparisNoGetir(int masaNo)
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();
            DataTable dt = Veritabani.VeriGetir("select SiparisNo from Siparis where MasaNo=" + masaNo + " AND Hesap='True'");
            if (dt.Rows.Count > 0)
            {
                int siparisNo = Convert.ToInt32(dt.Rows[0][0].ToString());//yeni açılan masanın siparis numarasını aldık
                return siparisNo;
            }
            else
            {
                return -1;
            }
        }
        //   Masanumarası ile siparis numarasını bulur ve geri gönderir
    }
}
