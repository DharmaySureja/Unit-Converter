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
    public partial class Length : Form
    {
        public Length()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Length_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.CompareTo(comboBox2.Text) == 0)
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = c1.ToString();
                }
                else if (comboBox1.Text == "Centimeter" && comboBox2.Text == "Meter")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 100;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Centimeter" && comboBox2.Text == "Kilometer")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 100000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Meter" && comboBox2.Text == "Centimeter")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 100;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Meter" && comboBox2.Text == "Kilometer")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 1000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Kilometer" && comboBox2.Text == "Centimeter")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 100000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Kilometer" && comboBox2.Text == "Meter")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1000;
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
