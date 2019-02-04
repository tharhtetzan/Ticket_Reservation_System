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
    public partial class Form3 : Form
    {
        public String NSmovie;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.ShowDialog();
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ram = new Random();
            int one = ram.Next(0, 255);
            int two = ram.Next(0, 255);
            int three = ram.Next(0, 255);
            int four = ram.Next(0, 255);

            label22.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void Movie3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
            NSmovie = "AVENGERS END GAME";
            Form5 f5 = new Form5(); 
            f5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            NSmovie = "GLASS";
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            NSmovie = "SHAZAM";
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
