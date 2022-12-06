using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Odev_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, ort, enb, enk;
            a = Int16.Parse(textBox1.Text);
            b = Int16.Parse(textBox2.Text);
            c = Int16.Parse(textBox3.Text);
            ort = (a + b + c) / 3;
            enb = 0;
            enk = 0;
            if ((a > b) && (a > c))
            {
                enb = a;
            }
            if ((c > b) && (c > a))
            {
                enb = c;
            }
            if ((c < b) && (b > a))
            {
                enb = b;
            }
            if ((a < b) && (a < b))
            {
                enk = a;
            }
            if ((c > b) && (c < a))
            {
                enk = c;
            }
            if ((c > b) && (b < a))
            {
                enk = b;
            }
            MessageBox.Show(enk , "") ;

        }
    }
}
    

