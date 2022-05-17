namespace DB
{
    partial class frmOgrenci
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
            this.components = new System.ComponentModel.Container();
            this.btnSoruCozum = new System.Windows.Forms.Button();
            this.txtSoruSayisi = new System.Windows.Forms.TextBox();
            this.rTxtGecmisSinavlar = new System.Windows.Forms.RichTextBox();
            this.lblSoruSayisi = new System.Windows.Forms.Label();
            this.btnGecmisSinavlar = new System.Windows.Forms.Button();
            this.btnAnalizRaporu = new System.Windows.Forms.Button();
            this.cmBoxSinav = new System.Windows.Forms.ComboBox();
            this.sinavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new DB.testDataSet();
            this.lblSinavSec = new System.Windows.Forms.Label();
            this.btnSinavaGir = new System.Windows.Forms.Button();
            this.sinavTableAdapter = new DB.testDataSetTableAdapters.SinavTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sinavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSoruCozum
            // 
            this.btnSoruCozum.Location = new System.Drawing.Point(233, 12);
            this.btnSoruCozum.Name = "btnSoruCozum";
            this.btnSoruCozum.Size = new System.Drawing.Size(72, 20);
            this.btnSoruCozum.TabIndex = 0;
            this.btnSoruCozum.Text = "Soru Çözüm";
            this.btnSoruCozum.UseVisualStyleBackColor = true;
            this.btnSoruCozum.Click += new System.EventHandler(this.btnSoruCozum_Click);
            // 
            // txtSoruSayisi
            // 
            this.txtSoruSayisi.Location = new System.Drawing.Point(155, 12);
            this.txtSoruSayisi.Name = "txtSoruSayisi";
            this.txtSoruSayisi.Size = new System.Drawing.Size(74, 20);
            this.txtSoruSayisi.TabIndex = 1;
            // 
            // rTxtGecmisSinavlar
            // 
            this.rTxtGecmisSinavlar.Location = new System.Drawing.Point(13, 131);
            this.rTxtGecmisSinavlar.Name = "rTxtGecmisSinavlar";
            this.rTxtGecmisSinavlar.ReadOnly = true;
            this.rTxtGecmisSinavlar.Size = new System.Drawing.Size(292, 191);
            this.rTxtGecmisSinavlar.TabIndex = 2;
            this.rTxtGecmisSinavlar.Text = "";
            // 
            // lblSoruSayisi
            // 
            this.lblSoruSayisi.AutoSize = true;
            this.lblSoruSayisi.Location = new System.Drawing.Point(12, 15);
            this.lblSoruSayisi.Name = "lblSoruSayisi";
            this.lblSoruSayisi.Size = new System.Drawing.Size(137, 13);
            this.lblSoruSayisi.TabIndex = 3;
            this.lblSoruSayisi.Text = "Çözmek istediğin soru sayısı";
            // 
            // btnGecmisSinavlar
            // 
            this.btnGecmisSinavlar.Location = new System.Drawing.Point(12, 43);
            this.btnGecmisSinavlar.Name = "btnGecmisSinavlar";
            this.btnGecmisSinavlar.Size = new System.Drawing.Size(142, 38);
            this.btnGecmisSinavlar.TabIndex = 4;
            this.btnGecmisSinavlar.Text = "Geçmiş Sınavlar";
            this.btnGecmisSinavlar.UseVisualStyleBackColor = true;
            this.btnGecmisSinavlar.Click += new System.EventHandler(this.btnGecmisSinavlar_Click);
            // 
            // btnAnalizRaporu
            // 
            this.btnAnalizRaporu.Location = new System.Drawing.Point(160, 43);
            this.btnAnalizRaporu.Name = "btnAnalizRaporu";
            this.btnAnalizRaporu.Size = new System.Drawing.Size(142, 38);
            this.btnAnalizRaporu.TabIndex = 5;
            this.btnAnalizRaporu.Text = "Analiz Raporu";
            this.btnAnalizRaporu.UseVisualStyleBackColor = true;
            this.btnAnalizRaporu.Click += new System.EventHandler(this.btnAnalizRaporu_Click);
            // 
            // cmBoxSinav
            // 
            this.cmBoxSinav.DataSource = this.sinavBindingSource;
            this.cmBoxSinav.DisplayMember = "sinavID";
            this.cmBoxSinav.FormattingEnabled = true;
            this.cmBoxSinav.Location = new System.Drawing.Point(72, 87);
            this.cmBoxSinav.Name = "cmBoxSinav";
            this.cmBoxSinav.Size = new System.Drawing.Size(142, 21);
            this.cmBoxSinav.TabIndex = 6;
            // 
            // sinavBindingSource
            // 
            this.sinavBindingSource.DataMember = "Sinav";
            this.sinavBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSinavSec
            // 
            this.lblSinavSec.AutoSize = true;
            this.lblSinavSec.Location = new System.Drawing.Point(10, 90);
            this.lblSinavSec.Name = "lblSinavSec";
            this.lblSinavSec.Size = new System.Drawing.Size(56, 13);
            this.lblSinavSec.TabIndex = 7;
            this.lblSinavSec.Text = "Sınav Seç";
            // 
            // btnSinavaGir
            // 
            this.btnSinavaGir.Location = new System.Drawing.Point(220, 85);
            this.btnSinavaGir.Name = "btnSinavaGir";
            this.btnSinavaGir.Size = new System.Drawing.Size(82, 23);
            this.btnSinavaGir.TabIndex = 8;
            this.btnSinavaGir.Text = "Sınava Gir";
            this.btnSinavaGir.UseVisualStyleBackColor = true;
            this.btnSinavaGir.Click += new System.EventHandler(this.btnSinavaGir_Click);
            // 
            // sinavTableAdapter
            // 
            this.sinavTableAdapter.ClearBeforeFill = true;
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 334);
            this.Controls.Add(this.btnSinavaGir);
            this.Controls.Add(this.lblSinavSec);
            this.Controls.Add(this.cmBoxSinav);
            this.Controls.Add(this.btnAnalizRaporu);
            this.Controls.Add(this.btnGecmisSinavlar);
            this.Controls.Add(this.lblSoruSayisi);
            this.Controls.Add(this.rTxtGecmisSinavlar);
            this.Controls.Add(this.txtSoruSayisi);
            this.Controls.Add(this.btnSoruCozum);
            this.Name = "frmOgrenci";
            this.Text = "frmOgrenci";
            this.Load += new System.EventHandler(this.frmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoruCozum;
        private System.Windows.Forms.TextBox txtSoruSayisi;
        private System.Windows.Forms.RichTextBox rTxtGecmisSinavlar;
        private System.Windows.Forms.Label lblSoruSayisi;
        private System.Windows.Forms.Button btnGecmisSinavlar;
        private System.Windows.Forms.Button btnAnalizRaporu;
        private System.Windows.Forms.ComboBox cmBoxSinav;
        private System.Windows.Forms.Label lblSinavSec;
        private System.Windows.Forms.Button btnSinavaGir;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource sinavBindingSource;
        private testDataSetTableAdapters.SinavTableAdapter sinavTableAdapter;
    }
}