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
    public partial class Vouncher : Form
    {
        int PW;
        bool Hided;
        public Vouncher()
        {
            InitializeComponent();
            Hided = false;
            PW = Spanel.Height;
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Vouncher_Load(object sender, EventArgs e)
        {
            DateTime date;
            date = DateTime.Now;
            label14.Text = date.ToString();
            Form1 f1 = new Form1();
            label15.Text = Form1.name;
            timer2.Start();
            timer2.Enabled = true;
            timer1.Start();
            Hided = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Hided) button2.Text = "H\nI\nD\nE";
            else button2.Text = "S\nH\nO\nW";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                Spanel.Height = Spanel.Height + 20;
                if (Spanel.Height >= PW) {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else {
                Spanel.Height = Spanel.Height - 20;
                if (Spanel.Height <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void Spanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random ram = new Random();
            int one = ram.Next(0, 255);
            int two = ram.Next(0, 255);
            int three = ram.Next(0, 255);
            int four = ram.Next(0, 255);

            label3.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
