using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game_in_C_
{
    public partial class Form1 : Form
    {
        Boolean checker = true; // true = X turn, false = O turn
        int xScore = 0;
        int oScore = 0;
        int moveCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void Enabled_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void ResetGame()
        {
            // Clear all button texts
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            // Enable all buttons
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            // Reset background colors
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;
            button7.BackColor = SystemColors.Control;
            button8.BackColor = SystemColors.Control;
            button9.BackColor = SystemColors.Control;

            checker = true; // X starts
            moveCount = 0;
        }

        void CheckForWin()
        {
            bool winner = false;//this is for winner logic

            // Check rows for X
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X"))
            {
                winner = true;
                HighlightWinningButtons("X");
            }
            // Check columns for X
            else if ((button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                     (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                     (button3.Text == "X" && button6.Text == "X" && button9.Text == "X"))
            {
                winner = true;
                HighlightWinningButtons("X");
            }
            // Check diagonals for X
            else if ((button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                     (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                winner = true;
                HighlightWinningButtons("X");
            }
            // Check rows for O
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                     (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                     (button7.Text == "O" && button8.Text == "O" && button9.Text == "O"))
            {
                winner = true;
                HighlightWinningButtons("O");
            }
            // Check columns for O
            else if ((button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                     (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                     (button3.Text == "O" && button6.Text == "O" && button9.Text == "O"))
            {
                winner = true;
                HighlightWinningButtons("O");
            }
            // Check diagonals for O
            else if ((button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                     (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                winner = true;
                HighlightWinningButtons("O");
            }

            if (winner)
            {
                Enabled_False();
            }
            else if (moveCount == 9)
            {
                MessageBox.Show("It's a Draw!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void HighlightWinningButtons(string player)
        {
            Color winColor = Color.LightGreen;

            // Check which combination won and highlight it
            if (button1.Text == player && button2.Text == player && button3.Text == player)
            {
                button1.BackColor = winColor;
                button2.BackColor = winColor;
                button3.BackColor = winColor;
            }
            else if (button4.Text == player && button5.Text == player && button6.Text == player)
            {
                button4.BackColor = winColor;
                button5.BackColor = winColor;
                button6.BackColor = winColor;
            }
            else if (button7.Text == player && button8.Text == player && button9.Text == player)
            {
                button7.BackColor = winColor;
                button8.BackColor = winColor;
                button9.BackColor = winColor;
            }
            else if (button1.Text == player && button4.Text == player && button7.Text == player)
            {
                button1.BackColor = winColor;
                button4.BackColor = winColor;
                button7.BackColor = winColor;
            }
            else if (button2.Text == player && button5.Text == player && button8.Text == player)
            {
                button2.BackColor = winColor;
                button5.BackColor = winColor;
                button8.BackColor = winColor;
            }
            else if (button3.Text == player && button6.Text == player && button9.Text == player)
            {
                button3.BackColor = winColor;
                button6.BackColor = winColor;
                button9.BackColor = winColor;
            }
            else if (button1.Text == player && button5.Text == player && button9.Text == player)
            {
                button1.BackColor = winColor;
                button5.BackColor = winColor;
                button9.BackColor = winColor;
            }
            else if (button3.Text == player && button5.Text == player && button7.Text == player)
            {
                button3.BackColor = winColor;
                button5.BackColor = winColor;
                button7.BackColor = winColor;
            }

            MessageBox.Show($"Player {player} Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (player == "X")
            {
                xScore++;
                labelX.Text = xScore.ToString();
            }
            else
            {
                oScore++;
                labelO.Text = oScore.ToString();
            }
        }

        // Button click handlers for the game grid
        
        //RESET button
        private void button11_Click(object sender, EventArgs e)
        {
            ResetGame();
            

        }
        // Exit button
        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //New Game button
        private void button10_Click_1(object sender, EventArgs e)
        {

            ResetGame();
            MessageBox.Show("New Game Started!", " Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (checker)
                {
                    button1.Text = "X";
                    checker = false;
                }
                else
                {
                    button1.Text = "O";
                    checker = true;
                }
                moveCount++;
                CheckForWin();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (button2.Text == "")
            {
                if (checker)
                {
                    button2.Text = "X";
                    checker = false;
                }
                else
                {
                    button2.Text = "O";
                    checker = true;
                }
                moveCount++;
                CheckForWin();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (button3.Text == "")
            {
                if (checker)
                {
                    button3.Text = "X";
                    checker = false;
                }
                else
                {
                    button3.Text = "O";
                    checker = true;
                }
                moveCount++;
                CheckForWin();
            }
    }

        private void button6_Click_1(object sender, EventArgs e)
        {

            if (button6.Text == "")
            {
                if (checker)
                {
                    button6.Text = "X";
                    checker = false;
                }
                else
                {
                    button6.Text = "O";
                    checker = true;
                }
                moveCount++;
                CheckForWin();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            if (button5.Text == "")
            {
                if (checker)
                {
                    button5.Text = "X";
                    checker = false;
                }
                else
                {
                    button5.Text = "O";
                    checker = true;
                }
                moveCount++;
                CheckForWin();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
                
            if (button4.Text == "")
            {
                if (checker)
                {
                    button4.Text = "X";
                    checker = false;
                }
                else
                {
                    button4.Text = "O";
                    checker = true;
                }
                moveCount++;
                CheckForWin();
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            if (button9.Text == "")
            {
                if (checker)
                {
                    button9.Text = "X";
                    checker = false;
                }
                else
                {
                    button9.Text = "O";
                    checker = true;
                }
                moveCount++;
                CheckForWin();
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            if (button8.Text == "")
            {
                if (checker)
                {
                    button8.Text = "X";
                    checker = false;
                }
                else
                {
                    button8.Text = "O";
                    checker = true;
                }
                moveCount++;
                CheckForWin();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            if (button7.Text == "")
            {
                if (checker)
                {
                    button7.Text = "X";
                    checker = false;
                }
                else
                {
                    button7.Text = "O";
                    checker = true;
                }
                moveCount++;
                CheckForWin();
            }
        }

       
        }
    }