using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_SS_69_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int topla = 0;
            for (int i = 0; i <100; i=i +3)
            {
                topla = topla + i;
                if (topla>= 200)
                {
                    MessageBox.Show("limit aşıldı");
                    MessageBox.Show(topla.ToString());
                    break;
                }
            }
        }
    }
}
