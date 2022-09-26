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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Length l=new Length();
            l.Show();           
            l.Location = this.Location;
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program is Developed By Dharmay Sureja");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mass m = new Mass();
            m.Show();
            m.Location = this.Location;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Volume v = new Volume();
            v.Show();
            v.Location = this.Location;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Speed s = new Speed();
            s.Show();
            s.Location = this.Location;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Area a = new Area();
            a.Show();
            a.Location = this.Location;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Temperautre t = new Temperautre();
            t.Show();
            t.Location = this.Location;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Time time = new Time();
            time.Show();
            time.Location = this.Location;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
