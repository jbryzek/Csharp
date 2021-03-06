﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace rozrostCA
{
    public partial class Form1 : Form
    {
        struct Cell
        {
            public bool state { get; set; }
            public Color color { get; set; }
        }
        Cell[,] board;
        Cell[,] newBoard;
        Cell[,] drawingBoard;
        double[,] displacement;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!alerty())
            {
                int sizeX = Convert.ToInt32(tbX.Text);
                int sizeY = Convert.ToInt32(tbY.Text);

                setInitialState(sizeX, sizeY, sender, e);
                drawing(sizeX, sizeY, 0);
                //applyRules(sizeX, sizeY);

                timer1.Enabled = !timer1.Enabled;
            }
        }

        private void rewriteBoard(int sizeX, int sizeY, int w)
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (w == 0)
                        board[i, j] = newBoard[i, j];
                    else
                        newBoard[i, j] = board[i, j];
                }
            }
        }

        private Color findColor(List<Color> listOfDetectedColours)
        {
            int[] counter = new int[listOfDetectedColours.Count];
            for (int j = 0; j < counter.Length; j++)
                counter[j] = 0;
            Color resultColor = listOfDetectedColours.First();
            int i = 0;
            foreach (Color color in listOfDetectedColours)
            {
                foreach (Color tmp in listOfDetectedColours)
                {
                    if (color == tmp)
                        counter[i]++;
                }
                i++;
            }
            int tmpNum = 0;
            for (int j = 0; j < counter.Length; j++)
            {
                if (counter[j] > tmpNum)
                {
                    tmpNum = counter[j];
                    resultColor = listOfDetectedColours[j];
                }
            }
            return resultColor;
        }

        private void drawing(int sizeX, int sizeY, int w) //draw board with colured cells
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (w > 0)
                    {
                        if (newBoard[i, j].state)
                            dgv[i, j].Style.BackColor = newBoard[i, j].color;
                    }
                    else
                    {
                        if (board[i, j].state)
                            dgv[i, j].Style.BackColor = board[i, j].color;
                    }
                }
            }
            Console.WriteLine("rys");
        }

        private bool alerty()
        {
            if (tbX.Text == "" || Convert.ToInt32(tbX.Text) <= 0)
            {
                MessageBox.Show("You have to write width", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (tbY.Text == "" || Convert.ToInt32(tbY.Text) <= 0)
            {
                MessageBox.Show("You have to write height", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cbInitial.Text == "")
            {
                MessageBox.Show("You have to choose initial state", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cbBoundary.Text == "")
            {
                MessageBox.Show("You have to choose boundary condition", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cbRule.Text == "")
            {
                MessageBox.Show("You have to choose rule", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (tbCol.Text == "" || Convert.ToInt32(tbCol.Text) <= 0)
            {
                MessageBox.Show("You have to write a value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (tbRow.Text == "" || Convert.ToInt32(tbRow.Text) <= 0)
            {
                MessageBox.Show("You have to write a value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            int initialState = cbInitial.SelectedIndex;
            int sizeX = Convert.ToInt32(tbX.Text);
            int sizeY = Convert.ToInt32(tbY.Text);
            if (initialState == 0)//jednorodne
            {
                int x = Convert.ToInt32(tbRow.Text);
                int y = Convert.ToInt32(tbCol.Text);
                if (x > sizeX / 2 || y > sizeY / 2)
                {
                    MessageBox.Show("Given quantity is too large", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            if (initialState == 1)
            {
                int radius = Convert.ToInt32(tbRow.Text);
                int count = Convert.ToInt32(tbCol.Text);
                double maxCount = ((sizeX * sizeY) / (Math.PI * radius * radius) + (sizeX * sizeY) / (Math.PI * (radius - 1) * (radius - 1))) / 2;
                if (count > maxCount)
                {
                    MessageBox.Show("Given quantity is too large", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            if (initialState == 2)
            {
                int count = Convert.ToInt32(tbRow.Text);
                if (count > sizeX * sizeY)
                {
                    MessageBox.Show("Given quantity is too large", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }
        List<Color> listColor = new List<Color>();
        private Color randomColor()
        {
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            while (listColor.Contains(Color.FromArgb(r, g, b)))
            {
                r = random.Next(0, 256);
                g = random.Next(0, 256);
                b = random.Next(0, 256);
            }
            listColor.Add(Color.FromArgb(r, g, b));
            return Color.FromArgb(r, g, b);
        }

        private void setInitialState(int sizeX, int sizeY, object sender, EventArgs e) //only set initial values
        {
            int initialState = cbInitial.SelectedIndex;
            if (initialState == 0)//jednorodne
            {
                int x = Convert.ToInt32(tbRow.Text);
                int y = Convert.ToInt32(tbCol.Text);
                int tmpY = y;
                int count = x * y;
                int stepX;
                int stepY;
                if (x == 1) stepX = sizeX / 2;
                else stepX = sizeX / x;
                if (y == 1) stepY = sizeY / 2;
                else stepY = sizeY / y;
                for (int i = stepX - 1; i < sizeX; i += stepX)
                {
                    tmpY = y;
                    for (int j = stepY - 1; j < sizeY; j += stepY)
                    {
                        board[i, j].state = true;
                        board[i, j].color = randomColor();
                        tmpY--;
                        count--;
                        if (tmpY == 0)
                            break;
                    }
                    if (count == 0)
                        break;
                }
            }
            if (initialState == 1)//z promieniem
            {
                int radius = Convert.ToInt32(tbRow.Text);
                int count = Convert.ToInt32(tbCol.Text);
                for (int i = 0; i < count; i++)
                {
                    int x = random.Next(sizeX);
                    int y = random.Next(sizeY);
                    if (board[x, y].color == Color.Empty) // if this cell isn't coloured
                    {
                        if (checkNeigbours(x, y, radius, sizeX, sizeY))
                        {
                            board[x, y].state = true;
                            board[x, y].color = randomColor();
                        }
                        else
                            count++;

                    }
                    else
                        count++;
                }
            }
            if (initialState == 2)//losowe
            {
                int count = Convert.ToInt32(tbRow.Text);
                for (int i = 0; i < count; i++)
                {
                    int x = random.Next(sizeX);
                    int y = random.Next(sizeY);
                    if (board[x, y].color == Color.Empty) // if this cell isn't coloured
                    {
                        board[x, y].state = true;
                        board[x, y].color = randomColor();
                    }
                    else
                        count++;
                }
            }
            if (initialState == 3)//wyklikanie
            {
                //only by cliking on the board
            }
        }

        private bool checkNeigbours(int x, int y, int radius, int sizeX, int sizeY)
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (Math.Sqrt((i - x) * (i - x) + (j - y) * (j - y)) <= radius)
                    {
                        if (board[i, j].color != Color.Empty)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            if (!alerty())
                Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sizeX = Convert.ToInt32(tbX.Text);
            int sizeY = Convert.ToInt32(tbY.Text);
            board = new Cell[sizeX, sizeY];
            newBoard = new Cell[sizeX, sizeY];
            ZeroTheBoard(sizeX, sizeY, 0);
            drawBoard(sizeX, sizeY);
        }

        private void drawBoard(int sizeX, int sizeY) //draw clean board with setted width, height
        {
            dgv.GridColor = Color.Gray;
            dgv.ColumnCount = sizeX;
            dgv.RowCount = sizeY;
            int scale = 0;
            if (sizeX == sizeY)
            {
                foreach (DataGridViewColumn c in dgv.Columns)
                    c.Width = dgv.Width / dgv.ColumnCount;
                foreach (DataGridViewRow r in dgv.Rows)
                    r.Height = dgv.Height / dgv.RowCount;
            }
            if (sizeX > sizeY)
                scale = dgv.Width / sizeX;
            else
                scale = dgv.Height / sizeY;
            if (scale > 0)
            {
                foreach (DataGridViewColumn c in dgv.Columns)
                    c.Width = scale;
                foreach (DataGridViewRow r in dgv.Rows)
                    r.Height = scale;
            }

            for (int r = 0; r < dgv.RowCount; r++)
            {
                for (int c = 0; c < dgv.Columns.Count; c++)
                {
                    dgv[c, r].ReadOnly = true;
                }
            }
            dgv[0, 0].Selected = false;
        }

        private void ZeroTheBoard(int sizeX, int sizeY, int w)
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (w > 0)
                    {
                        newBoard[i, j].state = false;
                        newBoard[i, j].color = Color.Empty;
                    }
                    else
                    {
                        board[i, j].state = false;
                        board[i, j].color = Color.Empty;
                    }
                }
            }
        }

        private void cbInitial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int initialState = cbInitial.SelectedIndex;
            if (initialState == 0)
            {
                lblRow.Text = "w wierszu";
                lblCol.Text = "w kolumnie";
                lblRow.Visible = true;
                lblCol.Visible = true;
                tbCol.Visible = true;
                tbRow.Visible = true;
            }
            if (initialState == 1)
            {
                lblRow.Text = "promien";
                lblCol.Text = "ilosc";
                lblRow.Visible = true;
                lblCol.Visible = true;
                tbCol.Visible = true;
                tbRow.Visible = true;
            }
            if (initialState == 2)
            {
                lblRow.Text = "ilosc";
                lblRow.Visible = true;
                tbRow.Visible = true;
                lblCol.Visible = false;
                tbCol.Visible = false;
            }
            if (initialState == 3)
            {
                lblRow.Visible = false;
                lblCol.Visible = false;
                tbCol.Visible = false;
                tbRow.Visible = false;
            }
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.Empty)
            {
                board[e.ColumnIndex, e.RowIndex].state = true;
                board[e.ColumnIndex, e.RowIndex].color = randomColor();
                dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = board[e.ColumnIndex, e.RowIndex].color;
            }
            else
            {
                dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Empty;
                board[e.ColumnIndex, e.RowIndex].state = false;
            }
            dgv[e.ColumnIndex, e.RowIndex].Selected = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            int sizeX = Convert.ToInt32(tbX.Text);
            int sizeY = Convert.ToInt32(tbY.Text);
            ZeroTheBoard(sizeX, sizeY, 0);
            ZeroTheBoard(sizeX, sizeY, 1);
            dgv.Rows.Clear();
            drawBoard(sizeX, sizeY);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sizeX = Convert.ToInt32(tbX.Text);
            int sizeY = Convert.ToInt32(tbY.Text);
            rewriteBoard(sizeX, sizeY, 1);
            int boundaryRule = cbBoundary.SelectedIndex;
            if (boundaryRule == 0)
                absorbujace(sizeX, sizeY);
            else
                periodyczne(sizeX, sizeY);
            List<Color> listOfDetectedColours = new List<Color>();

            for (int i = 1; i < sizeX + 1; i++)
            {
                for (int j = 1; j < sizeY + 1; j++)
                {
                    if (!drawingBoard[i, j].state) //if this cell state is false
                    {
                        int drawingRule = cbRule.SelectedIndex;
                        if (drawingRule == 0)
                            vonNeumann(listOfDetectedColours, i, j);
                        if (drawingRule == 1)
                            pentagonalneLosowe(listOfDetectedColours, i, j);
                        if (drawingRule == 2)
                            heksagonalne(listOfDetectedColours, i, j);
                        if (drawingRule == 3)
                            moore(listOfDetectedColours, i, j);
                        if (drawingRule == 4)
                            zPromieniem(listOfDetectedColours, i, j, sizeX, sizeY);

                        if (listOfDetectedColours.Count > 0)
                        {
                            newBoard[i - 1, j - 1].state = true;
                            newBoard[i - 1, j - 1].color = findColor(listOfDetectedColours);
                        }
                        listOfDetectedColours.Clear();
                    }
                }
            }
            drawing(sizeX, sizeY, 1);
            rewriteBoard(sizeX, sizeY, 0);
        }

        private void zPromieniem(List<Color> listOfDetectedColours, int x, int y, int sizeX, int sizeY)
        {
            int boundaryRule = cbBoundary.SelectedIndex;
            int radius = Convert.ToInt32(tbRadius.Text);
            int xMax = radius + x;
            int yMax = radius + y;
            int xMin = x - radius;
            int yMin = y - radius;
            if (boundaryRule == 0)
            {
                xMax = radius + x > sizeX + 1 ? sizeX + 1 : radius + x;
                yMax = radius + y > sizeY + 1 ? sizeY + 1 : radius + y;
                xMin = x - radius < 1 ? 1 : x - radius;
                yMin = y - radius < 1 ? 1 : y - radius;
            }


            for (int i = xMin; i < xMax; i++)
            {
                for (int j = yMin; j < yMax; j++)
                {
                    if (i == x && j == y)
                        continue;
                    if (Math.Sqrt(((i + displacement[i - 1, j - 1]) - (x - 0.5)) * ((i + displacement[i - 1, j - 1]) - (x - 0.5))
                        + ((j + displacement[i - 1, j - 1]) - (y - 0.5)) * ((j + displacement[i - 1, j - 1]) - (y - 0.5))) <= radius)
                    {
                        if (drawingBoard[i, j].color != Color.Empty)
                        {
                            listOfDetectedColours.Add(drawingBoard[i, j].color);
                        }
                    }
                }
            }
        }

        private void moore(List<Color> listOfDetectedColours, int i, int j)
        {
            vonNeumann(listOfDetectedColours, i, j);
            if (drawingBoard[i - 1, j - 1].color != Color.Empty)
                listOfDetectedColours.Add(drawingBoard[i - 1, j - 1].color);
            if (drawingBoard[i + 1, j - 1].color != Color.Empty)
                listOfDetectedColours.Add(drawingBoard[i + 1, j - 1].color);
            if (drawingBoard[i + 1, j + 1].color != Color.Empty)
                listOfDetectedColours.Add(drawingBoard[i + 1, j + 1].color);
            if (drawingBoard[i - 1, j + 1].color != Color.Empty)
                listOfDetectedColours.Add(drawingBoard[i - 1, j + 1].color);
        }

        private void heksagonalne(List<Color> listOfDetectedColours, int i, int j)
        {
            vonNeumann(listOfDetectedColours, i, j);
            double whichRnd = random.NextDouble();
            if (whichRnd > 0.5)
            {
                if (drawingBoard[i + 1, j - 1].color != Color.Empty)
                    listOfDetectedColours.Add(drawingBoard[i + 1, j - 1].color);
                if (drawingBoard[i - 1, j + 1].color != Color.Empty)
                    listOfDetectedColours.Add(drawingBoard[i - 1, j + 1].color);
            }
            else
            {
                if (drawingBoard[i - 1, j - 1].color != Color.Empty)
                    listOfDetectedColours.Add(drawingBoard[i - 1, j - 1].color);
                if (drawingBoard[i + 1, j + 1].color != Color.Empty)
                    listOfDetectedColours.Add(drawingBoard[i + 1, j + 1].color);
            }
        }

        private void pentagonalneLosowe(List<Color> listOfDetectedColours, int i, int j)
        {
            int whichRnd = random.Next(4);
            if (whichRnd == 0 || whichRnd == 1)
            {
                if (drawingBoard[i, j + 1].color != Color.Empty)
                    listOfDetectedColours.Add(drawingBoard[i, j + 1].color);
                if (drawingBoard[i, j - 1].color != Color.Empty)
                    listOfDetectedColours.Add(drawingBoard[i, j - 1].color);
                if (whichRnd == 0)
                {
                    if (drawingBoard[i - 1, j - 1].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i - 1, j - 1].color);
                    if (drawingBoard[i - 1, j + 1].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i - 1, j + 1].color);
                    if (drawingBoard[i - 1, j].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i - 1, j].color);
                }
                else
                {
                    if (drawingBoard[i + 1, j - 1].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i + 1, j - 1].color);
                    if (drawingBoard[i + 1, j + 1].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i + 1, j + 1].color);
                    if (drawingBoard[i + 1, j].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i + 1, j].color);
                }
            }
            if (whichRnd == 2 || whichRnd == 3)
            {
                if (drawingBoard[i + 1, j].color != Color.Empty)
                    listOfDetectedColours.Add(drawingBoard[i + 1, j].color);
                if (drawingBoard[i - 1, j].color != Color.Empty)
                    listOfDetectedColours.Add(drawingBoard[i - 1, j].color);
                if (whichRnd == 2)
                {
                    if (drawingBoard[i + 1, j + 1].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i + 1, j + 1].color);
                    if (drawingBoard[i - 1, j + 1].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i - 1, j + 1].color);
                    if (drawingBoard[i, j + 1].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i, j + 1].color);
                }
                else
                {
                    if (drawingBoard[i - 1, j - 1].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i - 1, j - 1].color);
                    if (drawingBoard[i + 1, j - 1].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i + 1, j - 1].color);
                    if (drawingBoard[i, j - 1].color != Color.Empty)
                        listOfDetectedColours.Add(drawingBoard[i, j - 1].color);
                }
            }
        }

        private void vonNeumann(List<Color> listOfDetectedColours, int i, int j)
        {
            if (drawingBoard[i - 1, j].color != Color.Empty)
                listOfDetectedColours.Add(drawingBoard[i - 1, j].color);
            if (drawingBoard[i + 1, j].color != Color.Empty)
                listOfDetectedColours.Add(drawingBoard[i + 1, j].color);
            if (drawingBoard[i, j + 1].color != Color.Empty)
                listOfDetectedColours.Add(drawingBoard[i, j + 1].color);
            if (drawingBoard[i, j - 1].color != Color.Empty)
                listOfDetectedColours.Add(drawingBoard[i, j - 1].color);
        }

        private void periodyczne(int sizeX, int sizeY)
        {
            drawingBoard = new Cell[sizeX + 2, sizeY + 2];
            for (int i = 1; i < sizeX + 1; i++)
            {
                drawingBoard[i, 0].state = board[i - 1, sizeY - 1].state;
                drawingBoard[i, 0].color = board[i - 1, sizeY - 1].color;
            }
            for (int i = 1; i < sizeX + 1; i++)
            {
                drawingBoard[i, sizeY + 1].state = board[i - 1, 0].state;
                drawingBoard[i, sizeY + 1].color = board[i - 1, 0].color;
            }
            for (int i = 1; i < sizeY + 1; i++)
            {
                drawingBoard[0, i].state = board[sizeX - 1, i - 1].state;
                drawingBoard[0, i].color = board[sizeX - 1, i - 1].color;
            }
            for (int i = 1; i < sizeY + 1; i++)
            {
                drawingBoard[sizeX + 1, i].state = board[0, i - 1].state;
                drawingBoard[sizeX + 1, i].color = board[0, i - 1].color;
            }
            for (int i = 1; i < sizeX + 1; i++)
            {
                for (int j = 1; j < sizeY + 1; j++)
                    drawingBoard[i, j] = board[i - 1, j - 1];
            }
            drawingBoard[0, 0] = board[sizeX - 1, sizeY - 1];
            drawingBoard[sizeX + 1, sizeY + 1] = board[0, 0];
            drawingBoard[0, sizeY + 1] = board[sizeX - 1, 0];
            drawingBoard[sizeX + 1, 0] = board[0, sizeY - 1];
        }

        private void absorbujace(int sizeX, int sizeY)
        {
            drawingBoard = new Cell[sizeX + 2, sizeY + 2];
            for (int i = 0; i < sizeX + 2; i++)
            {
                drawingBoard[i, 0].state = false;
                drawingBoard[i, 0].color = Color.Empty;
            }
            for (int i = 0; i < sizeX + 2; i++)
            {
                drawingBoard[i, sizeY + 1].state = false;
                drawingBoard[i, sizeY + 1].color = Color.Empty;
            }
            for (int i = 1; i < sizeY + 1; i++)
            {
                drawingBoard[0, i].state = false;
                drawingBoard[0, i].color = Color.Empty;
            }
            for (int i = 1; i < sizeY + 1; i++)
            {
                drawingBoard[sizeX + 1, i].state = false;
                drawingBoard[sizeX + 1, i].color = Color.Empty;
            }
            for (int i = 1; i < sizeX + 1; i++)
            {
                for (int j = 1; j < sizeY + 1; j++)
                    drawingBoard[i, j] = board[i - 1, j - 1];
            }
        }

        private void cbRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbRule.SelectedIndex;
            if (index == 4)
            {
                int sizeX = Convert.ToInt32(tbX.Text);
                int sizeY = Convert.ToInt32(tbY.Text);
                tbRadius.Visible = true;
                lblRadius.Visible = true;
                displacement = new double[sizeX, sizeY];
                setDisplacement(displacement, sizeX, sizeY);
            }
            else
            {
                tbRadius.Visible = false;
                lblRadius.Visible = false;
            }
        }

        private void setDisplacement(double[,] displacement, int sizeX, int sizeY)
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    displacement[i, j] = random.Next(6) / 10.0;
                    if (random.NextDouble() > 0.5)
                        displacement[i, j] *= (-1);
                }
            }
        }
    }
}
