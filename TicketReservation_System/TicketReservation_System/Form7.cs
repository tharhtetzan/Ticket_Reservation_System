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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 50;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = i;
            i++;
            if (progressBar1.Value == 100) {
                
                timer1.Stop();
                MessageBox.Show("Bought Successful");
                this.Hide();
                Vouncher v = new Vouncher();
                v.ShowDialog();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
