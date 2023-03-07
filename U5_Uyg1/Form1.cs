using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Enter tuşu çalışıyo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Esc tuşu çalışıyo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.ControlBox == true)
              this.ControlBox = false;
           else
                this.ControlBox = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
              this.CenterToScreen();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB. Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB.ShowDialog();
        }
    }
}
