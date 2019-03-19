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
    public partial class frmGrupEkle : Form
    {
        public frmGrupEkle()
        {
            InitializeComponent();
            comboDoldur();
        }

        private void bGrupEkle_Click(object sender, EventArgs e)
        {
            if (tGrupEkle.Equals(""))
            {
                MessageBox.Show("GrupAdi Boş Geçilemez !");
            }
            else
            {
                string sql = "select Adi from UrunGrubu where Adi='" + tGrupEkle.Text + "'";
                if (Kontroller.veriVarmi(sql))
                {
                    MessageBox.Show("Böyle bir grup ismi bulunmaktadır !");
                }
                else
                {
                    if (Grup.grupEkle(tGrupEkle))
                    {
                        MessageBox.Show("Grup Başarıyla Eklenmiştir !");
                        comboDoldur();
                        tGrupEkle.Clear();
                    }
                    else
                    {
                        tGrupEkle.Clear();
                        MessageBox.Show("Grup Oluştururken Hata Meydana Geldi.");
                    }

                }
            }

        }
        object comboValue;
        private void comboDoldur()
        {
            DataTable dt = Veritabani.VeriGetir("select * from UrunGrubu");
            comboGruplar.DataSource = dt;
            comboGruplar.DisplayMember = "Adi";
            comboGruplar.ValueMember = "UrunGrupNo";
            comboValue = comboGruplar.SelectedValue;
        }

        private void bGrupDuzenle_Click(object sender, EventArgs e)
        {
            int cSecilen = (comboGruplar.SelectedIndex)+1;
            if (comboGruplar.Text == "" || tDGrupAdi.Text == "") // TextBox Kontrolü Yaptık.
            {
                if (tDGrupAdi.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Bırakmayınız!");
                }
                if (comboGruplar.Text == "")
                {
                    MessageBox.Show("Lütfen Grup Seçiniz.");
                }
            }
            else
            {
                if (Kontroller.veriVarmi("select Adi from UrunGrubu where Adi='" + tDGrupAdi.Text + "'")) // Degiştirilecek isim var mı ?
                {
                    MessageBox.Show("Böyle bir grup vardır.");
                }
                else
                {
                    if (Grup.grupDuzenle(cSecilen, tDGrupAdi.Text))
                    {
                        tDGrupAdi.Clear();
                        comboDoldur();
                        MessageBox.Show("Grup Başarılıyla Düzenlenmiştir !");
                    }
                    else
                    {
                        tDGrupAdi.Clear();

                        MessageBox.Show("Grup Düzenlenirken Hata Meydana Geldi !");
                    }
                }
            }
        }
        private void comboGruplar_Click(object sender, EventArgs e)
        {
            comboDoldur();
        }
    }
}
