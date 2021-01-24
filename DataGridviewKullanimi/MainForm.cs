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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            GirisYap frm = new GirisYap();
            frm.ShowDialog();
            InitializeComponent();
            toolStripStatusLabel1.Text ="Kullanıcı = " +  Helpers.Kullanici;
        }

        private void ekleListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.FormAc(this, new KategoriIslemleri());
        }

       
    }
}
