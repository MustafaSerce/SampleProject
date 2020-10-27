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
    public partial class FrmYöneticiDüzenle : Form
    {
        public FrmYöneticiDüzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmYöneticiDüzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayıtDataSet5.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtKayıtDataSet5.Admin);

        }

        private void picYöneticiEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert Admin (YöneticiAd,YöneticiSifre) values (@p1,@p2)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtKullanıcıAdi.Text);
            kmt.Parameters.AddWithValue("@p2", txtSifre.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ekleme İşlemi Tamamlandı.");
            this.adminTableAdapter.Fill(this.yurtKayıtDataSet5.Admin);
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string yöneticiad, yöneticisoyad, yöneticiid;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            yöneticiid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            yöneticiad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yöneticisoyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtYöneticiid.Text = yöneticiid;
            txtKullanıcıAdi.Text = yöneticiad;
            txtSifre.Text = yöneticisoyad;
        }

        private void picYöneticiSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kmt = new SqlCommand("delete from Admin where Yöneticiid=@p1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txtYöneticiid.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi Gerçekleşti");
                this.adminTableAdapter.Fill(this.yurtKayıtDataSet5.Admin);
            }
            catch (Exception)
            {

                MessageBox.Show("HATAAAAAA!!!!!!!!!!!!!");
            }
        }

        private void picYöneticiGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kmt = new SqlCommand("update Admin set YöneticiAd=@p1,YöneticiSifre=@p2 where Yöneticiid=@p3", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txtKullanıcıAdi.Text);
                kmt.Parameters.AddWithValue("@p2", txtSifre.Text);
                kmt.Parameters.AddWithValue("@p3", txtYöneticiid.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Başarı ile Gerçekleşti.");
                this.adminTableAdapter.Fill(this.yurtKayıtDataSet5.Admin);
            }
            catch (Exception)
            {

                MessageBox.Show("HATAA!!!!.");
            }

        }
    }
}
