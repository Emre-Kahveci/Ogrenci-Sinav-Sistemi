using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        int ogrenciNo;
        private void btnSoruHazirlama_Click(object sender, EventArgs e)
        {
            frmSoruHazirlama frmSoruHazirlama = new frmSoruHazirlama();
            frmSoruHazirlama.Show();
        }
        private void btnGecmisSinavlar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrenciNo.Text))
            {
                MessageBox.Show("Öğrenci NO boş bırakılamaz");
                return;
            }
            rTxtGecmisSinavlar.Text = "";
            Control control = (Control)(btnGecmisSinavlar as Button).Parent;
            control.Size = new Size(511, 254);
            testEntities testEntities = new testEntities();
            ogrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
            var item = testEntities.sinavSonuclaris.Where(sinav => sinav.okulNo == ogrenciNo).ToArray();
            if (item.Length > 0)
            {
                foreach (var entity in item)
                {
                    string msg = "";
                    msg += "Sınav tarihi: " + entity.sinavTarih;
                    msg += "\nSoru sayısı: " + entity.soruSayisi;
                    msg += "\nDoğru sorular: " + entity.dogruSayisi;
                    msg += " / " + entity.dogruYapilanSorular;
                    msg += "\nYanlış sorular: " + entity.yanlisSayisi;
                    msg += " / " + entity.yanlisYapilanSorular + "\n\n";
                    rTxtGecmisSinavlar.Text += msg;
                }
            }
            else
            {
                rTxtGecmisSinavlar.Text = "Öğrenci NO'su verilen öğrenci bulunamadı.";
            }
        }
        private void txtOgrenciNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnSinavHazirla_Click(object sender, EventArgs e)
        {
            frmSinavHazirlama frmSinavHazirlama = new frmSinavHazirlama();
            frmSinavHazirlama.ShowDialog();
        }
    }
}
