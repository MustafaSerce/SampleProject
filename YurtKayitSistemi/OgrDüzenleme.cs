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
    public partial class OgrDüzenleme : Form
    {
        public OgrDüzenleme()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,tc,tel,dogumtarih,bolum,mail,odano,veliadsoyad,velitel,veliadres;

        private void btnOgrSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kmt = new SqlCommand("delete from Ogrenci where Ogrid=@ogr1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@ogr1", txtOgrid.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Silindi");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA ! ! !");
            }


            SqlCommand kmt1 = new SqlCommand("update Odalar set Odaaktif= Odaaktif-1 where Odano=@oda1",bgl.baglanti());
            kmt1.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            kmt1.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kmt = new SqlCommand("Update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrBolum=@p6,OgrMail=@p7,OgrOdaNo=@p8,OgrVeliAdSoyad=@p9,OgrVeliTelefon=@p10,OgrVeliAdres=@p11,OgrDogumTarihi=@p12 where Ogrid=@p1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txtOgrid.Text);
                kmt.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                kmt.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                kmt.Parameters.AddWithValue("@p4", mskTC.Text);
                kmt.Parameters.AddWithValue("@p5", mskTelefon.Text);
                kmt.Parameters.AddWithValue("@p6", cmbBolum.Text);
                kmt.Parameters.AddWithValue("@p7", txtMail.Text);
                kmt.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                kmt.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
                kmt.Parameters.AddWithValue("@p10", mskVeliTelefon.Text);
                kmt.Parameters.AddWithValue("@p11", richtxtAdres.Text);
                kmt.Parameters.AddWithValue("@p12", mskDogumTarih.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı Bir Şekilde Gerçekleşti.");
                
            }
            catch (Exception)
            {

                MessageBox.Show("HATAA!!");
            }
        }

        private void OgrDüzenleme_Load(object sender, EventArgs e)
        {
            
            txtOgrid.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskTC.Text = tc;
            mskTelefon.Text = tel;
            mskDogumTarih.Text = dogumtarih;
            cmbBolum.Text = bolum;
            txtMail.Text = mail;
            cmbOdaNo.Text=odano;
            txtVeliAdSoyad.Text = veliadsoyad;
            mskVeliTelefon.Text = velitel;
            richtxtAdres.Text = veliadres;
        }
    }
}
