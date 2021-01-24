using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridviewKullanimi
{
    public partial class KategoriIslemleri : Form
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        private int guncellenecekID;
    
        public KategoriIslemleri()
        {
            InitializeComponent();
        }
        private void KategoriIslemleri_Load(object sender, EventArgs e)
        {
            GirdDoldur();
            dataGridView1.Columns[0].Width = 300;
        }
        private void tb_isim_TextChanged(object sender, EventArgs e)
        {
            btn_Ekle.Enabled = tb_isim.Text.Length > 3;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Categories c = new Categories() { CategoryName = tb_isim.Text, Description = tb_aciklama.Text };
            db.Categories.Add(c);
            db.SaveChanges();
            GirdDoldur();
        }
        private void GirdDoldur()
        {
                var kategoriler = from k in db.Categories
                                  //orderby k.CategoryName
                                  select new
                                  {
                                      KategoriNo = k.CategoryID,
                                      KategoriAdi = k.CategoryName,
                                      Açıklama = k.Description
                                  };
                dataGridView1.DataSource = kategoriler.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            //int id = Convert.ToInt32(dataGridView1.Rows[secilenSatir].Cells[0].Value);

            //Categories c = db.Categories.First(s => s.CategoryID == id);
            //tb_isim.Text = c.CategoryName;
            //tb_aciklama.Text = c.Description;
        }

        private void kategoriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[secilenSatir].Cells[0].Value);
            Categories c = db.Categories.First(s => s.CategoryID == id);
            DialogResult dr = MessageBox.Show(id + " numaralı " + c.CategoryName + " isimli kategori silinsin mi?", "Kategori Sil", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                db.Categories.Remove(c);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Kategori silme işlemi iptal edildi");
            }

            GirdDoldur();
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[1];
                //this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void kategoriGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[secilenSatir].Cells[0].Value);

            Categories c = db.Categories.First(s => s.CategoryID == id);
            tb_isim.Text = c.CategoryName;
            tb_aciklama.Text = c.Description;
            btn_guncelle.Visible = true;
            guncellenecekID = id;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (guncellenecekID > 0)
            {
               try
                {
                    Categories c = db.Categories.First(s => s.CategoryID == guncellenecekID);
                    c.CategoryName = tb_isim.Text;
                    c.Description = tb_aciklama.Text;
                    db.SaveChanges();
                    GirdDoldur();
                    tb_isim.Text = tb_aciklama.Text = "";
                    btn_guncelle.Visible = false;
                    MessageBox.Show("kategori Başarıyla Güncellenmiştir");
                }
                catch
                {
                    MessageBox.Show("Hata");
                }
            }
        }
    }
}
