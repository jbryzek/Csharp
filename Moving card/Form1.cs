using System;
using System.Drawing;
using System.Windows.Forms;

namespace Justyna_BryzekUNIC
{
    public partial class Moving_Cards : Form
    {
        private Point p1; //location of cardRed
        private Point p2; //location of cardBlack
        bool doDrag1 = false; //boolean value of dragging cardRed
        bool doDrag2 = false; //boolean value of dragging cardBalck
        public Moving_Cards()
        {
            InitializeComponent();
        }

        private void Moving_Cards_Click(object sender, EventArgs e) //starts the timer
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e) //moving card after clicking at form, according to timer
        {
            if (cardRed.Location.X > cardBlack.Location.X)
                cardRed.Left--;
            else
                cardRed.Left++;

            if (cardRed.Location.Y > cardBlack.Location.Y)
                cardRed.Top--;
            else
                cardRed.Top++;

            if (cardRed.Location.X == cardBlack.Location.X)
            {
                timer1.Enabled = !timer1.Enabled;
                //cardBlack.Visible = false; it depends which card you'd like to see
            }
        }

        private void cardRed_MouseDown(object sender, MouseEventArgs e) //allow dragging
        {
            p1 = e.Location;
            doDrag1 = true;
        }

        private void cardRed_MouseMove(object sender, MouseEventArgs e) //dragging
        {
            if (doDrag1)
            {
                cardRed.Left = cardRed.Left + e.X - p1.X;
                cardRed.Top = cardRed.Top + e.Y - p1.Y;
            }
        }

        private void cardBlack_MouseDown(object sender, MouseEventArgs e) //allow dragging
        {
            p2 = e.Location;
            doDrag2 = true;
        }

        private void cardRed_MouseUp(object sender, MouseEventArgs e) //end of dragging
        {
            doDrag1 = false;
        }

        private void cardBlack_MouseMove(object sender, MouseEventArgs e) //dragging
        {
            if (doDrag2)
            {
                cardBlack.Left = cardBlack.Left + e.X - p2.X;
                cardBlack.Top = cardBlack.Top + e.Y - p2.Y;
            }
        }

        private void cardBlack_MouseUp(object sender, MouseEventArgs e) //end of dragging
        {
            doDrag2 = false;
        }
    }
}
