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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayıtDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);

        }

        private void picBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut = new SqlCommand("insert Bolumler (BolumAd) values (@p1)",bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut.ExecuteNonQuery();
                this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Başarıyla Eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Bölüm Eklenirken Bir Hatayla Karşılaştı.");
            }

        }

        private void picBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumID=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumid.Text);
                komut2.ExecuteNonQuery();
                this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);
                MessageBox.Show("İşlem Başarıyla Tamamlandı.");
                bgl.baglanti().Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata ile karşılaştınız.");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtBolumid.Text = id;
            txtBolumAd.Text = bolumad;
        }

        private void picBolumGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komut3 = new SqlCommand("update Bolumler Set BolumAd=@p1 where BolumID=@p2",bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", txtBolumid.Text);
                komut3.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("İşlem Başarıyla Gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata ile karşılaştınız.");
            }
        }
    }
}
