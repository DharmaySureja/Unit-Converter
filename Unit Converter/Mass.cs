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
    public partial class Mass : Form
    {
        public Mass()
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
                else if (comboBox1.Text == "Gram" && comboBox2.Text == "Kilogram")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 1000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Gram" && comboBox2.Text == "Tonne")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 1000000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Kilogram" && comboBox2.Text == "Gram")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Kilogram" && comboBox2.Text == "Tonne")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 / 1000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Tonne" && comboBox2.Text == "Gram")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1000000;
                    textBox2.Text = ans.ToString();
                }
                else if (comboBox1.Text == "Tonne" && comboBox2.Text == "Kilogram")
                {
                    double c1 = Convert.ToDouble(textBox1.Text);
                    double ans = c1 * 1000;
                    textBox2.Text = ans.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Values First");
            }
        }
    }
}
