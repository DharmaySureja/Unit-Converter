using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class Speed : Form
    {
        public Speed()
        {
            InitializeComponent();
            MaximizeBox = false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.CompareTo(comboBox2.Text) == 0)
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = c1.ToString();
                }
                else if (comboBox1.Text == "Km/h" && comboBox2.Text == "Mile/h")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 0.62137;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Km/h" && comboBox2.Text == "Metre/s")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 0.277778;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Mile/h" && comboBox2.Text == "Km/h")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1.609344;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Mile/h" && comboBox2.Text == "Metre/s")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 0.44704;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Metre/s" && comboBox2.Text == "Mile/h")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 2.23694;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Metre/s" && comboBox2.Text == "Km/h")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 3.6;
                    textBox2.Text = ans.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Value First");
            }
        }
    }
}
