using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorv2
{
    public partial class Form1 : Form
    {
        double angka1 = 0;
        double angka2 = 0;
        string operasi = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = tombol.Text;
            }
            else
            {
                textBox1.Text += tombol.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = tombol.Text;
            }
            else
            {
                textBox1.Text += tombol.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = tombol.Text;
            }
            else
            {
                textBox1.Text += tombol.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = tombol.Text;
            }
            else
            {
                textBox1.Text += tombol.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = tombol.Text;
            }
            else
            {
                textBox1.Text += tombol.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = tombol.Text;
            }
            else
            {
                textBox1.Text += tombol.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = tombol.Text;
            }
            else
            {
                textBox1.Text += tombol.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = tombol.Text;
            }
            else
            {
                textBox1.Text += tombol.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = tombol.Text;
            }
            else
            {
                textBox1.Text += tombol.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = tombol.Text;
            }
            else
            {
                textBox1.Text += tombol.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            angka1 = Convert.ToDouble(textBox1.Text);
            operasi = tombol.Text;
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            angka1 = Convert.ToDouble(textBox1.Text);
            operasi = tombol.Text;
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            angka1 = Convert.ToDouble(textBox1.Text);
            operasi = tombol.Text;
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            angka1 = Convert.ToDouble(textBox1.Text);
            operasi = tombol.Text;
            textBox1.Text = "0";
        }

        private void hasil_Click(object sender, EventArgs e)
        {

            angka2 = Convert.ToDouble(textBox1.Text);
            double hasil = 0;

            if (operasi == "+")
                hasil = angka1 + angka2;
            else if (operasi == "-")
                hasil = angka1 - angka2;
            else if (operasi == "*")
                hasil = angka1 * angka2;
            else if (operasi == "/")
            {
                if (angka2 == 0)
                {
                    MessageBox.Show("Tidak bisa dibagi 0");
                    return;
                }
                hasil = angka1 / angka2;
            }

            textBox1.Text = hasil.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            angka1 = 0;
            angka2 = 0;
            operasi = "";
        }
    }
}
