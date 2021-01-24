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
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (tb_kullanici.Text == "Hede" && tb_sifre.Text == "123")
            {
                Helpers.Kullanici = tb_kullanici.Text;
                this.Close();
            }
        }
    }
}
