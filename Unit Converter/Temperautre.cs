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
    public partial class Temperautre : Form
    {
        public Temperautre()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

       
        private void Temperautre_Load(object sender, EventArgs e)
        {

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
                else if (comboBox1.Text == "Celsius" && comboBox2.Text == "Kelvin")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 + 273.15;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Celsius" && comboBox2.Text == "Fahrenheit")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = (c1 * 1.8 ) + 32 ;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Celsius")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = (c1 - 32) * 0.5555555555555556;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Kelvin")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = (c1 - 32) * 0.5555555555555556 + 273.15;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Kelvin" && comboBox2.Text == "Celsius")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 - 273.15;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Kelvin" && comboBox2.Text == "Fahrenheit")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = (c1 - 273.15) * 1.8 + 32 ;
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

