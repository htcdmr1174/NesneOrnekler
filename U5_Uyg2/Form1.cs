using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "form sınıfı Uygulama 2";
            this.BackColor = Color.Green;
            this.ForeColor = Color.Blue;
            this.Size = new Size(300, 150);

            label1.Text = "adınız";
            label1 .Location = new Point(10, 10);
            label1.Size = new Size(65, 15);
            label1.ForeColor = Color.White;

            textBox1.Location = new Point(75, 10);
            textBox1.Size = new Size(150, 15);
            textBox1.TabIndex = 1;

            button1.Text = "tıkla ";
            button1.Location = new Point(100, 60);
            button1.Size = new Size(100, 30);
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Black;
            button1.TabIndex = 2;

            textBox1.KeyPress += textBox1_KeyPress;
            button1.Click +=button1_Click;

            this.Controls.Add(label1);
            this.Controls.Add(textBox1);
            this.Controls.Add(button1);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba " + textBox1.Text);
        }
    }
}
