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
    public partial class sinandcos : Form
    {
        public sinandcos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ugol;
            double sinValue, cosValue;

            if (double.TryParse(textBox1.Text, out ugol))
            {
                sinValue = Math.Sin(ugol * Math.PI / 180.0);
                cosValue = Math.Cos(ugol * Math.PI / 180.0);
            }
            else
            {
                sinValue = double.NaN;
                cosValue = double.NaN;
            }

            textBox2.Text = sinValue.ToString();
            textBox3.Text = cosValue.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            calculator form2 = new calculator();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            discriminant form3 = new discriminant();
            form3.Show();
        }
    }
}
