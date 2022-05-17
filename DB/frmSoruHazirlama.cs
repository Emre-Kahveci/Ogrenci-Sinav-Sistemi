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
    public partial class frmSoruHazirlama : Form
    {
        public frmSoruHazirlama()
        {
            InitializeComponent();
        }
        byte[] bimageSoru = null;
        string connStr = @"Data Source=.\; Initial Catalog=test; Integrated Security=True";
        private void SoruEkle(string soruMetin, int soruUnite, int soruKonu, string dogruCevap, string yanlisCevap1, string yanlisCevap2, string yanlisCevap3, string resim = null)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("Insert Into Soru (soruMetin, soruUnite, soruKonu, dogruCevap, yanlisCevap1, yanlisCevap2, yanlisCevap3, resim) " +
                                            "values (@soruMetin, @soruUnite, @soruKonu, @dogruCevap, @yanlisCevap1, @yanlisCevap2, @yanlisCevap3, @resim)", con);
            cmd.Parameters.AddWithValue("soruMetin", soruMetin);
            cmd.Parameters.AddWithValue("soruUnite", soruUnite);
            cmd.Parameters.AddWithValue("soruKonu", soruKonu);
            cmd.Parameters.AddWithValue("dogruCevap", dogruCevap);
            cmd.Parameters.AddWithValue("yanlisCevap1", yanlisCevap1);
            cmd.Parameters.AddWithValue("yanlisCevap2", yanlisCevap2);
            cmd.Parameters.AddWithValue("yanlisCevap3", yanlisCevap3);
            if (PBSoru.ImageLocation != null)
            {
                cmd.Parameters.AddWithValue("resim", SqlDbType.Image).Value = bimageSoru;
            }
            else
            {
                SqlParameter imageParameter = new SqlParameter("resim", SqlDbType.Image);
                imageParameter.Value = DBNull.Value;
                cmd.Parameters.Add(imageParameter);
            }
            con.Open();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Soru Eklendi");
        }
        public void btnSoruResimEkle_Click(object sender, EventArgs e)
        {
            PBSoru.ImageLocation = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PBSoru.ImageLocation = ofd.FileName;
                Bitmap bmp = new Bitmap(ofd.FileName);
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                bimageSoru = new byte[fs.Length];
                fs.Read(bimageSoru, 0, Convert.ToInt32(fs.Length));
                fs.Close();
            }
        }
        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((rTxtSoruMetin.Text)) && PBSoru.ImageLocation == null)
            {
                MessageBox.Show("Soru Eklenmedi, Hata Sebebi: Soru açıklaması veya resimin en azından biri kullanılmalı");
                return;
            }

            if (!(rBtnA.Checked || rBtnB.Checked || rBtnC.Checked || rBtnD.Checked)) // Doğru cevap şıkkı işaretleme kontrol
            {
                MessageBox.Show("Soru Eklenmedi, Hata Sebebi: Doğru cevap şıkkı işaretlenmemiş");
                return;
            }

            TextBox[] cevaplar = { txtA, txtB, txtC, txtD };

            foreach (var cevap in cevaplar)
            {
                if (string.IsNullOrEmpty(cevap.Text))
                {
                    MessageBox.Show("Soru Eklenmedi, Hata Sebebi: Cevap şıklarından biri/birçoğu boş");
                    return;
                }
            }

            if ((int)numUnite.Value == 0 || (int)numKonu.Value == 0)
            {
                MessageBox.Show("Soru Eklenmedi, Hata Sebebi: Ünite ve/veya Konu numarası girilmemiş");
                return;
            }

            var checkedRadioButton = (sender as Button).Parent.Controls.OfType<RadioButton>().Where(radioButton => radioButton.Checked).FirstOrDefault();

            switch (checkedRadioButton.Name)
            {
                case "rBtnA":
                    SoruEkle(rTxtSoruMetin.Text, (int)numUnite.Value, (int)numKonu.Value, txtA.Text, txtB.Text, txtC.Text, txtD.Text, PBSoru.ImageLocation);
                    break;
                case "rBtnB":
                    SoruEkle(rTxtSoruMetin.Text, (int)numUnite.Value, (int)numKonu.Value, txtB.Text, txtA.Text, txtC.Text, txtD.Text, PBSoru.ImageLocation);
                    break;
                case "rBtnC":
                    SoruEkle(rTxtSoruMetin.Text, (int)numUnite.Value, (int)numKonu.Value, txtC.Text, txtB.Text, txtA.Text, txtD.Text, PBSoru.ImageLocation);
                    break;
                case "rBtnD":
                    SoruEkle(rTxtSoruMetin.Text, (int)numUnite.Value, (int)numKonu.Value, txtD.Text, txtB.Text, txtC.Text, txtA.Text, PBSoru.ImageLocation);
                    break;
            }
        
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            (sender as Button).Parent.Controls.OfType<TextBox>().ToList().ForEach(textbox => textbox.Clear()); // textboxları temizleme
            rTxtSoruMetin.Clear();
            numKonu.Value = 0;
            numUnite.Value = 0;
            (sender as Button).Parent.Controls.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.Checked = false); // radiobuttonları temizleme
            PBSoru.ImageLocation = null;
        }
    }
}
