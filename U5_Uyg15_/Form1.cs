using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg15_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(textBox1, "adınızı giriniz");
            tt.SetToolTip(textBox2,"soy adınızı giriniz");
            tt.SetToolTip(textBox3, "dogum tarihinizi  gg/aa/yyyy şeklinde giriniz");
            tt.SetToolTip(textBox4, "adresinizi giriniz");
            tt.SetToolTip(button1, "kaydetmek için tıklayınız");


        }
    }
}
