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
    public partial class frmSatisRaporu : Form
    {
        public frmSatisRaporu()
        {
            InitializeComponent();
        }

        private void frmSatisRaporu_Load(object sender, EventArgs e)
        {
            gridSatislar.DataSource = Veritabani.VeriGetir("select * from Satislar");
            gridSatislar.Columns[4].Visible = false;
            gridSatislar.Columns[5].Visible = false;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " dd.MM.yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = " dd.MM.yyyy";

            dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            dateTimePicker2.Value = DateTime.Now;

            dateTimePicker1_ValueChanged(null, null);
        }

        private void txtMasaNo_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(null, null);
        }

        private void dateTimePicker1_ValueChanged(object p1, object p2)
        {
            if (txtMasaNo.Text == "")
            {
                DataTable dt = Veritabani.VeriGetir("select MasaNumarasi,Tarih,OdemeTuru,Tutar from Satislar where Tarih = '" + dateTimePicker1.Text + "'");
                gridSatislar.DataSource = dt;

            }
            else
            {
                DataTable dt = Veritabani.VeriGetir("select MasaNumarasi,Tarih,OdemeTuru,Tutar from Satislar where MasaNumarasi = " + txtMasaNo.Text + " and Tarih = '" + dateTimePicker1.Text + "'  ");
                gridSatislar.DataSource = dt;

            }

        }

        private void txtMasaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontroller.SayiKontrol(e);
        }
        private void gridSatislar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(null, null);
        }

        private void gridSatislar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }

}
