namespace DB
{
    partial class frmKullaniciKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.grpBilgi = new System.Windows.Forms.GroupBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cmbuserType = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.grpBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(130, 19);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(190, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(130, 43);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(190, 20);
            this.txtMail.TabIndex = 2;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(2, 43);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(122, 24);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "E-mail Adresi";
            // 
            // grpBilgi
            // 
            this.grpBilgi.Controls.Add(this.txtNumara);
            this.grpBilgi.Controls.Add(this.lblNumara);
            this.grpBilgi.Controls.Add(this.lblKullaniciAdi);
            this.grpBilgi.Controls.Add(this.lblUserType);
            this.grpBilgi.Controls.Add(this.cmbuserType);
            this.grpBilgi.Controls.Add(this.txtSoyad);
            this.grpBilgi.Controls.Add(this.lblSoyad);
            this.grpBilgi.Controls.Add(this.txtAd);
            this.grpBilgi.Controls.Add(this.lblAd);
            this.grpBilgi.Controls.Add(this.txtPassword);
            this.grpBilgi.Controls.Add(this.lblPassword);
            this.grpBilgi.Controls.Add(this.btnKayit);
            this.grpBilgi.Controls.Add(this.txtMail);
            this.grpBilgi.Controls.Add(this.txtKullaniciAdi);
            this.grpBilgi.Controls.Add(this.lblMail);
            this.grpBilgi.Location = new System.Drawing.Point(12, 22);
            this.grpBilgi.Name = "grpBilgi";
            this.grpBilgi.Size = new System.Drawing.Size(328, 246);
            this.grpBilgi.TabIndex = 4;
            this.grpBilgi.TabStop = false;
            this.grpBilgi.Text = "Kullanıcı Kayıt";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(130, 139);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(190, 20);
            this.txtNumara.TabIndex = 6;
            this.txtNumara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumara_KeyPress);
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumara.Location = new System.Drawing.Point(45, 139);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(79, 24);
            this.lblNumara.TabIndex = 14;
            this.lblNumara.Text = "Okul No";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(16, 19);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(108, 24);
            this.lblKullaniciAdi.TabIndex = 13;
            this.lblKullaniciAdi.Text = "KullaniciAdi";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserType.Location = new System.Drawing.Point(32, 163);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(92, 24);
            this.lblUserType.TabIndex = 12;
            this.lblUserType.Text = "UserType";
            // 
            // cmbuserType
            // 
            this.cmbuserType.FormattingEnabled = true;
            this.cmbuserType.Items.AddRange(new object[] {
            "Admin",
            "Sınav Sorumlusu",
            "Öğrenci"});
            this.cmbuserType.Location = new System.Drawing.Point(130, 163);
            this.cmbuserType.Name = "cmbuserType";
            this.cmbuserType.Size = new System.Drawing.Size(190, 21);
            this.cmbuserType.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(130, 115);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(190, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(61, 115);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(63, 24);
            this.lblSoyad.TabIndex = 9;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(130, 91);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(190, 20);
            this.txtAd.TabIndex = 4;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(90, 91);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(34, 24);
            this.lblAd.TabIndex = 7;
            this.lblAd.Text = "Ad";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(190, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(32, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 24);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(228, 211);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(93, 26);
            this.btnKayit.TabIndex = 9;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // frmKullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 281);
            this.Controls.Add(this.grpBilgi);
            this.Name = "frmKullaniciKayit";
            this.Text = "Kullanıcı Kayıt Ekranı";
            this.grpBilgi.ResumeLayout(false);
            this.grpBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.GroupBox grpBilgi;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cmbuserType;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label lblNumara;
    }
}

