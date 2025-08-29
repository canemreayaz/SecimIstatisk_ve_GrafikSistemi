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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=AYAZ;Initial Catalog=DBSECIMPROJE;" +
            "Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // ilçe adlarını Comboboxa çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            baglanti.Close();

            // Grafiğe toplam sonuçları getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT SUM(APARTI), SUM(BPARTI), SUM(CPARTI), SUM(DPARTI), SUM(EPARTI) " +
                "FROM TBLILCE", baglanti);

            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ",dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);
            }
            baglanti.Close();
        }
        // tıklandığında oy oranalrını görüceksin
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLILCE where ILCEAD = @P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                lbl_a.Text = dr[2].ToString();
                lbl_b.Text = dr[3].ToString();
                lbl_c.Text = dr[4].ToString();
                lbl_d.Text = dr[5].ToString();
                lbl_e.Text = dr[6].ToString();
                lbl_nufus.Text = dr[7].ToString();
                lbl_kisiSayısı.Text = dr[8].ToString();
                lbl_kullanılanOy.Text = dr[9].ToString();
                lbl_gecerliOy.Text = dr[10].ToString();
                lbl_gecersizOy.Text = dr[11].ToString();
            }
            baglanti.Close();
        }
        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grafik Bilgilerinden Çıkış Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            

        }
        private void progressBar5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_a_Click(object sender, EventArgs e)
        {

        }

       
    }
}
