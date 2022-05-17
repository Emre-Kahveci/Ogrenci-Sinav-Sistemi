using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class frmKullaniciKayit : Form
    {
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }
         
        private string connStr = @"Data Source=.\; Initial Catalog=test; Integrated Security=True";
        private void KisiEkle(string KullaniciAdi, string eMail, string Sifre, string Ad, string Soyad, int okulNo, int userType)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("Insert Into Kisi (KullaniciAdi, eMail, Sifre, Ad, Soyad, okulNo, userType)" +
                "                            values (@KullaniciAdi, @eMail, @Sifre, @Ad, @Soyad, @okulNo,@userType)", con);
            cmd.Parameters.AddWithValue("KullaniciAdi", KullaniciAdi);
            cmd.Parameters.AddWithValue("eMail", eMail);
            cmd.Parameters.AddWithValue("Sifre", Sifre);
            cmd.Parameters.AddWithValue("Ad", Ad);
            cmd.Parameters.AddWithValue("Soyad", Soyad);
            cmd.Parameters.AddWithValue("okulNo", okulNo);
            cmd.Parameters.AddWithValue("userType", userType);
            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Kişi eklendi");
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtPassword.Text) || 
                string.IsNullOrEmpty(txtNumara.Text) || cmbuserType.SelectedIndex == -1)
            {
                MessageBox.Show("Kişi Eklenmedi, Hata Sebebi: Boş bırakılan alan/alanlar");
                return;
            }
            try
            {
                KisiEkle(txtKullaniciAdi.Text, txtMail.Text, txtPassword.Text, 
                        txtAd.Text, txtSoyad.Text, Convert.ToInt32(txtNumara.Text),
                        cmbuserType.SelectedIndex);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Başarısız. Hata: " + ex.Message);
                throw ex;
            }
        }

        private void txtNumara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
