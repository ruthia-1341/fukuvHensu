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
            textBox2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += (int.Parse(textBox1.Text));
            label1.Top += (int.Parse(textBox2.Text));
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
            y =+(int.Parse(textBox1.Text));
            textBox2.Text = "0";
            textBox1.Text = "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x =-(int.Parse(textBox2.Text));
            textBox2.Text = "5";
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            y =-(int.Parse(textBox1.Text));
            textBox2.Text = "0";
            textBox1.Text = "-5";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x =+(int.Parse(textBox2.Text));
            textBox2.Text = "-5";
            textBox1.Text = "0";
        }
    }
}
