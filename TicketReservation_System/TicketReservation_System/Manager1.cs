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
    public partial class Manager1 : Form
    {
        public Manager1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager1 m1 = new Manager1();
            m1.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for theatre1
            if (comboBox1.Text == "9:00") {
                t1seatsold.Text = "21";
                int ss = Convert.ToInt32(t1seatsold.Text);
                int sl = 23 - ss;
                t1seatleft.Text = sl.ToString() ;
                t1totalincome.Text = "80000";
            }
            if (comboBox1.Text == "12:00")
            {
                t1seatsold.Text = "23";
                int ss = Convert.ToInt32(t1seatsold.Text);
                int sl = 23 - ss;
                t1seatleft.Text = sl.ToString();
                t1totalincome.Text = "92000";
            }
            if (comboBox1.Text == "3:00")
            {
                t1seatsold.Text = "22";
                int ss = Convert.ToInt32(t1seatsold.Text);
                int sl = 23 - ss;
                t1seatleft.Text = sl.ToString();
                t1totalincome.Text = "76000";
            }
            if (comboBox1.Text == "5:00")
            {
                t1seatsold.Text = "20";
                int ss = Convert.ToInt32(t1seatsold.Text);
                int sl = 23 - ss;
                t1seatleft.Text = sl.ToString();
                t1totalincome.Text = "70000";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for theatre 2
            if (comboBox2.Text == "9:00")
            {
                t2seatsold.Text = "21";
                int ss = Convert.ToInt32(t2seatsold.Text);
                int sl = 23 - ss;
                t2seatleft.Text = sl.ToString();
                t2totalincome.Text = "80000";
            }
            if (comboBox2.Text == "12:00")
            {
                t2seatsold.Text = "23";
                int ss = Convert.ToInt32(t2seatsold.Text);
                int sl = 23 - ss;
                t2seatleft.Text = sl.ToString();
                t2totalincome.Text = "92000";
            }
            if (comboBox2.Text == "3:00")
            {
                t2seatsold.Text = "22";
                int ss = Convert.ToInt32(t2seatsold.Text);
                int sl = 23 - ss;
                t2seatleft.Text = sl.ToString();
                t2totalincome.Text = "76000";
            }
            if (comboBox2.Text == "5:00")
            {
                t2seatsold.Text = "20";
                int ss = Convert.ToInt32(t2seatsold.Text);
                int sl = 23 - ss;
                t2seatleft.Text = sl.ToString();
                t2totalincome.Text = "70000";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for theatre 3
            if (comboBox3.Text == "9:00")
            {
                t3seatsold.Text = "21";
                int ss = Convert.ToInt32(t3seatsold.Text);
                int sl = 23 - ss;
                t3seatleft.Text = sl.ToString();
                t3totalincome.Text = "80000";
            }
            if (comboBox3.Text == "12:00")
            {
                t3seatsold.Text = "23";
                int ss = Convert.ToInt32(t3seatsold.Text);
                int sl = 23 - ss;
                t3seatleft.Text = sl.ToString();
                t3totalincome.Text = "92000";
            }
            if (comboBox3.Text == "3:00")
            {
                t3seatsold.Text = "22";
                int ss = Convert.ToInt32(t3seatsold.Text);
                int sl = 23 - ss;
                t3seatleft.Text = sl.ToString();
                t3totalincome.Text = "76000";
            }
            if (comboBox3.Text == "5:00")
            {
                t3seatsold.Text = "20";
                int ss = Convert.ToInt32(t3seatsold.Text);
                int sl = 23 - ss;
                t3seatleft.Text = sl.ToString();
                t3totalincome.Text = "70000";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerYearSale ms = new ManagerYearSale();
            ms.ShowDialog();
        }
    }
}
