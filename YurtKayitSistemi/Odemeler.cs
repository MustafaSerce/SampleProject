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
    public partial class Odemeler : Form
    {
        public Odemeler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void Odemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayıtDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtKayıtDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Gerekli değerleri datagridview'den çekmek
            int secilen;
            string id, ad, soyad, kalanborc;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalanborc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtOdemeid.Text = id;
            txtOdemeAd.Text = ad;
            txtOdemeSoyad.Text = soyad;
            txtOdemeKalan.Text = kalanborc;
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            //Kalan borcu hesaplatma ve txt'e verme
            int ödenen, kalan , yenikalan;
            ödenen = Convert.ToInt32(txtOdemeOdenen.Text);
            kalan = Convert.ToInt32(txtOdemeKalan.Text);
            yenikalan = kalan - ödenen;
            txtOdemeKalan.Text = yenikalan.ToString();
            
            //Kalan Borcu Güncelleme
            SqlCommand kmt1 = new SqlCommand("update Borclar set OgrKalanborc=@c1 where Ogrid=@c2 ", bgl.baglanti());
            kmt1.Parameters.AddWithValue("@c2", txtOdemeid.Text);
            kmt1.Parameters.AddWithValue("@c1", txtOdemeKalan.Text);
            kmt1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ödeme Başarıyla Alınmıştır");
            this.borclarTableAdapter.Fill(this.yurtKayıtDataSet2.Borclar);

            //Kasa Tablosuna Ekleme yapma
            SqlCommand kmt0 = new SqlCommand("insert Kasa (ÖdemeAy,ÖdemeMiktar) values (@k1,@k2)",bgl.baglanti());
            kmt0.Parameters.AddWithValue("@k1", txtÖdemeAy.Text);
            kmt0.Parameters.AddWithValue("@k2", txtOdemeOdenen.Text);
            kmt0.ExecuteNonQuery();
            bgl.baglanti().Close();



        }
    }
}
