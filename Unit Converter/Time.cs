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
    public partial class Time : Form
    {
        public Time()
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
                else if (comboBox1.Text == "Year" && comboBox2.Text == "Week")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 52.143;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Year" && comboBox2.Text == "Day")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 365;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Year" && comboBox2.Text == "Hour")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 8760;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Year" && comboBox2.Text == "Minute")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 525600;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Year" && comboBox2.Text == "Second")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 31536000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Week" && comboBox2.Text == "Year")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 52.143;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Week" && comboBox2.Text == "Day")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 7;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Week" && comboBox2.Text == "Hour")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 168;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Week" && comboBox2.Text == "Minute")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 10080;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Week" && comboBox2.Text == "Second")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 604800;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Day" && comboBox2.Text == "Year")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 365;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Day" && comboBox2.Text == "Week")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 7;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Day" && comboBox2.Text == "Hour")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 24;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Day" && comboBox2.Text == "Minute")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1440;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Day" && comboBox2.Text == "Second")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 86400;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Hour" && comboBox2.Text == "Second")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 3600;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Hour" && comboBox2.Text == "Year")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 8760;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Hour" && comboBox2.Text == "Week")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 168;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Hour" && comboBox2.Text == "Day")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 24;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Hour" && comboBox2.Text == "Minute")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 60;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Minute" && comboBox2.Text == "Year")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 525600;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Minute" && comboBox2.Text == "Week")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 10080;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Minute" && comboBox2.Text == "Day")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 1440;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Minute" && comboBox2.Text == "Hour")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 60;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Minute" && comboBox2.Text == "Second")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 60;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Second" && comboBox2.Text == "Year")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 31536000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Second" && comboBox2.Text == "Week")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 604800;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Second" && comboBox2.Text == "Day")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 86400;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Second" && comboBox2.Text == "Hour")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 3600;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Second" && comboBox2.Text == "Minute")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 60;
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
