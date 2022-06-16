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

            if (label1.Left < 0||label1.Left>=ClientSize.Width)
            {
                x = -x*2;

                if (label1.Text == "→")
                {
                    label1.Text = ("←");
                }
                else if (label1.Text == "←")
                {
                    label1.Text = ("→");
                }
                if (y > 10) { x = 5; }
            }

            if (label1.Top < 0 || label1.Top >= ClientSize.Height)
            {
                    y = -y * 2;
                if (label1.Text == "↑")
                {
                    label1.Text = ("↓");
                }
                else if (label1.Text == "↓")
                {
                    label1.Text = ("↑");
                }
                if(y>10){ y = 5; }
            }

            //string t = label1, Text;
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

        private void button5_Click(object sender, EventArgs e)
        {
            x = -x;
            if (x < 0)
            {
                label1.Text = ("←");
            }else if (x == 0){

            }
            else
            {
                label1.Text = ("→");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            y = -y;
            if (y < 0)
            {
                label1.Text = ("↑");
            }
            else if (y == 0)
            {

            }
            else
            {
                label1.Text = ("↓");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("幅" + ClientSize.Width);
            MessageBox.Show("高さ" + ClientSize.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            y = -5;
            x = 0;
            label1.Text = ("↑");
        }
    }
}

















//僕のvi君なんかずっと動作不安定なんだけどーーーーーーーーーーー！！！！！！（言い訳）