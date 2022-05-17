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
    public partial class frmAnalizRaporu : Form
    {
        testEntities testEntities = new testEntities();
        string[] dogruCozulmusSorular;
        string[] yanlisCozulmusSorular;
        int[,] dogruUniteKonu = new int[7,6];
        int[,] yanlisUniteKonu = new int[7, 6];
        int okulNO;
        int i = 0;
        int j = 0;
        Bitmap bmp;
        public frmAnalizRaporu()
        {
            InitializeComponent();
            okulNO = frmGiris.okulNo;
            dogruCozulmusSorularListe();
            YanlisCozulmusSorularListe();
        }

        private void dogruCozulmusSorularListe()
        {
            var soruItem = testEntities.sinavSonuclaris.Where(sinav => sinav.okulNo == okulNO).ToArray();
            List<string> list = new List<string>();
            foreach (var entity in soruItem)
            {
                dogruCozulmusSorular = entity.dogruYapilanSorular.Split(',');
                foreach (string cozus in dogruCozulmusSorular)
                {
                    if (!string.IsNullOrEmpty(cozus))
                        list.Add(cozus);
                }
            }
            dogruCozulmusSorular = list.ToArray();
        }
        private void YanlisCozulmusSorularListe()
        {
            var soruItem = testEntities.sinavSonuclaris.Where(sinav => sinav.okulNo == okulNO).ToArray();
            List<string> list = new List<string>();
            foreach (var entity in soruItem)
            {
                yanlisCozulmusSorular = entity.yanlisYapilanSorular.Split(',');
                foreach (string cozus in yanlisCozulmusSorular)
                {
                    if (!string.IsNullOrEmpty(cozus))
                        list.Add(cozus);
                }
            }
            yanlisCozulmusSorular = list.ToArray();
        }
        public void RaporOlustur()
        {
            foreach (string soruId in dogruCozulmusSorular)
            {
                int intSoruID = Convert.ToInt32(soruId);
                var item = testEntities.Sorus.Where(soru => soru.soruID == intSoruID).SingleOrDefault();
                dogruUniteKonu[item.soruUnite - 1, item.soruKonu - 1] += 1;
            }
            foreach (string soruId in yanlisCozulmusSorular)
            {
                int intSoruID = Convert.ToInt32(soruId);
                var item = testEntities.Sorus.Where(soru => soru.soruID == intSoruID).SingleOrDefault();
                yanlisUniteKonu[item.soruUnite - 1, item.soruKonu - 1] += 1;
            }
        }
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            RaporOlustur();
            var groupBoxes = (btnRaporAl as Button).Parent.Controls.OfType<GroupBox>().ToArray();
            foreach (var groupBox in groupBoxes.Reverse())
            {
                var textBoxes = groupBox.Controls.OfType<TextBox>().ToArray();
                foreach (var textBox in textBoxes.Reverse())
                {
                    textBox.Text = dogruUniteKonu[i, j].ToString() + " / " + yanlisUniteKonu[i, j].ToString() + " Toplam: " + (dogruUniteKonu[i, j]+yanlisUniteKonu[i, j]).ToString();
                    j++;
                }
                j = 0;
                i++;
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void btnCikti_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Width, this.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            pPD.ShowDialog();
        }
    }
}
