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
    class Veritabani
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=kafe;Integrated Security=True");
        //deneme tabanı kafe2
        public static void baglantiKontrol() //Bağlantı kapalıysa açmak için kullandık
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    MessageBox.Show("Veri Tabanı Bağlantısı Yapılamadı");
                    Application.Exit();
                }
            }
        }
        public static DataTable VeriGetir (string sql) //Tüm işlemler için
        {
            Veritabani.conn.Close();
            baglantiKontrol();
            DataTable dt = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter(sql, conn);
            adptr.Fill(dt);
            
            return dt;
        }
    }
}
