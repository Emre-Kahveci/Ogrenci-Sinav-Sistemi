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
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
        public static int coozmekIstenilenSoruSayisi;
        public static int okulNo;
        string sinavID;
        public void btnSoruCozum_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoruSayisi.Text, out int istenilenSoruSayisi))
            {
                MessageBox.Show("Sayı giriniz.");
                return;
            }

            if (istenilenSoruSayisi < 10)
            {
                MessageBox.Show("Soru sayisi 10'dan küçük olamaz");
                return;
            }
            coozmekIstenilenSoruSayisi = istenilenSoruSayisi;
            frmSoruCozum frmSoruCozum = new frmSoruCozum();
            frmSoruCozum.Show();
        }
        private void btnGecmisSinavlar_Click(object sender, EventArgs e)
        {
            rTxtGecmisSinavlar.Text = "";
            Control control = (Control)(btnGecmisSinavlar as Button).Parent;
            control.Size = new Size(330, 373);
            okulNo = frmGiris.okulNo;
            testEntities testEntities = new testEntities();
            var item = testEntities.sinavSonuclaris.Where(sinav => sinav.okulNo == okulNo).ToArray();
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
                rTxtGecmisSinavlar.Text = "Geçmiş sınavınız bulunamadı.";
            }
        }
        private void btnAnalizRaporu_Click(object sender, EventArgs e)
        {
            frmAnalizRaporu frmAnalizRaporu = new frmAnalizRaporu();
            frmAnalizRaporu.Show();
        }
        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'testDataSet.Sinav' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sinavTableAdapter.Fill(this.testDataSet.Sinav);

        }

        private void btnSinavaGir_Click(object sender, EventArgs e)
        {
            sinavID = cmBoxSinav.Text;
            frmSinavCozum frmSinavCozum = new frmSinavCozum(sinavID);
            frmSinavCozum.Show();
        }
    }
}
