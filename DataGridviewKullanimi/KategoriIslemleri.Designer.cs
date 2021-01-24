namespace DataGridviewKullanimi
{
    partial class KategoriIslemleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.tb_aciklama = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Kategoriler = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kategoriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Kategoriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.tb_aciklama);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Ekle";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Enabled = false;
            this.btn_Ekle.Location = new System.Drawing.Point(227, 147);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(104, 23);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // tb_aciklama
            // 
            this.tb_aciklama.Location = new System.Drawing.Point(94, 63);
            this.tb_aciklama.Multiline = true;
            this.tb_aciklama.Name = "tb_aciklama";
            this.tb_aciklama.Size = new System.Drawing.Size(237, 78);
            this.tb_aciklama.TabIndex = 3;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(94, 27);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(237, 20);
            this.tb_isim.TabIndex = 2;
            this.tb_isim.TextChanged += new System.EventHandler(this.tb_isim_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // Kategoriler
            // 
            this.Kategoriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Kategoriler.Controls.Add(this.dataGridView1);
            this.Kategoriler.Location = new System.Drawing.Point(14, 213);
            this.Kategoriler.Name = "Kategoriler";
            this.Kategoriler.Size = new System.Drawing.Size(572, 198);
            this.Kategoriler.TabIndex = 1;
            this.Kategoriler.TabStop = false;
            this.Kategoriler.Text = "Kategori Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriSilToolStripMenuItem,
            this.kategoriGuncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // kategoriSilToolStripMenuItem
            // 
            this.kategoriSilToolStripMenuItem.Name = "kategoriSilToolStripMenuItem";
            this.kategoriSilToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kategoriSilToolStripMenuItem.Text = "Kategori Sil";
            this.kategoriSilToolStripMenuItem.Click += new System.EventHandler(this.kategoriSilToolStripMenuItem_Click);
            // 
            // kategoriGuncelleToolStripMenuItem
            // 
            this.kategoriGuncelleToolStripMenuItem.Name = "kategoriGuncelleToolStripMenuItem";
            this.kategoriGuncelleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kategoriGuncelleToolStripMenuItem.Text = "Kategori Güncelle";
            this.kategoriGuncelleToolStripMenuItem.Click += new System.EventHandler(this.kategoriGuncelleToolStripMenuItem_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(227, 147);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(104, 23);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Visible = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // KategoriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 423);
            this.Controls.Add(this.Kategoriler);
            this.Controls.Add(this.groupBox1);
            this.Name = "KategoriIslemleri";
            this.Text = "KategoriIslemleri";
            this.Load += new System.EventHandler(this.KategoriIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Kategoriler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox tb_aciklama;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Kategoriler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriGuncelleToolStripMenuItem;
        private System.Windows.Forms.Button btn_guncelle;
    }
}