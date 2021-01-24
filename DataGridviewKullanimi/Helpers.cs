using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridviewKullanimi
{
    public class Helpers
    {
        public static string Kullanici;
        /// <summary>
        /// Form açma işlemlerinde this anahtar sözcüğü ile MdiParent'a ulaşabiliyorduk
        /// Ancak Form Açma işlemini ayrı bir sınıfta yapmak 
        /// istersek hem parent hemde child için Form nesnelerine ihtiyaç duyarız
        /// </summary>
        /// <param name="MdiParent">Mdi özelliğine sahip ana form</param>
        /// <param name="MdiChild">Mdi içerisinde açılacak child form</param>
        public static void FormAc(Form MdiParent, Form MdiChild)
        {
            if (MdiParent.MdiChildren.Count() == 0)
            {
                MdiChild.MdiParent = MdiParent;
                MdiChild.Show();
            }
            else
            {
                bool varmi = false;
                foreach (Form item in MdiParent.MdiChildren)
                {
                    if (item.GetType() == MdiChild.GetType())
                    {
                        item.Activate();
                        varmi = true;
                    }
                }
                if (varmi == false)
                {
                    MdiChild.MdiParent = MdiParent;
                    MdiChild.Show();
                }
            }
        }
    }
}
