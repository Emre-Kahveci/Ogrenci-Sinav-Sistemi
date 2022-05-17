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
    public partial class frmSinavHazirlama : Form
    {
        public frmSinavHazirlama()
        {
            InitializeComponent();
            ToplamSoruSayisi = TestEntities.Sorus.Count();
        }
        testEntities TestEntities = new testEntities();
        int soruId;
        public string[] soru;
        string soruIDler = "";
        string sinavID;
        int soruSayisi;
        int ToplamSoruSayisi;
        int sinavSuresi;
        string connStr = @"Data Source=.\; Initial Catalog=test; Integrated Security=True";
        public string[] SoruGetir(int soruId)
        {
            var item = TestEntities.Sorus.Where(soru => soru.soruID == soruId).FirstOrDefault();
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
        private void secenekOlustur(string[] soru)
        {
            rTxtSoruMetin.Text = soru[1]; // Soru Metni
            var textBoxes = (btnSoruyuGetir as Button).Parent.Controls.OfType<TextBox>().ToArray(); // Cevapları RASTGELE Çekme

            for (int i = 2; i < 6; i++) // Şıklara cevapları dağıtma
            {
                var textbox = textBoxes[i - 2];
                textbox.Text = soru[i];
            }
        }
        private void sinavOlustur(string sinavID, string soruIDler, int soruSayisi, int sinavSuresi)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("Insert Into Sinav (sinavID, soruIDler, soruSayisi, sinavSuresi) " +
                                            "values (@sinavID, @soruIDler, @soruSayisi, @sinavSuresi)", con);
            cmd.Parameters.AddWithValue("sinavID", sinavID);
            cmd.Parameters.AddWithValue("soruIDler", soruIDler);
            cmd.Parameters.AddWithValue("soruSayisi", soruSayisi);
            cmd.Parameters.AddWithValue("sinavSuresi", sinavSuresi);
            con.Open();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Sınav Eklendi");
        }
        private void Temizle()
        {
            (btnSinaviOlustur as Button).Parent.Controls.OfType<TextBox>().ToList().ForEach(textbox => textbox.Clear());
            soruIDler = "";
        }
        private void btnSoruyuGetir_Click(object sender, EventArgs e)
        {
            soruId = Convert.ToInt32(txtSoruID.Text);
            if (soruId > ToplamSoruSayisi)
            {
                MessageBox.Show("Soru Bulunamadı");
                return;
            }
            soru = SoruGetir(soruId);
            secenekOlustur(soru);
        }
        private void btnSoruyuEkle_Click(object sender, EventArgs e)
        {
            soruId = Convert.ToInt32(txtSoruID.Text);
            if (soruId > ToplamSoruSayisi)
            {
                MessageBox.Show("Soru Bulunamadı");
                return;
            }
            soruIDler += txtSoruID.Text + ",";
            txtSoruID.Clear();
        }
        private void btnSinaviOlustur_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSinavID.Text))
            {
                MessageBox.Show("SınavID boş bırakılamaz");
                return;
            }
            if (string.IsNullOrEmpty(txtSinavSuresi.Text))
            {
                MessageBox.Show("Sınav Süresi boş bırakılamaz");
                return;
            }
            sinavID = txtSinavID.Text;
            soruSayisi = (soruIDler.Split(',').Length)-1;
            sinavSuresi = Convert.ToInt32(txtSinavSuresi.Text);
            sinavOlustur(sinavID, soruIDler, soruSayisi, sinavSuresi);
            Temizle();
        }
        private void txtSinavSuresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtSoruID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
