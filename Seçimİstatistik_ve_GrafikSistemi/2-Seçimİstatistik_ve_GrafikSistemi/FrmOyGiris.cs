using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Seçimİstatistik_ve_GrafikSistemi
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=AYAZ;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void btn_oyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI, NUFUS, KULLANACAKKISISAYISI, KULLANILANOY, GECERLIOY, GECERSIZOY) " +
                "values (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtilce.Text);
            komut.Parameters.AddWithValue("@P2", txt_a.Text);
            komut.Parameters.AddWithValue("@P3", txt_b.Text);
            komut.Parameters.AddWithValue("@P4", txt_c.Text);
            komut.Parameters.AddWithValue("@P5", txt_d.Text);
            komut.Parameters.AddWithValue("@P6",txt_e.Text);
            komut.Parameters.AddWithValue("@P7", textBoxNufus.Text);
            komut.Parameters.AddWithValue("@P8", textBoxkisiSayısı.Text);
            komut.Parameters.AddWithValue("@P9", textBoxkullanılanOy.Text);
            komut.Parameters.AddWithValue("@P10", textBoxgecerliOy.Text);
            komut.Parameters.AddWithValue("@P11", textBoxgecersizOy.Text);

            /*
            int nufus = Convert.ToInt32(textBoxNufus.Text.ToString());

            int kisiSayisi = Convert.ToInt32(textBoxkisiSayısı.ToString());

            int klnoy = Convert.ToInt32(textBoxkullanılanOy.ToString());

            int gecerliOy = Convert.ToInt32(textBoxgecerliOy.Text.ToString());

            int gecersizOy = Convert.ToInt32(textBoxgecersizOy.Text.ToString());
            */


            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void btn_grafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            //FrmOyGiris frmOyGiris = new FrmOyGiris();
            //frmOyGiris.Close();
            MessageBox.Show("Seçim Sisteminden Çıkış Yapıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            
        }
        private void textBoxNufus_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtilce_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmOyGiris_Load(object sender, EventArgs e)
        {
            
           

            

        }
    }
}
