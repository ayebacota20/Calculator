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
    public partial class discriminant : Form
    {
        public discriminant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                textBox4.Text = "У уравнения 2 корня: " +x1+ " и " +x2+ ".";
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                textBox4.Text = "У уравнения 1 корень: " + x + ".";
            }
            else if (D < 0)
            {
                textBox4.Text = "Нет корней";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
            sinandcos form4 = new sinandcos(); 
            form4.Show();   
        }
    }
}
