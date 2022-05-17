using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class frmSinavCozum : Form
    {
        public static testEntities testEntities { get; set; }
        public frmSinavCozum(string SinavID)
        {
            InitializeComponent();
            sinavID = SinavID;
            testEntities = new testEntities();
            var sinav = testEntities.Sinavs.Where(s => s.sinavID == sinavID).FirstOrDefault();
            ToplamSoruSayisi = sinav.soruIDler.Split(',').Length - 1;
            soruIDler = sinav.soruIDler.Split(',');
            sinavSuresi = sinav.sinavSuresi;
            MessageBox.Show("Sınav Soru Sayısı: " + ToplamSoruSayisi.ToString() + "\nSınav Süresi: " + sinavSuresi.ToString());
            soruID = soruIDler[soruSayisi];
            soru = SoruGetir(Convert.ToInt32(soruID));
            secenekOlustur(soru);
            LabelGuncelle(labelDurum);
            lblZaman.Text = $"Kalan Süre: {sinavSuresi} Dakika";
            zamanlayici.Start();
        }
        
        string sinavID;
        string[] soruIDler;
        string soruID;
        int ToplamSoruSayisi;
        int soruSayisi = 0;
        string[] soru;
        int dogruSayisi = 0;
        string dogruYapilanSorular = "";
        int yanlisSayisi = 0;
        string yanlisYapilanSorular = "";
        int okulNO = frmGiris.okulNo;
        int sinavSuresi;
        private string connStr = @"Data Source=.\; Initial Catalog=test; Integrated Security=True";
        private void LabelGuncelle(Label label)
        {
            label.Text = $"({soruSayisi+1}/{ToplamSoruSayisi})";
        }
        public string[] SoruGetir(int soruId)
        {
            var item = testEntities.Sorus.Where(soru => soru.soruID == soruId).FirstOrDefault();
            byte[] arr = item.resim;
            if (arr != null)
            {
                MemoryStream ms = new MemoryStream(arr);
                PBSoru.Image = Image.FromStream(ms);
            }
            else
            {
                PBSoru.Image = null;
            }
            int soruID = item.soruID;
            string soruMetin = item.soruMetin;
            string dogruCevap = item.dogruCevap;
            string yanlisCevap1 = item.yanlisCevap1;
            string yanlisCevap2 = item.yanlisCevap2;
            string yanlisCevap3 = item.yanlisCevap3;

            return new string[] { soruID.ToString(), soruMetin, dogruCevap, yanlisCevap1, yanlisCevap2, yanlisCevap3 };
        }
        private void cevapKontrol(string dogruCevap)
        {
            var checkedRadioButton = (btnYeniSoru as Button).Parent.Controls.OfType<RadioButton>().Where(radioButton => radioButton.Checked).FirstOrDefault();
            if (checkedRadioButton == null)
            {
                return;
            }
            switch (checkedRadioButton.Name)
            {
                case "rBtnA":
                    if (txtA.Text == dogruCevap)
                    {
                        MessageBox.Show("Doğru");
                        dogruSayisi += 1;
                        dogruYapilanSorular += soru[0] + ",";
                    }
                    else
                    {
                        MessageBox.Show("Yanlış");
                        yanlisSayisi += 1;
                        yanlisYapilanSorular += soru[0] + ",";
                    }
                    break;
                case "rBtnB":
                    if (txtB.Text == dogruCevap)
                    {
                        MessageBox.Show("Doğru");
                        dogruSayisi += 1;
                        dogruYapilanSorular += soru[0] + ",";
                    }
                    else
                    {
                        MessageBox.Show("Yanlış");
                        yanlisSayisi += 1;
                        yanlisYapilanSorular += soru[0] + ",";
                    }
                    break;
                case "rBtnC":
                    if (txtC.Text == dogruCevap)
                    {
                        MessageBox.Show("Doğru");
                        dogruSayisi += 1;
                        dogruYapilanSorular += soru[0] + ",";
                    }
                    else
                    {
                        MessageBox.Show("Yanlış");
                        yanlisSayisi += 1;
                        yanlisYapilanSorular += soru[0] + ",";
                    }
                    break;
                case "rBtnD":
                    if (txtD.Text == dogruCevap)
                    {
                        MessageBox.Show("Doğru");
                        dogruSayisi += 1;
                        dogruYapilanSorular += soru[0] + ",";
                    }
                    else
                    {
                        MessageBox.Show("Yanlış");
                        yanlisSayisi += 1;
                        yanlisYapilanSorular += soru[0] + ",";
                    }
                    break;
            }
        }
        private void secenekOlustur(string[] soru)
        {
            rTxtSoruMetin.Text = soru[1]; // Soru Metni
            var textBoxes = (btnYeniSoru as Button).Parent.Controls.OfType<TextBox>().OrderBy(_ => Guid.NewGuid()).ToArray(); // Cevapları RASTGELE Çekme

            for (int i = 2; i < 6; i++) // Şıklara cevapları dağıtma
            {
                var textbox = textBoxes[i - 2];
                textbox.Text = soru[i];
            }
        }
        private void sonucYazdirma(int okulNo, int soruSayisi, int dogruSayisi, int yanlisSayisi, string dogruYapilanSorular, string yanlisYapilanSorular)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("Insert Into sinavSonuclari (okulNo, soruSayisi, dogruSayisi, yanlisSayisi, dogruYapilanSorular, yanlisYapilanSorular) " +
                                            "values (@okulNo, @soruSayisi, @dogruSayisi, @yanlisSayisi, @dogruYapilanSorular, @yanlisYapilanSorular)", con);
            con.Open();
            cmd.Parameters.AddWithValue("okulNo", okulNo);
            cmd.Parameters.AddWithValue("soruSayisi", soruSayisi);
            cmd.Parameters.AddWithValue("dogruSayisi", dogruSayisi);
            cmd.Parameters.AddWithValue("yanlisSayisi", yanlisSayisi);
            cmd.Parameters.AddWithValue("dogruYapilanSorular", dogruYapilanSorular);
            cmd.Parameters.AddWithValue("yanlisYapilanSorular", yanlisYapilanSorular);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doğru yapılan soru sayısı: " + dogruSayisi.ToString() + "\nYanlış yapılan soru sayısı: " + yanlisSayisi.ToString() + "\nDoğru yapılan sorular: " + dogruYapilanSorular + "\nYanlış yapılan sorular: " + yanlisYapilanSorular, "Sonuç Raporu");
        }
        private void Temizle()
        {
            (btnYeniSoru as Button).Parent.Controls.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.Checked = false);
        }
        private void btnYeniSoru_Click(object sender, EventArgs e)
        {
            soruSayisi++;
            cevapKontrol(soru[2]);
            if (soruSayisi >= ToplamSoruSayisi)
            {
                sonucYazdirma(okulNO, soruSayisi, dogruSayisi, yanlisSayisi, dogruYapilanSorular, yanlisYapilanSorular);
                MessageBox.Show("Sınav Bitti");
                this.Close();
                return;
            }
            soruID = soruIDler[soruSayisi];
            soru = SoruGetir(Convert.ToInt32(soruID));
            secenekOlustur(soru);
            LabelGuncelle(labelDurum);
            Temizle();
        }
        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            if (sinavSuresi > 0)
            {
                sinavSuresi--;
                lblZaman.Text = $"Kalan Süre: {sinavSuresi} Dakika";
            }
            else
            {
                zamanlayici.Stop();
                MessageBox.Show("Süre Doldu");
                sonucYazdirma(okulNO, soruSayisi, dogruSayisi, yanlisSayisi, dogruYapilanSorular, yanlisYapilanSorular);
                this.Close();
                return;
            }
        }
    }
}
