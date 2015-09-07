using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMaster
{
    public partial class Form1 : Form
    {
        int sign = 0;
        string numberOne;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sign = 1;
            numberOne = textBox1.Text;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int result;
            if (sign == 1)
            {
               result = Convert.ToInt32(numberOne) + Convert.ToInt32(textBox1.Text);
               textBox1.Text = Convert.ToString(result);
               sign = 0;
            }
            else if (sign == 2)
            {
                result = Convert.ToInt32(numberOne) - Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
                sign = 0;
            }
            else if (sign == 3)
            {
                result = Convert.ToInt32(numberOne) * Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
                sign = 0;
            }
            else if (sign == 4)
            {
                result = Convert.ToInt32(numberOne) / Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
                sign = 0;
            }
            else
            {
                MessageBox.Show("Error. Don`t press the sign");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sign = 2;
            numberOne = textBox1.Text;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sign = 3;
            numberOne = textBox1.Text;
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sign = 4;
            numberOne = textBox1.Text;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sign = 0;
            numberOne = "";
            textBox1.Text = "";
        }
        
    }
}
