using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmGelirİstatistik : Form
    {
        public FrmGelirİstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmGelirİstatistik_Load(object sender, EventArgs e)
        {
            //KASADAKİ TOPLAM TUTAR
            SqlCommand kmt = new SqlCommand("select sum(ÖdemeMiktar) from Kasa",bgl.baglanti());
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lblkasa.Text = oku[0].ToString() + " TL" ;
            }
            bgl.baglanti().Close();

            //Tekrarsız şekilde ayları çekme
            SqlCommand kmt2 = new SqlCommand("select distinct(ÖdemeAy) from Kasa",bgl.baglanti());
            SqlDataReader oku2 = kmt2.ExecuteReader();
            while (oku2.Read())
            {
                cmbay.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut = new SqlCommand("select ÖdemeAy, sum(ÖdemeMiktar) from Kasa group by ÖdemeAy", bgl.baglanti());
            SqlDataReader oku4 = komut.ExecuteReader();
            while (oku4.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku4[0], oku4[1]);

            }
            bgl.baglanti().Close();
        }

        private void cmbay_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aylık kazanç çekme
            SqlCommand kmt = new SqlCommand("select sum(ÖdemeMiktar) from Kasa where ÖdemeAy=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", cmbay.Text);
            SqlDataReader oku = kmt.ExecuteReader();
            while(oku.Read())
            {
                lblay.Text = oku[0].ToString() + " TL" ;
            }
            bgl.baglanti().Close();
        }
    }
}
