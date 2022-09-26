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
    public partial class Area : Form
    {
        public Area()
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
                else if (comboBox1.Text == "Metre^2" && comboBox2.Text == "Km^2")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1e-6;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Metre^2" && comboBox2.Text == "Acre")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 0.000247105;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Km^2" && comboBox2.Text == "Metre^2")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1e+6;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Km^2" && comboBox2.Text == "Acre")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 247.105;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Acre" && comboBox2.Text == "Km^2")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 0.00404686;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Acre" && comboBox2.Text == "Metre^2")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 4046.856;
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
