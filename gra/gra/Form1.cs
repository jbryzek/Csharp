using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gra
{
    public partial class Form1 : Form
    {
        bool[,] board;
        bool[,] newBoard;
        bool afterStop = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!afterStop)
            {
                alerty();

                int sizeX = Convert.ToInt32(tbX.Text);
                int sizeY = Convert.ToInt32(tbY.Text);

                setInitialState(sizeX, sizeY);
                drawing(sizeX, sizeY, 0);
            }

            afterStop = false;
            timer1.Enabled = !timer1.Enabled;
        }

        private void drawing(int sizeX, int sizeY, int w) //draw board with colured cells
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (w > 0)
                    {
                        if (newBoard[i, j])
                            dgv[i, j].Style.BackColor = Color.Black;
                    }
                    else
                    {
                        if (board[i, j])
                            dgv[i, j].Style.BackColor = Color.Black;
                    }
                }
            }
        }

        private void drawBoard(int sizeX, int sizeY) //draw clean board with setted width, height
        {
            dgv.GridColor = Color.Gray;
            dgv.ColumnCount = sizeX;
            dgv.RowCount = sizeY;

            foreach (DataGridViewColumn c in dgv.Columns)
                c.Width = dgv.Width / dgv.ColumnCount;
            foreach (DataGridViewRow r in dgv.Rows)
                r.Height = dgv.Height / dgv.RowCount;

            for (int r = 0; r < dgv.RowCount; r++)
            {
                for (int c = 0; c < dgv.Columns.Count; c++)
                {
                    dgv[c, r].ReadOnly = true;
                }
            }
            dgv[0, 0].Selected = false;
        }

        private void setInitialState(int sizeX, int sizeY) //only set initial values
        {
            int initialState = cbInitial.SelectedIndex;
            if (initialState == 0)//constant
            {
                board[sizeX / 2, sizeY / 2] = true;
                board[sizeX / 2 + 1, sizeY / 2] = true;
                board[sizeX / 2 - 1, sizeY / 2 - 1] = true;
                board[sizeX / 2 + 2, sizeY / 2 - 1] = true;
                board[sizeX / 2, sizeY / 2 - 2] = true;
                board[sizeX / 2 + 1, sizeY / 2 - 2] = true;
            }
            if (initialState == 1)//glider
            {
                board[sizeX / 2 + 1, sizeY / 2] = true;
                board[sizeX / 2 - 1, sizeY / 2 - 1] = true;
                board[sizeX / 2, sizeY / 2 - 1] = true;
                board[sizeX / 2, sizeY / 2 - 2] = true;
                board[sizeX / 2 + 1, sizeY / 2 - 2] = true;
            }
            if (initialState == 2)//manual definition
            {
                //only by cliking on the board
            }
            if (initialState == 3)//oscillator
            {
                board[sizeX / 2, sizeY / 2] = true;
                board[sizeX / 2, sizeY / 2 + 1] = true;
                board[sizeX / 2, sizeY / 2 - 1] = true;
            }
            if (initialState == 4)//random
            {
                Random rnd = new Random();
                for (int i = 0; i < sizeX; i++)
                {
                    for (int j = 0; j < sizeY; j++)
                    {
                        board[i, j] = Convert.ToBoolean(rnd.Next(2));
                    }
                }
                timer1.Interval = 3000;
                tbInterval.Text = "2000";
            }
        }

        private void ZeroTheBoard(int sizeX, int sizeY, int w)
        {
            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    if (w > 0)
                        newBoard[i, j] = false;
                    else
                        board[i, j] = false;
                }
            }
        }

        private void alerty()
        {
            if (tbX.Text == "")
            {
                MessageBox.Show("You have to write width", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbY.Text == "")
            {
                MessageBox.Show("You have to write height", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbInitial.Text == "")
            {
                MessageBox.Show("You have to choose initial state", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbInterval.Text == "")
            {
                MessageBox.Show("You have to write interval", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv[e.ColumnIndex, e.RowIndex].Style.BackColor != Color.Black)
            {
                dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Black;
                board[e.ColumnIndex, e.RowIndex] = true;

            }
            else
            {
                dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                board[e.ColumnIndex, e.RowIndex] = false;
            }
            dgv[e.ColumnIndex, e.RowIndex].Selected = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int sizeX = Convert.ToInt32(tbX.Text);
            int sizeY = Convert.ToInt32(tbY.Text);
            ZeroTheBoard(sizeX, sizeY, 0);
            ZeroTheBoard(sizeX, sizeY, 1);
            dgv.Rows.Clear();
            drawBoard(sizeX, sizeY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sizeX = Convert.ToInt32(tbX.Text);
            int sizeY = Convert.ToInt32(tbY.Text);
            board = new bool[sizeX, sizeY];
            newBoard = new bool[sizeX, sizeY];
            ZeroTheBoard(sizeX, sizeY, 0);
            drawBoard(sizeX, sizeY);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sizeX = Convert.ToInt32(tbX.Text);
            int sizeY = Convert.ToInt32(tbY.Text);
            ZeroTheBoard(sizeX, sizeY, 1);

            int numberOfNeighbours = 0;

            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (i == 0 && j > 0 && board[sizeX - 1, j - 1])
                        numberOfNeighbours++;
                    if (board[sizeX - 1, j] && i == 0)
                        numberOfNeighbours++;
                    if (i == 0 && j < sizeY - 1 && board[sizeX - 1, j + 1])
                        numberOfNeighbours++;

                    if (board[sizeX - 1, sizeY - 1] && i == 0 && j == 0)
                        numberOfNeighbours++;

                    if (board[i, sizeY - 1] && j == 0)
                        numberOfNeighbours++;
                    if (j == 0 && i < sizeX - 1 && board[i + 1, sizeY - 1])
                        numberOfNeighbours++;
                    if (i > 0 && j == 0 && board[i - 1, sizeY - 1])
                        numberOfNeighbours++;

                    if (i > 0 && j > 0 && board[i - 1, j - 1])
                        numberOfNeighbours++;
                    if (j > 0 && board[i, j - 1])
                        numberOfNeighbours++;
                    if (j > 0 && i < sizeX - 1 && board[i + 1, j - 1])
                        numberOfNeighbours++;
                    if (i > 0 && board[i - 1, j])
                        numberOfNeighbours++;
                    if (i < sizeX - 1 && board[i + 1, j])
                        numberOfNeighbours++;
                    if (i > 0 && j < sizeY - 1 && board[i - 1, j + 1])
                        numberOfNeighbours++;
                    if (j < sizeY - 1 && board[i, j + 1])
                        numberOfNeighbours++;
                    if (i < sizeX - 1 && j < sizeY - 1 && board[i + 1, j + 1])
                        numberOfNeighbours++;

                    if (i == sizeX - 1 && j > 0 && board[0, j - 1])
                        numberOfNeighbours++;
                    if (board[0, j] && i == sizeX - 1)
                        numberOfNeighbours++;
                    if (i == sizeX - 1 && j < sizeY - 1 && board[0, j + 1])
                        numberOfNeighbours++;

                    if (i == sizeX - 1 && j == sizeY - 1 && board[0, 0])
                        numberOfNeighbours++;

                    if (i > 0 && j == sizeY - 1 && board[i - 1, 0])
                        numberOfNeighbours++;
                    if (board[i, 0] && j == sizeY - 1)
                        numberOfNeighbours++;
                    if (i < sizeX - 1 && j == sizeY - 1 && board[i + 1, 0])
                        numberOfNeighbours++;
                    
                    if (board[i, j] && (numberOfNeighbours == 2 || numberOfNeighbours == 3)) //rules
                        newBoard[i, j] = true;
                    if (!board[i, j] && numberOfNeighbours == 3)
                        newBoard[i, j] = true;
                    numberOfNeighbours = 0;
                }
            }
            dgv.Rows.Clear();
            drawBoard(sizeX, sizeY);
            drawing(sizeX, sizeY, 1);
            for (int i = 0; i < sizeX; i++) //assign new table to the old one
            {
                for (int j = 0; j < sizeY; j++)
                {
                    board[i, j] = newBoard[i, j];
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            afterStop = true;
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btnInterval_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(tbInterval.Text);
        }
    }
}
