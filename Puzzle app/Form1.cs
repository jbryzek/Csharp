using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustynaBryzekUNIC
{
    public partial class Form1 : Form
    {
        const int MAX = 9;
        Label[] Labels = new Label[MAX];
        int numberOfMove;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advanceToolStripMenuItem.Checked = false;
        }

        private void advanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beginnerToolStripMenuItem.Checked = false;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.BackColor;
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Justyna Bryzek", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Solved1()
        {
            for (int i=0;i<8;i++)
            {
                if (!(Labels[i].Text == (i+1).ToString()))
                    return;
            }
            msgboxAppear();
        }

        private void Solved2()
        {
            for(int i = 0; i < 3; i++)
            {
                if (!(Labels[i].Text == (i + 1).ToString()))
                    return;
            }
            if (!(Labels[5].Text == "4"))
                return;
            if (!(Labels[8].Text == "5"))
                return;
            if (!(Labels[7].Text == "6"))
                return;
            if (!(Labels[6].Text == "7"))
                return;
            if (!(Labels[3].Text == "8"))
                return;
            msgboxAppear();
        }

        private void msgboxAppear()
        {
            //if solved -> message box appear
            DialogResult result;
            result = MessageBox.Show("Congratulations - You Win!", "Winning info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                NewGame();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            numberOfMove = 0;
            lblMove.Text = numberOfMove.ToString();
            //random numbers
            Random random = new Random();
            int[] tabtemp = new int[9];
            int temp = 0;
            for (int i = 0; i < 9; i++)
                tabtemp[i] = -1;
            foreach (Label label in Labels)
            {
                int k;
                do
                {
                    k = random.Next(MAX);
                } while (tabtemp.Contains(k));

                tabtemp[temp] = k;
                temp++;
                label.Text = k.ToString();
            }
            //label with zero make as empty label
            foreach(Label a in Labels) 
            {
                if (a.Text == "0")
                    a.Text = "";
            }
        }

        private void Labels_ClickHandler(object sender, EventArgs e)
        {
            if (((Label)sender).Text == "") { return; } //do nothing if u click on empty label
            int index=-1;
            for(int i = 0; i < 9; i++) //finding clicked label
            {
                if (Labels[i] == (Label)sender)
                {
                    index = i;
                }
            }
            neighbourZero(index);
        }

        private void neighbourZero(int index)
        {
            //check if selected label is neighbour to empty label
            int indexZero = -1;
            for (int i = 0; i < 9; i++) //finding where is empty label (zero label)
            {
                if (Labels[i].Text == "")
                {
                    indexZero = i;
                }
            }
            if (index - 3 == indexZero || index + 3 == indexZero)
            {
                swap(index, indexZero);
                numberOfMove++;
            }
            if (index - 1 == indexZero || index+1 == indexZero) //check if buttons aren't on the edgeds
            {
                if (index == 2 && indexZero == 3)
                    return;
                if (index == 5 && indexZero == 6)
                    return;
                if (index == 3 && indexZero == 2)
                    return;
                if (index == 6 && indexZero == 5)
                    return;
                swap(index, indexZero);
                numberOfMove++;
            }
            lblMove.Text = numberOfMove.ToString();
            Solved1(); //check one solution
            Solved2(); //check other solution
        }

        private void swap(int x, int y)
        {
            //swap values of the labels
            string temp = Labels[x].Text;
            Labels[x].Text = Labels[y].Text;
            Labels[y].Text = temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load the 3x3 array of labels
            int lWidth = example.Width;
            int lHeight = example.Width;

            for (int i = 0; i < MAX; i++)
            {
                //properties
                Labels[i] = new Label();
                Labels[i].Left = 50 + i % 3 * lWidth;
                Labels[i].Top = 50 + i / 3 * lHeight;
                Labels[i].Text = "";
                Labels[i].Font = example.Font;
                Labels[i].TextAlign = example.TextAlign;
                Labels[i].BorderStyle = example.BorderStyle;
                Labels[i].Size = example.Size;
                Labels[i].ForeColor = example.ForeColor;
                Labels[i].Name = i.ToString();
                //events
                Labels[i].Click += new System.EventHandler(Labels_ClickHandler);
            }
            this.Controls.AddRange(Labels); //add array in the form
        }
    }
}
