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
    public partial class ManagerYearSale : Form
    {
        int PW;
        bool Hided;
        public ManagerYearSale()
        {
            InitializeComponent();
            Hided = false;
            PW = Spanel.Width;
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
                Spanel.Width = Spanel.Width + 30;
                if (Spanel.Width >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                Spanel.Width = Spanel.Width - 30;
                if (Spanel.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }
    }
}
