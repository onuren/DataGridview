namespace DataGridviewKullanimi
{
    partial class GirisYap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_kullanici = new System.Windows.Forms.TextBox();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // tb_kullanici
            // 
            this.tb_kullanici.Location = new System.Drawing.Point(131, 22);
            this.tb_kullanici.Name = "tb_kullanici";
            this.tb_kullanici.Size = new System.Drawing.Size(149, 20);
            this.tb_kullanici.TabIndex = 2;
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(131, 48);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(149, 20);
            this.tb_sifre.TabIndex = 3;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(205, 74);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 119);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.tb_kullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisYap";
            this.Text = "GirisYap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_kullanici;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.Button btn_giris;
    }
}