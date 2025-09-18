using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int playerTurn;
        TicTacToeGame game;

        public Form1()
        {
            InitializeComponent();
        }

        private void singlePlayerBtn_Click(object sender, EventArgs e)
        {
            game = new TicTacToeGame('S');
            playerTurn = game.chooseFirstPlayer();

            changePlayerLabel();
        }

        private void multiPlayerBtn_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            square0_0.Text = "";
            square0_1.Text = "";
            square0_2.Text = "";
            square1_0.Text = "";
            square1_1.Text = "";
            square1_2.Text = "";
            square2_0.Text = "";
            square2_1.Text = "";
            square2_2.Text = "";

            playerTurnLbl.Text = "";

            playerTurn = 0;     // prevents user from pressing squares and adding x or o after game is reset
        }

        public void changePlayerLabel()
        {
            if (playerTurn == 1)
            {
                playerTurnLbl.Text = "Player 1's Turn";
                playerTurn = 2;
            }
            else if (playerTurn == 2)
            {
                playerTurnLbl.Text = "Player 2's Turn";
                playerTurn = 1;
            }
            else
            {
                playerTurnLbl.Text = "Choose a game mode";
            }
        }

        // WORKING 
        #region Square Clicks
        private void square0_0_Click(object sender, EventArgs e)
        {
            changePlayerLabel();

            //runs if the game object has been initialized
            if (playerTurn > 0)
            {
                square0_0.Text = Convert.ToString(game.boardChange(playerTurn, 0, 0));
            }
        }

        private void square0_1_Click(object sender, EventArgs e)
        {
            changePlayerLabel();

            if (playerTurn > 0)
            {
                square0_1.Text = Convert.ToString(game.boardChange(playerTurn, 0, 1));
            }
        }

        private void square0_2_Click(object sender, EventArgs e)
        {
            changePlayerLabel();

            if (playerTurn > 0)
            {
                square0_2.Text = Convert.ToString(game.boardChange(playerTurn, 0, 2));
            }
        }

        private void square1_0_Click(object sender, EventArgs e)
        {
            changePlayerLabel();

            if (playerTurn > 0)
            {
                square1_0.Text = Convert.ToString(game.boardChange(playerTurn, 1, 0));
            }
        }

        private void square1_1_Click(object sender, EventArgs e)
        {
            changePlayerLabel();

            if (playerTurn > 0)
            {
                square1_1.Text = Convert.ToString(game.boardChange(playerTurn, 1, 1));
            }
        }

        private void square1_2_Click(object sender, EventArgs e)
        {
            changePlayerLabel();

            if (playerTurn > 0)
            {
                square1_2.Text = Convert.ToString(game.boardChange(playerTurn, 1, 2));
            }
        }

        private void square2_0_Click(object sender, EventArgs e)
        {
            changePlayerLabel();

            if (playerTurn > 0)
            {
                square2_0.Text = Convert.ToString(game.boardChange(playerTurn, 2, 0));
            }
        }

        private void square2_1_Click(object sender, EventArgs e)
        {
            changePlayerLabel();

            if (playerTurn > 0)
            {
                square2_1.Text = Convert.ToString(game.boardChange(playerTurn, 2, 1));
            }
        }

        private void square2_2_Click(object sender, EventArgs e)
        {
            changePlayerLabel();

            if (playerTurn > 0)
            {
                square2_2.Text = Convert.ToString(game.boardChange(playerTurn, 2, 2));
            }
        }


        #endregion


    }
}
