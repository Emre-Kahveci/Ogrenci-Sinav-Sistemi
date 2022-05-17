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
    public partial class frmSoruCozum : Form
    {
        private string connStr = @"Data Source=.\; Initial Catalog=test; Integrated Security=True";
        Random rnd = new Random();
        public static int ToplamSoruSayisi { get; set; }
        static int count = 1;
        public string[] soru;
        int okulNO = frmGiris.okulNo;
        static int soruSayisi;
        int dogruSayisi = 0;
        string dogruYapilanSorular = "";
        int yanlisSayisi = 0;
        string yanlisYapilanSorular = "";
        string[] cozulmusSorular;
        int rastgeleSayi;
        List<int> cozulebilirSoruListesi = new List<int>();
        public static testEntities TestEntities { get; set; }
        public frmSoruCozum()
        {
            InitializeComponent();
            TestEntities = new testEntities();
            ToplamSoruSayisi = TestEntities.Sorus.Count();
            cozulebilirSoruListesi = Enumerable.Range(1, ToplamSoruSayisi).ToList();
            soruSayisi = frmOgrenci.coozmekIstenilenSoruSayisi;
            LabelGuncelle(labelDurum);
            cozulmusSorularListe();
            soru = SoruGetir();
            secenekOlustur(soru);
        }
        private static void LabelGuncelle(Label label)
        {
            label.Text = $"({count}/{soruSayisi})";
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
        private void Temizle()
        {
            (btnYeniSoru as Button).Parent.Controls.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.Checked = false);
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
        private void cozulmusSorularListe()
        {
            var soruItem = TestEntities.sinavSonuclaris.Where(sinav => sinav.okulNo == okulNO).ToArray();
            List<string> list = new List<string>();
            foreach (var entity in soruItem)
            {
                cozulmusSorular = entity.dogruYapilanSorular.Split('\u002C');
                foreach (string cozus in cozulmusSorular)
                {
                    if (!string.IsNullOrEmpty(cozus))
                        list.Add(cozus);
                }
            }
            cozulmusSorular = list.ToArray();
            foreach (string cozus in cozulmusSorular)
            {
                cozulebilirSoruListesi.Remove(Convert.ToInt32(cozus));
            }
        }
        public string[] SoruGetir()
        {
            rastgeleSayi = rnd.Next(cozulebilirSoruListesi.Count);

            var item = TestEntities.Sorus.Where(soru => soru.soruID == rastgeleSayi).FirstOrDefault();
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
        private void btnYeniSoru_Click(object sender, EventArgs e)
        {
            cevapKontrol(soru[2]);
            soru = SoruGetir();
            secenekOlustur(soru);
            if (count >= soruSayisi)
            {
                sonucYazdirma(okulNO, soruSayisi, dogruSayisi, yanlisSayisi, dogruYapilanSorular, yanlisYapilanSorular);
                MessageBox.Show("Sınav Bitti");
                this.Close();
                return;
            }
            count += 1;
            LabelGuncelle(labelDurum);
            Temizle();
        }
    }
}