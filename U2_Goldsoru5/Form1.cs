using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Goldsoru5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int deger, deger2;
                deger = Convert.ToInt32(textBox1.Text);
                deger2 = Convert.ToInt32(textBox2.Text);
                for (int i = deger; i < deger2; i++)
                {
                    if (i %5 == 0)
                    {
                        listBox3.Items.Add(i);
                    }
                    else if (i%3==0)
                    {
                        listBox2.Items.Add(i);
                    }
                     else
                    {
                        listBox1.Items.Add(i);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("lütfen sayıyı giriniz ");

            }

        }
    }
    }

