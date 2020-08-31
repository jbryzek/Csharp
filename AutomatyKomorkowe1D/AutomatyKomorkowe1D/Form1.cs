using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutomatyKomorkowe1D
{
    public partial class FormCellular : System.Windows.Forms.Form
    {
        bool[,] board;
        public FormCellular()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            drawLiveCells();
        }

        private void drawLiveCells()
        {
            if (tbIterations.Text == "")
            {
                MessageBox.Show("You have to write number of iterations", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbCondition.Text == "")
            {
                MessageBox.Show("You have to write a condition", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbSize.Text == "")
            {
                MessageBox.Show("You have to write a size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbRules.Text == "")
            {
                MessageBox.Show("You have to write a rule", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int iterations = Convert.ToInt32(tbIterations.Text);
            int size = Convert.ToInt32(tbSize.Text);
            board = new bool[size, iterations];
            zeroTheBoard(size, iterations);
            applyRules(size, iterations);
            drawing(size, iterations);
        }

        private void drawing(int size, int iterations)
        {
            Bitmap b = new Bitmap(size,iterations);
            for (int i = 0; i < iterations; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j])
                    {
                        b.SetPixel(i, j, Color.Red);
                        pb.Image = b;
                    }
                }
            }
        }

        private void zeroTheBoard(int size, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                for (int j = 0; j < size; j++)
                    board[i, j] = false;
            }
            board[(size / 2) - 1, 0] = true; //set first cell alive
        }

        private void applyRules(int size, int iterations)
        {
            int rule = Convert.ToInt32(cbRules.SelectedItem.ToString());
            bool[] binRule = convertToBinary(rule);
            for (int i = 0; i < iterations-1; i++)
            {
                specialRule(size, i);
                for (int j = 1; j < size-1; j++)
                {
                    board[j, i + 1] = applyRule(board[j - 1, i], board[j, i], board[j + 1, i]);
                }
            }
        }

        private void specialRule(int size, int i)
        {
            int x = cbCondition.SelectedIndex;
            if (x == 0) //rule stala
            {
                board[0, i + 1] =  applyRule(false, board[0, i], board[1, i]);
                board[size - 1, i + 1] = applyRule(board[size - 2, i], board[size - 1, i], false);
            }
            else if(x==1) // rule zawijana
            {
                board[0, i + 1] = applyRule(board[size-1,i], board[0, i], board[1, i]);
                board[size - 1, i + 1] = applyRule(board[size - 2, i], board[size - 1, i], board[0,i]);
            }
            else if (x == 2) // rule odbijajaca
            {
                board[0, i + 1] = applyRule(true, board[0, i], board[1, i]);
                board[size - 1, i + 1] = applyRule(board[size - 2, i], board[size - 1, i], true);
            }
        }

        private bool applyRule(bool v1, bool v2, bool v3)
        {
            int rule = Convert.ToInt32(cbRules.SelectedItem.ToString());
            bool[] boolRule = convertToBinary(rule);
            if (v1 && v2 && v3)
                return boolRule[0];
            if (v1 && v2 && !v3)
                return boolRule[1];
            if (v1 && !v2 && v3)
                return boolRule[2];
            if (v1 && !v2 && !v3)
                return boolRule[3];
            if (!v1 && v2 && v3)
                return boolRule[4];
            if (!v1 && v2 && !v3)
                return boolRule[5];
            if (!v1 && !v2 && v3)
                return boolRule[6];
            if (!v1 && !v2 && !v3)
                return boolRule[7];
            return false;
        }

        private bool[] convertToBinary(int rule)
        {
            string binRule = "";
            while (rule > 0)
            {
                if (rule % 2 == 0)
                    binRule += "0";
                else
                    binRule += "1";
                rule /= 2;
            }
            char[] binaryRule = binRule.ToCharArray();
            Array.Reverse(binaryRule);
            string tmp = "";
            foreach (char a in binaryRule)
            {
                tmp += a.ToString();
            }
            while (tmp.Length < 8)
            {
                tmp = tmp.Insert(0, "0");
            }
            binaryRule = tmp.ToCharArray();
            bool[] boolRule = { false, false, false, false, false, false, false, false };
            int i = 0;
            foreach(char a in binaryRule)
            {
                if (a == '1')
                    boolRule[i] = true;
                i++;
            }
            return boolRule;
        }
    }
}
