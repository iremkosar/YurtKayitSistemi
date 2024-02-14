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
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from admin where yoneticiad=@p1 and yoneticisifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı ya da şifre girdiniz");
                txtKullaniciAd.Clear();
                txtSifre.Clear();
                txtKullaniciAd.Focus();
            }
            bgl.baglanti().Close();
        }
       
        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
