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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayıtDataSet6.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtKayıtDataSet6.Personel);

        }

        private void picPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                //Personel Ekleme
                SqlCommand kmt = new SqlCommand("insert Personel (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2) ", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txtPersonelAdi.Text);
                kmt.Parameters.AddWithValue("@p2", txtPersonelGörev.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Kayıt edildi");
                this.personelTableAdapter.Fill(this.yurtKayıtDataSet6.Personel);

            }
            catch (Exception)
            {

                MessageBox.Show("HATA ! ! ! ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string personeladsoyad, personelgörev,personelid;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            personelid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            personeladsoyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            personelgörev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtPersonelid.Text = personelid;
            txtPersonelAdi.Text = personeladsoyad;
            txtPersonelGörev.Text = personelgörev;
        }

        private void picPersoneliGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kmt = new SqlCommand("Update Personel set PersonelAdSoyad=@k1,PersonelDepartman=@k2 where Personelid=@k3", bgl.baglanti());
                kmt.Parameters.AddWithValue("@k1", txtPersonelAdi.Text);
                kmt.Parameters.AddWithValue("@k2", txtPersonelGörev.Text);
                kmt.Parameters.AddWithValue("@k3", txtPersonelid.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Güncellendi");
                this.personelTableAdapter.Fill(this.yurtKayıtDataSet6.Personel);
            }
            catch (Exception)
            {

                MessageBox.Show("HATA !!!");
            }

        }

        private void picPersonelSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kmt = new SqlCommand("Delete from Personel where Personelid=@p1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txtPersonelid.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Silindi");
                this.personelTableAdapter.Fill(this.yurtKayıtDataSet6.Personel);
            }
            catch (Exception)
            {

                MessageBox.Show("HATA ! ! ! ");
            }

        }
    }
}
