using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formKitap kitap = new formKitap();
            kitap.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formOgrenci ogrenci = new formOgrenci();
            ogrenci.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formKitapTur kitaptur = new formKitapTur();
            kitaptur.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            formOdunckitap odunckitap = new formOdunckitap();
            odunckitap.ShowDialog();
        }
    }
}
