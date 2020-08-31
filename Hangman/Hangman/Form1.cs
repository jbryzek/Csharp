using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        const int MAX = 26;
        const int MAX2 = 6;
        Label[] Labels = new Label[MAX];
        Label[] SolutionLabels = new Label[MAX2];
        Label[] LineLabels = new Label[MAX2];
        private Point p; //location of particular letter
        private Point location; //real location
        bool doDrag = false; //boolean value of dragging
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load the 2x13 array of labels
            int lWidth = lblsample.Width;
            int lHeight = lblsample.Height;
            char tmp = 'A';

            for (int i = 0; i < MAX; i++)
            {
                //properties
                Labels[i] = new Label();
                Labels[i].Left = 60 + i % 13 * lWidth;
                Labels[i].Top = 50 + i / 13 * lHeight;
                Labels[i].Text = tmp.ToString();
                Labels[i].Font = lblsample.Font;
                Labels[i].TextAlign = lblsample.TextAlign;
                Labels[i].BorderStyle = lblsample.BorderStyle;
                Labels[i].Size = lblsample.Size;
                Labels[i].ForeColor = lblsample.ForeColor;
                Labels[i].Name = i.ToString();
                //events
                Labels[i].MouseDown += new System.Windows.Forms.MouseEventHandler(letter_MouseDown);
                Labels[i].MouseMove += new System.Windows.Forms.MouseEventHandler(letter_MouseMove);
                Labels[i].MouseUp += new System.Windows.Forms.MouseEventHandler(letter_MouseUp);
                tmp++;
            }
            this.Controls.AddRange(Labels); //add array in the form

            lWidth = lblsample2.Width;
            lHeight = lblsample2.Height;
            int lineWidth = lblLine.Width;
            int lineHeight = lblLine.Height;
            for (int i = 0; i < MAX2; i++)
            {
                //properties
                SolutionLabels[i] = new Label();
                SolutionLabels[i].Left = 60 + i % 6 * lWidth+i*15;
                SolutionLabels[i].Top = 150 + i / 6 * lHeight;
                SolutionLabels[i].Text = "";
                SolutionLabels[i].Font = lblsample2.Font;
                SolutionLabels[i].TextAlign = lblsample2.TextAlign;
                SolutionLabels[i].BorderStyle = lblsample.BorderStyle;
                SolutionLabels[i].Size = lblsample2.Size;
                SolutionLabels[i].ForeColor = lblsample2.ForeColor;
                SolutionLabels[i].Name = i.ToString();

                LineLabels[i] = new Label();
                LineLabels[i].Left = 65 + i % 6 * lineWidth+ i*30;
                LineLabels[i].Top = 205 + i / 6 * lineWidth;
                LineLabels[i].BackColor = lblLine.BackColor;
                LineLabels[i].Size = lblLine.Size;
            }
            this.Controls.AddRange(SolutionLabels); //add array in the form
            this.Controls.AddRange(LineLabels); //add array in the form
        }

        private void rightLetter(Label letter)
        {
            if (letter.Text == "C")
                SolutionLabels[0].Text = letter.Text;
            else if (letter.Text == "Y")
                SolutionLabels[1].Text = letter.Text;
            else if (letter.Text == "P")
                SolutionLabels[2].Text = letter.Text;
            else if (letter.Text == "R")
                SolutionLabels[3].Text = letter.Text;
            else if (letter.Text == "U")
                SolutionLabels[4].Text = letter.Text;
            else if (letter.Text == "S")
                SolutionLabels[5].Text = letter.Text;
        }

        private void solution()
        {
            int number = 0;
            for(int i = 0; i < MAX2; i++)
            {
                if (SolutionLabels[i].Text != "")
                    number++;
            }
            if (number == 6)
            {
                MessageBox.Show("Bravo - You Win", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i < MAX2; i++)
                {
                    SolutionLabels[i].Text = "";
                }
            }
        }
        private void setLetter(Label letter)
        {
            for(int i = 0; i < 6; i++)
            {
                if (letter.Left > SolutionLabels[i].Left && letter.Right < SolutionLabels[i].Right
                    && letter.Top > SolutionLabels[i].Top && letter.Bottom < SolutionLabels[i].Bottom)
                    rightLetter(letter);
            }
            letter.Location = location;
            letter.ForeColor = Color.Blue;
            solution();
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The word is CYPRUS", "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void letter_MouseDown(object sender, MouseEventArgs e) //allow dragging
        {
            p = e.Location;
            location = ((Label)sender).Location;
            doDrag = true;
            ((Label)sender).ForeColor = Color.Red;
        }

        private void letter_MouseUp(object sender, MouseEventArgs e) //end of dragging
        {
            doDrag = false;
            setLetter((Label)sender);
        }

        private void letter_MouseMove(object sender, MouseEventArgs e) //dragging
        {
            if (doDrag)
            {
                ((Label)sender).Left = ((Label)sender).Left + e.X - p.X;
                ((Label)sender).Top = ((Label)sender).Top + e.Y - p.Y;
            }
        }
    }
}
