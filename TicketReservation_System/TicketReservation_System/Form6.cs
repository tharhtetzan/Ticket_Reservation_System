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
    public partial class Form6 : Form
    {
        private int b4,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14,b15,b16,b17,b18,b19,b20,b21,b22,b23,b24,b25,b26 = 1;
        private int seat = 0;
        private int price = 0;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }
        
        //Y1 to Y5,Price 2000

        //Y1
        private void button4_Click(object sender, EventArgs e)
        {
            if (b4 == 1) {
                button4.BackColor = Color.Lime;
                if (seat <= 0) {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else {
                    seat = seat - 1;
                    price = price - 2000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b4 = b4 - 1;
            } else if(b4 == 0){
                button4.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 2000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b4 = b4 + 1;
            }
        }

        //Y2
        private void button5_Click(object sender, EventArgs e)
        {
            if (b5 == 1)
            {
                button5.BackColor = Color.Lime;
                if (seat <= 0) {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else {
                    seat = seat - 1;
                    price = price - 2000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b5 = b5 - 1;
            }
            else if (b5 == 0)
            {
                button5.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 2000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b5 = b5 + 1;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        

        //Y3
        private void button6_Click(object sender, EventArgs e)
        {
            if (b6 == 1)
            {
                button6.BackColor = Color.Lime;
                if (seat <= 0) {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else {
                    seat = seat - 1;
                    price = price - 2000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b6 = b6 - 1;

            }
            else if (b6 == 0)
            {
                button6.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 2000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b6 = b6 + 1;
            }
        }

         //Y4
        private void button7_Click(object sender, EventArgs e)
        {
            if (b7 == 1)
            {
                button7.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b7 = b7 - 1;
            }
            else if (b7 == 0)
            {
                button7.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b7 = b7 + 1;
            }
        }

        //Y5
        private void button8_Click(object sender, EventArgs e)
        {
            if (b8 == 1)
            {
                button8.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b8 = b8 - 1;
            }
            else if (b8 == 0)
            {
                button8.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b8 = b8 + 1;
            }
        }

        //B1 to B5,Price=3000 
        //B1
        private void button9_Click(object sender, EventArgs e)
        {
            if (b9 == 1)
            {
                button9.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b9 = b9 - 1;
            }
            else if (b9 == 0)
            {
                button9.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b9 = b9 + 1;
            }
        }

        //B2
        private void button10_Click_1(object sender, EventArgs e)
        {
            if (b10 == 1)
            {
                button10.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b10 = b10 - 1;
            }
            else if (b10 == 0)
            {
                button10.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b10 = b10 + 1;
            }
        }

        //B3
        private void button11_Click_1(object sender, EventArgs e)
        {
            if (b11 == 1)
            {
                button11.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b11 = b11 - 1;
            }
            else if (b11 == 0)
            {
                button11.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b11 = b11 + 1;
            }
        }

        //B4
        private void button12_Click_1(object sender, EventArgs e)
        {
            if (b12 == 1)
            {
                button12.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b12 = b12 - 1;
            }
            else if (b12 == 0)
            {
                button12.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b12 = b12 + 1;
            }
        }

        //B5
        private void button13_Click_1(object sender, EventArgs e)
        {
            if (b13 == 1)
            {
                button13.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b13 = b13 - 1;
            }
            else if (b13 == 0)
            {
                button13.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b13 = b13 + 1;
            }
        }

        //G1 to G5 (b14 to b18), Price = 3500
        //G1
        private void button14_Click(object sender, EventArgs e)
        {
            if (b14 == 1)
            {
                button14.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3500;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b14 = b14 - 1;
            }
            else if (b14 == 0)
            {
                button14.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3500;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b14 = b14 + 1;
            }
        }

        //G2
        private void button15_Click(object sender, EventArgs e)
        {
            if (b15 == 1)
            {
                button15.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3500;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b15 = b15 - 1;
            }
            else if (b15 == 0)
            {
                button15.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3500;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b15 = b15 + 1;
            }
        }

        //G3
        private void button16_Click(object sender, EventArgs e)
        {
            if (b16 == 1)
            {
                button16.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3500;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b16 = b16 - 1;
            }
            else if (b16 == 0)
            {
                button16.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3500;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b16 = b16 + 1;
            }
        }

        //G4
        private void button17_Click(object sender, EventArgs e)
        {
            if (b17 == 1)
            {
                button17.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3500;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b17 = b17 - 1;
            }
            else if (b17 == 0)
            {
                button17.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3500;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b17 = b17 + 1;
            }
        }

        //G5
        private void button18_Click(object sender, EventArgs e)
        {
            if (b18 == 1)
            {
                button18.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3500;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b18 = b18 - 1;
            }
            else if (b18 == 0)
            {
                button18.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3500;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b18 = b18 + 1;
            }
        }

        //R1 to R5 (b19 to b23)
        //R1
        private void button19_Click(object sender, EventArgs e)
        {
            if (b19 == 1)
            {
                button19.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3500;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b19 = b19 - 1;
            }
            else if (b19 == 0)
            {
                button19.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3500;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b19 = b19 + 1;
            }
        }

         //R2
        private void button20_Click(object sender, EventArgs e)
        {
            if (b20 == 1)
            {
                button20.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3500;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b20 = b20 - 1;
            }
            else if (b20 == 0)
            {
                button20.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3500;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b20 = b20 + 1;
            }
        }


        //R3
        private void button21_Click(object sender, EventArgs e)
        {
            if (b21 == 1)
            {
                button21.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3500;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b21 = b21 - 1;
            }
            else if (b21 == 0)
            {
                button21.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3500;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b21 = b21 + 1;
            }
        }

        //R4
        private void button22_Click(object sender, EventArgs e)
        {
            if (b22 == 1)
            {
                button22.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3500;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b22 = b22 - 1;
            }
            else if (b22 == 0)
            {
                button22.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3500;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b22 = b22 + 1;
            }
        }

        //R5
        private void button23_Click(object sender, EventArgs e)
        {
            if (b23 == 1)
            {
                button23.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 3500;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b23 = b23 - 1;
            }
            else if (b23 == 0)
            {
                button23.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 3500;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b23 = b23 + 1;
            }
        }

        //P1 to P3 (b24 to b26),Price = 10000
        private void button24_Click(object sender, EventArgs e)
        {
            if (b24 == 1)
            {
                button24.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 10000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b24 = b24 - 1;
            }
            else if (b24 == 0)
            {
                button24.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 10000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b24 = b24 + 1;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (b25 == 1)
            {
                button25.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 10000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b25 = b25 - 1;
            }
            else if (b25 == 0)
            {
                button25.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 10000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b25 = b25 + 1;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (b26 == 1)
            {
                button26.BackColor = Color.Lime;
                if (seat <= 0)
                {
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                else
                {
                    seat = seat - 1;
                    price = price - 10000;
                    label6.Text = seat.ToString();
                    label7.Text = price.ToString();
                }
                b26 = b26 - 1;
            }
            else if (b26 == 0)
            {
                button26.BackColor = Color.Maroon;
                seat = seat + 1;
                price = price + 10000;
                label6.Text = seat.ToString();
                label7.Text = price.ToString();
                b26 = b26 + 1;
            }
        }

        //reset
        private void button28_Click(object sender, EventArgs e)
        {
            b4 = 0; b5 = 0; b5 = 0; b6 = 0;b8 = 0;
            b9 = 0; b10 = 0; b11 = 0; b12 = 0; b13 = 0;
            b14 = 0; b15 = 0; b16 = 0; b17 = 0; b18 = 0;
            b19 = 0; b20 = 0; b21 = 0; b22 = 0; b23 = 0;
            b24 = 0; b25 = 0; b26 = 0;
            price = 0; seat = 0;
            button4.BackColor = Color.Lime;
            button5.BackColor = Color.Lime;
            button6.BackColor = Color.Lime;
            button7.BackColor = Color.Lime;
            button8.BackColor = Color.Lime;
            button9.BackColor = Color.Lime;
            button10.BackColor = Color.Lime;
            button11.BackColor = Color.Lime;
            button12.BackColor = Color.Lime;
            button13.BackColor = Color.Lime;
            button14.BackColor = Color.Lime;
            button15.BackColor = Color.Lime;
            button16.BackColor = Color.Lime;
            button17.BackColor = Color.Lime;
            button18.BackColor = Color.Lime;
            button19.BackColor = Color.Lime;
            button20.BackColor = Color.Lime;
            button21.BackColor = Color.Lime;
            button22.BackColor = Color.Lime;
            button23.BackColor = Color.Lime;
            button24.BackColor = Color.Lime;
            button25.BackColor = Color.Lime;
            button26.BackColor = Color.Lime;
            label6.Text = seat.ToString();
            label7.Text = price.ToString();
        }
        private void button27_Click(object sender, EventArgs e)
        {
            if (label6.Text == "0" || label7.Text== "0" ) {
                MessageBox.Show("No tickets has been bought");
            }
            else {
                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();
            }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ram = new Random();
            int one = ram.Next(0, 255);
            int two = ram.Next(0, 255);
            int three = ram.Next(0, 255);
            int four = ram.Next(0, 255);

            label3.ForeColor = Color.FromArgb(one, two, three, four);
        }
    }
}
