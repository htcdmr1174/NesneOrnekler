using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Odev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(txtboy.Text);
            int kilo = Convert.ToInt32(txtkilo.Text);

            double oran = kilo / boy;
            
            if (oran < 18.5)
            {
               MessageBox.Show( "zayıf");
            }
            else if (oran < 25)
            {
                MessageBox.Show("orta");
            }
            else if (oran < 30)
            {
                MessageBox.Show("kilolu");
            }
            else
            {
                

            }
        }
    }
}
