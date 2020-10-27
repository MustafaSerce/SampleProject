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
using System.Security.Cryptography;

namespace YurtKayitSistemi
{
    public partial class FrmOgrenciKayit : Form
    {
        public FrmOgrenciKayit()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bölümleri listeleme komutları

            SqlCommand komut = new SqlCommand("Select BolumAd from Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbBolum.Items.Add(oku[0].ToString());

            }
            bgl.baglanti().Close();

            //Boş odaları listeleme komutları

            SqlCommand komut2 = new SqlCommand("Select Odano from Odalar where Odaaktif!=Odakapasite", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            //Öğrenci Kaydetme komutları
            try
            {

                SqlCommand komut = new SqlCommand("insert Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres, " +
                    "OgrDogumTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p3", mskTC.Text);
                komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komut.Parameters.AddWithValue("@p5", cmbBolum.Text);
                komut.Parameters.AddWithValue("@p6", txtMail.Text);
                komut.Parameters.AddWithValue("@p7", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p8", txtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p9", mskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p10", richtxtAdres.Text);
                komut.Parameters.AddWithValue("@p11", mskDogumTarih.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Kayıt Edildi.");


                //Label12 ' ye ıd yi çekmek
                SqlCommand kmt2 = new SqlCommand("select Ogrid from Ogrenci",bgl.baglanti());
                SqlDataReader oku = kmt2.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();

                }
                bgl.baglanti().Close();

                //Öğrenci Borç Alanı Oluşturma
                SqlCommand kmt = new SqlCommand("insert Borclar (Ogrid,OgrAd,OgrSoyad) values (@b1,@b2,@b3)",bgl.baglanti());
                kmt.Parameters.AddWithValue("@b1", label12.Text);
                kmt.Parameters.AddWithValue("@b2", txtOgrAd.Text);
                kmt.Parameters.AddWithValue("@b3", txtOgrSoyad.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hatayla Karşılaştınız.");
            }

            SqlCommand kmtm = new SqlCommand("update Odalar set Odaaktif = Odaaktif+1 where Odano=@oda1",bgl.baglanti());
            kmtm.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            kmtm.ExecuteNonQuery();
            bgl.baglanti().Close();
            

        }
    }
}
