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
    public partial class frmSifremiUnuttum : Form
    {
        private string connStr = @"Data Source=.\; Initial Catalog=test; Integrated Security=True";
        SqlDataReader reader;
        SqlCommand cmd;
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void sifremiUnuttum(string kullaniciAdi, string eMail)
        {
            SqlConnection con = new SqlConnection(connStr);
            cmd = new SqlCommand("Select * From Kisi Where KullaniciAdi = '" + kullaniciAdi + "' and eMail = '" + eMail + "'", con);
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Şifre maile yollandı");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi! Kullanıcı adı ve E-Mail eşleşmiyor");
            }
        }
        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            sifremiUnuttum(txtKullaniciAdi.Text, txtMail.Text);
        }
    }
}
