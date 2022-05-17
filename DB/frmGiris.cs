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
    public partial class frmGiris : Form
    {
        private string connStr = @"Data Source=.\; Initial Catalog=test; Integrated Security=True";
        SqlDataReader reader;
        SqlCommand cmd;
        public static int okulNo;
        private void GirisYap(string kullaniciAdi, string Sifre)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();            

            cmd = new SqlCommand("Select * From Kisi Where KullaniciAdi = '" + kullaniciAdi + "' and Sifre = '" + Sifre + "'", con);            

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                okulNo = Convert.ToInt32(reader["okulNo"]);
                string msg = "Giriş Başarılı, ";
                switch (reader["userType"].ToString())
                {
                    case "0":
                        msg += "Admin";
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.Show();
                        break;
                    case "1":
                        msg += "Sınav Sorumlusu";
                        //TODO: Sınav Sorumlu
                        break;
                    case "2":
                        msg += "Öğrenci";
                        frmOgrenci frmOgrenci = new frmOgrenci();
                        frmOgrenci.Show();
                        break;
                }
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Hatalı Giriş! Kullanıcı adı veya Şifre yanlış");
            }
        }
        public frmGiris()
        {
            InitializeComponent();
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit frmKullaniciKayit = new frmKullaniciKayit();
            frmKullaniciKayit.Show();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisYap(txtKullaniciAdi.Text, txtPassword.Text);
        }
        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            frmSifremiUnuttum frmSifremiUnuttum = new frmSifremiUnuttum();
            frmSifremiUnuttum.Show();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }
    }
}
