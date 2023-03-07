using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler = new string[5];
        int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length ; i++)
            {
                listBox1.Items.Add(isimler[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isimler[index] = textBox1.Text;
            index++;
        }
    }
}
