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
    public partial class Volume : Form
    {
        public Volume()
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
                else if (comboBox1.Text == "M^3" && comboBox2.Text == "Cm^3")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1000000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "M^3" && comboBox2.Text == "Litre")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "M^3" && comboBox2.Text == "Millilitre")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1000000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Cm^3" && comboBox2.Text == "M^3")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 1000000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Cm^3" && comboBox2.Text == "Litre")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 1000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Cm^3" && comboBox2.Text == "Millilitre")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Litre" && comboBox2.Text == "M^3")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 1000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Litre" && comboBox2.Text == "Cm^3")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Litre" && comboBox2.Text == "Millilitre")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Millilitre" && comboBox2.Text == "M^3")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 1000000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Millilitre" && comboBox2.Text == "Cm^3")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Millilitre" && comboBox2.Text == "Litre")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 1000;
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
