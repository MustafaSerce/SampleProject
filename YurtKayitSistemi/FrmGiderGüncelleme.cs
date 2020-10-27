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
    public partial class FrmGiderGüncelleme : Form
    {
        public FrmGiderGüncelleme()
        {
            InitializeComponent();
        }
        public string elektirik, su, dogalgaz, internet, gıda, personel, diger, id;
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmGiderGüncelleme_Load(object sender, EventArgs e)
        {
            txtid.Text = id;
            txtElektirik.Text = elektirik;
            txtSu.Text = su;
            txtDogalgaz.Text = dogalgaz;
            txtinternet.Text = internet;
            txtgıda.Text = gıda;
            txtPersonel.Text = personel;
            txtDiger.Text = diger;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kmt = new SqlCommand("update Giderler set Elektirik=@p2 , Su=@p3 , Doğalgaz=@p4 , internet=@p5 ,Gıda=@p6 , Personel=@p7 , Diger=@p8 where Odemeid=@p1",bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txtid.Text);
                kmt.Parameters.AddWithValue("@p2", txtElektirik.Text);
                kmt.Parameters.AddWithValue("@p3", txtSu.Text);
                kmt.Parameters.AddWithValue("@p4", txtDogalgaz.Text);
                kmt.Parameters.AddWithValue("@p5", txtinternet.Text);
                kmt.Parameters.AddWithValue("@p6", txtgıda.Text);
                kmt.Parameters.AddWithValue("@p7", txtPersonel.Text);
                kmt.Parameters.AddWithValue("@p8", txtDiger.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Güncellendi");
                
            }
            catch (Exception)
            {
                throw;
                MessageBox.Show("HATA ! ! ");
            }


        }
    }
}
