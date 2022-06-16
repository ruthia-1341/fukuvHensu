using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += x;
            label1.Top += y;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == ("stop"))
            {
                timer1.Enabled = true;
                label1.Text = ("go");
            }
            else
            {
                timer1.Enabled = false;
                label1.Text = ("stop");
            }

            MessageBox.Show("堀 朱莉");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            y = 0;
            x = 5;
            label1.Text = ("→");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            y = 5;
            x = 0;
            label1.Text = ("↓");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            y = 0;
            x = -5;
            label1.Text = ("←");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            y = -5;
            x = 0;
            label1.Text = ("↑");
        }
    }
}
