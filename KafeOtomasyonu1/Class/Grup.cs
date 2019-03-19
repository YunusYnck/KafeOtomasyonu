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
    class Grup
    {
        public static bool grupEkle(TextBox tGruptext)//urun grubu eklemek için
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();
            try
            {
                
          //      SqlCommand cmd = new SqlCommand("insert into UrunGrubu (Adi) values (@Adi)", Veritabani.conn);
                string  sorgu = "insert into UrunGrubu (Adi) values (@Adi)";
                SqlCommand cmd = new SqlCommand(sorgu, Veritabani.conn);
 
              cmd.Parameters.AddWithValue("@Adi",tGruptext.Text);
                cmd.ExecuteNonQuery();
    
                Veritabani.conn.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }

        }
        public static bool grupDuzenle(object grupNo, object adi)//urun grubu duzenlemek için
        {
            Veritabani.conn.Close();
            Veritabani.baglantiKontrol();
            try
            {
                string sorgu = "update UrunGrubu set Adi=@adi where UrunGrupNo=@grupno";
                SqlCommand cmd = new SqlCommand(sorgu, Veritabani.conn);
                cmd.Parameters.AddWithValue("@grupno", grupNo);
                cmd.Parameters.AddWithValue("@adi",adi);
                
              //  cmd.Parameters.Add("@grupno", SqlDbType.Int).Value = Convert.ToInt32(grupNo);
             //   cmd.Parameters.Add("@adi", SqlDbType.NVarChar).Value = adi;
              //  
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
