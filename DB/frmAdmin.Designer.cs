namespace DB
{
    partial class frmAdmin
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
            this.btnSoruHazirlama = new System.Windows.Forms.Button();
            this.rTxtGecmisSinavlar = new System.Windows.Forms.RichTextBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.btnGecmisSinavlar = new System.Windows.Forms.Button();
            this.btnSinavHazirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoruHazirlama
            // 
            this.btnSoruHazirlama.Location = new System.Drawing.Point(6, 12);
            this.btnSoruHazirlama.Name = "btnSoruHazirlama";
            this.btnSoruHazirlama.Size = new System.Drawing.Size(84, 36);
            this.btnSoruHazirlama.TabIndex = 0;
            this.btnSoruHazirlama.Text = "Soru Hazırla";
            this.btnSoruHazirlama.UseVisualStyleBackColor = true;
            this.btnSoruHazirlama.Click += new System.EventHandler(this.btnSoruHazirlama_Click);
            // 
            // rTxtGecmisSinavlar
            // 
            this.rTxtGecmisSinavlar.Location = new System.Drawing.Point(191, 12);
            this.rTxtGecmisSinavlar.Name = "rTxtGecmisSinavlar";
            this.rTxtGecmisSinavlar.ReadOnly = true;
            this.rTxtGecmisSinavlar.Size = new System.Drawing.Size(292, 191);
            this.rTxtGecmisSinavlar.TabIndex = 1;
            this.rTxtGecmisSinavlar.Text = "";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(6, 54);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(173, 20);
            this.txtOgrenciNo.TabIndex = 2;
            this.txtOgrenciNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrenciNo_KeyPress);
            // 
            // btnGecmisSinavlar
            // 
            this.btnGecmisSinavlar.Location = new System.Drawing.Point(6, 80);
            this.btnGecmisSinavlar.Name = "btnGecmisSinavlar";
            this.btnGecmisSinavlar.Size = new System.Drawing.Size(173, 36);
            this.btnGecmisSinavlar.TabIndex = 3;
            this.btnGecmisSinavlar.Text = "Geçmiş Sınavlar";
            this.btnGecmisSinavlar.UseVisualStyleBackColor = true;
            this.btnGecmisSinavlar.Click += new System.EventHandler(this.btnGecmisSinavlar_Click);
            // 
            // btnSinavHazirla
            // 
            this.btnSinavHazirla.Location = new System.Drawing.Point(95, 12);
            this.btnSinavHazirla.Name = "btnSinavHazirla";
            this.btnSinavHazirla.Size = new System.Drawing.Size(84, 36);
            this.btnSinavHazirla.TabIndex = 4;
            this.btnSinavHazirla.Text = "Sinav Hazırla";
            this.btnSinavHazirla.UseVisualStyleBackColor = true;
            this.btnSinavHazirla.Click += new System.EventHandler(this.btnSinavHazirla_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 124);
            this.Controls.Add(this.btnSinavHazirla);
            this.Controls.Add(this.btnGecmisSinavlar);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.rTxtGecmisSinavlar);
            this.Controls.Add(this.btnSoruHazirlama);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoruHazirlama;
        private System.Windows.Forms.RichTextBox rTxtGecmisSinavlar;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Button btnGecmisSinavlar;
        private System.Windows.Forms.Button btnSinavHazirla;
    }
}