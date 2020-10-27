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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from Admin where YöneticiAd=@p1 and YöneticiSifre=@p2",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtKullanıcıAdi.Text);
            kmt.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı yada Şifre ");
                txtKullanıcıAdi.Clear();
                txtSifre.Clear();
                txtKullanıcıAdi.Focus();
            }
        }
    }
}
