using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservation_System
{
    public partial class Form1 : Form
    {
        public static String name;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "manager" && textBox2.Text == "manager")
            {
                this.Hide();
                Manager1 m1 = new Manager1();
                m1.Show();
            }
            else {
                this.Hide();
                name = textBox1.Text;
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
             
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();//Sign up
            f2.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ram = new Random();
            int one = ram.Next(0,255);
            int two = ram.Next(0, 255);
            int three = ram.Next(0, 255);
            int four = ram.Next(0, 255);

            label6.ForeColor = Color.FromArgb(one,two,three,four);
            linkLabel1.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
