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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kmt = new SqlCommand("insert Giderler (Elektirik , Su , Doğalgaz ,internet , Gıda , Personel , Diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txtElektirik.Text);
                kmt.Parameters.AddWithValue("@p2", txtSu.Text);
                kmt.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                kmt.Parameters.AddWithValue("@p4", txtinternet.Text);
                kmt.Parameters.AddWithValue("@p5", txtgıda.Text);
                kmt.Parameters.AddWithValue("@p6", txtPersonel.Text);
                kmt.Parameters.AddWithValue("@p7", txtDiğer.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Kaydedildi.");

            }
            catch (Exception)
            {

                MessageBox.Show("HEPPP HATA ! ! !.");
            }
          

        }
    }
}
