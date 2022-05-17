namespace DB
{
    partial class frmSinavHazirlama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSoruID = new System.Windows.Forms.TextBox();
            this.lblSoruID = new System.Windows.Forms.Label();
            this.btnSoruyuGetir = new System.Windows.Forms.Button();
            this.rTxtSoruMetin = new System.Windows.Forms.RichTextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtSinavID = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.PBSoru = new System.Windows.Forms.PictureBox();
            this.btnSoruyuEkle = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblSinavID = new System.Windows.Forms.Label();
            this.btnSinaviOlustur = new System.Windows.Forms.Button();
            this.lblSure = new System.Windows.Forms.Label();
            this.txtSinavSuresi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBSoru)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoruID
            // 
            this.txtSoruID.Location = new System.Drawing.Point(61, 6);
            this.txtSoruID.Name = "txtSoruID";
            this.txtSoruID.Size = new System.Drawing.Size(100, 20);
            this.txtSoruID.TabIndex = 0;
            this.txtSoruID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoruID_KeyPress);
            // 
            // lblSoruID
            // 
            this.lblSoruID.AutoSize = true;
            this.lblSoruID.Location = new System.Drawing.Point(12, 9);
            this.lblSoruID.Name = "lblSoruID";
            this.lblSoruID.Size = new System.Drawing.Size(43, 13);
            this.lblSoruID.TabIndex = 1;
            this.lblSoruID.Text = "Soru ID";
            // 
            // btnSoruyuGetir
            // 
            this.btnSoruyuGetir.Location = new System.Drawing.Point(167, 4);
            this.btnSoruyuGetir.Name = "btnSoruyuGetir";
            this.btnSoruyuGetir.Size = new System.Drawing.Size(75, 23);
            this.btnSoruyuGetir.TabIndex = 2;
            this.btnSoruyuGetir.Text = "Soruyu Getir";
            this.btnSoruyuGetir.UseVisualStyleBackColor = true;
            this.btnSoruyuGetir.Click += new System.EventHandler(this.btnSoruyuGetir_Click);
            // 
            // rTxtSoruMetin
            // 
            this.rTxtSoruMetin.Location = new System.Drawing.Point(248, 6);
            this.rTxtSoruMetin.Name = "rTxtSoruMetin";
            this.rTxtSoruMetin.ReadOnly = true;
            this.rTxtSoruMetin.Size = new System.Drawing.Size(346, 96);
            this.rTxtSoruMetin.TabIndex = 3;
            this.rTxtSoruMetin.Text = "";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(225, 112);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 13);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "A)";
            // 
            // txtSinavID
            // 
            this.txtSinavID.Location = new System.Drawing.Point(61, 187);
            this.txtSinavID.Name = "txtSinavID";
            this.txtSinavID.Size = new System.Drawing.Size(72, 20);
            this.txtSinavID.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(248, 134);
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(346, 20);
            this.txtB.TabIndex = 7;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(225, 138);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 6;
            this.lblB.Text = "B)";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(248, 160);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(346, 20);
            this.txtC.TabIndex = 9;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(225, 164);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(17, 13);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "C)";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(248, 186);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(346, 20);
            this.txtD.TabIndex = 11;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(225, 190);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(18, 13);
            this.lblD.TabIndex = 10;
            this.lblD.Text = "D)";
            // 
            // PBSoru
            // 
            this.PBSoru.Location = new System.Drawing.Point(600, 6);
            this.PBSoru.Name = "PBSoru";
            this.PBSoru.Size = new System.Drawing.Size(321, 200);
            this.PBSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSoru.TabIndex = 12;
            this.PBSoru.TabStop = false;
            // 
            // btnSoruyuEkle
            // 
            this.btnSoruyuEkle.Location = new System.Drawing.Point(167, 33);
            this.btnSoruyuEkle.Name = "btnSoruyuEkle";
            this.btnSoruyuEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSoruyuEkle.TabIndex = 13;
            this.btnSoruyuEkle.Text = "Soruyu Ekle";
            this.btnSoruyuEkle.UseVisualStyleBackColor = true;
            this.btnSoruyuEkle.Click += new System.EventHandler(this.btnSoruyuEkle_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(248, 109);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(346, 20);
            this.txtA.TabIndex = 14;
            // 
            // lblSinavID
            // 
            this.lblSinavID.AutoSize = true;
            this.lblSinavID.Location = new System.Drawing.Point(7, 190);
            this.lblSinavID.Name = "lblSinavID";
            this.lblSinavID.Size = new System.Drawing.Size(48, 13);
            this.lblSinavID.TabIndex = 15;
            this.lblSinavID.Text = "Sınav ID";
            // 
            // btnSinaviOlustur
            // 
            this.btnSinaviOlustur.Location = new System.Drawing.Point(139, 185);
            this.btnSinaviOlustur.Name = "btnSinaviOlustur";
            this.btnSinaviOlustur.Size = new System.Drawing.Size(80, 23);
            this.btnSinaviOlustur.TabIndex = 16;
            this.btnSinaviOlustur.Text = "Sınavı Oluştur";
            this.btnSinaviOlustur.UseVisualStyleBackColor = true;
            this.btnSinaviOlustur.Click += new System.EventHandler(this.btnSinaviOlustur_Click);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(7, 164);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(66, 13);
            this.lblSure.TabIndex = 17;
            this.lblSure.Text = "Sınav Süresi";
            // 
            // txtSinavSuresi
            // 
            this.txtSinavSuresi.Location = new System.Drawing.Point(79, 161);
            this.txtSinavSuresi.Name = "txtSinavSuresi";
            this.txtSinavSuresi.Size = new System.Drawing.Size(53, 20);
            this.txtSinavSuresi.TabIndex = 18;
            this.txtSinavSuresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSinavSuresi_KeyPress);
            // 
            // frmSinavHazirlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 217);
            this.Controls.Add(this.txtSinavSuresi);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.btnSinaviOlustur);
            this.Controls.Add(this.lblSinavID);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnSoruyuEkle);
            this.Controls.Add(this.PBSoru);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtSinavID);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.rTxtSoruMetin);
            this.Controls.Add(this.btnSoruyuGetir);
            this.Controls.Add(this.lblSoruID);
            this.Controls.Add(this.txtSoruID);
            this.Name = "frmSinavHazirlama";
            this.Text = "frmSinavHazirlama";
            ((System.ComponentModel.ISupportInitialize)(this.PBSoru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoruID;
        private System.Windows.Forms.Label lblSoruID;
        private System.Windows.Forms.Button btnSoruyuGetir;
        private System.Windows.Forms.RichTextBox rTxtSoruMetin;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtSinavID;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.PictureBox PBSoru;
        private System.Windows.Forms.Button btnSoruyuEkle;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblSinavID;
        private System.Windows.Forms.Button btnSinaviOlustur;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.TextBox txtSinavSuresi;
    }
}