using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Goldoru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Random random = new Random();
                pictureBox1.Left = pictureBox1.Left + random.Next(1, 20);
                pictureBox2.Left = pictureBox2.Left + random.Next(1, 20);

                Thread.Sleep(50);


            }
        }
    }
}
