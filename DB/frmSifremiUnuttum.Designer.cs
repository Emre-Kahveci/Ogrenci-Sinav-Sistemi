namespace DB
{
    partial class frmSifremiUnuttum
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullanciAdi = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(132, 32);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(190, 24);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // lblKullanciAdi
            // 
            this.lblKullanciAdi.AutoSize = true;
            this.lblKullanciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanciAdi.Location = new System.Drawing.Point(12, 32);
            this.lblKullanciAdi.Name = "lblKullanciAdi";
            this.lblKullanciAdi.Size = new System.Drawing.Size(113, 24);
            this.lblKullanciAdi.TabIndex = 1;
            this.lblKullanciAdi.Text = "Kullanıcı Adı";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(7, 62);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(118, 24);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "E-Mail Adres";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(132, 62);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(190, 24);
            this.txtMail.TabIndex = 2;
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(232, 132);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(90, 28);
            this.btnSifremiUnuttum.TabIndex = 4;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = true;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // frmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 172);
            this.Controls.Add(this.btnSifremiUnuttum);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblKullanciAdi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Name = "frmSifremiUnuttum";
            this.Text = "Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblKullanciAdi;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnSifremiUnuttum;
    }
}