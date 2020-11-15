using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else textBox1.Text = '-' + textBox1.Text;
           }
        }

        double a = 0, b = 0, c = 0;
        char znak = '+';

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox1.Text);
            d = Math.Tan(f);
            textBox1.Text = Convert.ToString(d);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox1.Text);
            d = Math.Sqrt(f);
            textBox1.Text = Convert.ToString(d);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox1.Text);
            d = Math.Cos(f);
            textBox1.Text = Convert.ToString(d);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox1.Text);
            d = Math.Sin(f);
            textBox1.Text = Convert.ToString(d);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox1.Text);
            d = f*f;
            textBox1.Text = Convert.ToString(d);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox1.Text);
            d = f*f*f;
            textBox1.Text = Convert.ToString(d);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double f, d;


        private void button13_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+': 
                    c = a + b;
                    break;
                case '-': 
                    c = a - b;
                    break;
                case '/':
                    c = a / b;
                    if (b==0)
                    {
                        MessageBox.Show("Tou cannot divide on zirrow!");
                        textBox1.Text = "Error";
                    }
                    break;
                case 'X':
                    c = a * b;
                    break;
            }
            textBox1.Text = c.ToString();
        }
    }
}
