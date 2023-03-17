using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        double number_1, number_2, res;
        char oper;
        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

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

        private void button11_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            oper = '+';
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            oper = '-';
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            oper = '*';
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            oper = '/';
            textBox1.Text = "";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            number_2 = Convert.ToDouble(textBox1.Text);
            if (oper == '+')
            {
                res = number_1 + number_2;
            }
            else if (oper == '-')
            {
                res = number_1 - number_2;
            }
            else if (oper == '*')
            {
                res = number_1 * number_2;
            }
            else if (oper == '/')
            {
                res = number_1 / number_2;
            }
            textBox1.Text = res.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Hide();
            discriminant form3 = new discriminant();
            form3.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Hide();
            sinandcos form4 = new sinandcos();
            form4.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        
    }
}
