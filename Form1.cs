using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity13A
{
    public partial class Tic_tac_toe : Form
    {
        public Tic_tac_toe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void playAgain_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            const int rows = 3;
            const int columns = 3;
            int[,] board = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    board[row, col] = rand.Next(2);
                }
            }

            a1.Text = board[0, 0].ToString();
            a2.Text = board[0, 1].ToString();
            a3.Text = board[0, 2].ToString();
            b1.Text = board[1, 0].ToString();
            b2.Text = board[1, 1].ToString();
            b3.Text = board[1, 2].ToString();
            c1.Text = board[2, 0].ToString();
            c2.Text = board[2, 1].ToString();
            c3.Text = board[2, 2].ToString();

            //O win check
            if (board[0, 0] == 0 && (board[0, 0] == board[0, 1]) && (board[0, 1] == board[0, 2]))
            {
                winnerBox.Text = "O wins!";
            }
            else if (board[1, 0] == 0 && (board[1, 0] == board[1, 1]) && (board[1, 1] == board[1, 2]))
            {
                winnerBox.Text = "O wins!";
            }
            else if (board[2, 0] == 0 && (board[2, 0] == board[2, 1]) && (board[2, 1] == board[2, 2]))
            {
                winnerBox.Text = "O wins!";
            }
            else if (board[0, 0] == 0 && (board[0, 0] == board[1, 0]) && (board[1, 0] == board[2, 0]))
            {
                winnerBox.Text = "O wins!";
            }
            else if (board[0, 1] == 0 && (board[0, 1] == board[1, 1]) && (board[1, 1] == board[2, 1]))
            {
                winnerBox.Text = "O wins!";
            }
            else if (board[0, 2] == 0 && (board[0, 2] == board[1, 2]) && (board[1, 2] == board[2, 2]))
            {
                winnerBox.Text = "O wins!";
            }
            else if (board[0, 0] == 0 && (board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]))
            {
                winnerBox.Text = "O wins!";
            }
            else if (board[0, 2] == 0 && (board[0, 2] == board[1, 1]) && (board[0, 1] == board[2, 0]))
            {
                winnerBox.Text = "O wins!";
            }


            //X win check
            if (board[0, 0] == 1 && (board[0, 0] == board[0, 1]) && (board[0, 1] == board[0, 2]))
            {
                winnerBox.Text = "X wins!";
            }
            else if (board[1, 0] == 1 && (board[1, 0] == board[1, 1]) && (board[1, 1] == board[1, 2]))
            {
                winnerBox.Text = "X wins!";
            }
            else if (board[2, 0] == 1 && (board[2, 0] == board[2, 1]) && (board[2, 1] == board[2, 2]))
            {
                winnerBox.Text = "X wins!";
            }
            else if (board[0, 0] == 1 && (board[0, 0] == board[1, 0]) && (board[1, 0] == board[2, 0]))
            {
                winnerBox.Text = "X wins!";
            }
            else if (board[0, 1] == 1 && (board[0, 1] == board[1, 1]) && (board[1, 1] == board[2, 1]))
            {
                winnerBox.Text = "X wins!";
            }
            else if (board[0, 2] == 1 && (board[0, 2] == board[1, 2]) && (board[1, 2] == board[2, 2]))
            {
                winnerBox.Text = "X wins!";
            }
            else if (board[0, 0] == 1 && (board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]))
            {
                winnerBox.Text = "X wins!";
            }
            else if (board[0, 2] == 1 && (board[0, 2] == board[1, 1]) && (board[0, 1] == board[2, 0]))
            {
                winnerBox.Text = "X wins!";
            }
        }

       
    }
}
