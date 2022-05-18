namespace DB
{
    partial class frmSinavSorumlusu
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
            this.btnSinavHazirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSinavHazirla
            // 
            this.btnSinavHazirla.Location = new System.Drawing.Point(188, 12);
            this.btnSinavHazirla.Name = "btnSinavHazirla";
            this.btnSinavHazirla.Size = new System.Drawing.Size(84, 36);
            this.btnSinavHazirla.TabIndex = 0;
            this.btnSinavHazirla.Text = "Sınav Hazırla";
            this.btnSinavHazirla.UseVisualStyleBackColor = true;
            this.btnSinavHazirla.Click += new System.EventHandler(this.btnSinavHazirla_Click);
            // 
            // frmSinavSorumlusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.btnSinavHazirla);
            this.Name = "frmSinavSorumlusu";
            this.Text = "Sınav Sorumlusu Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinavHazirla;
    }
}