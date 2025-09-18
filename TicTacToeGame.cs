using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToeGame
    {
        private char gameType;
        private char[,] board;
        public TicTacToeGame(char game)
        {
            gameType = game;
            board = new char[3, 3]{
                {'-','-','-'},
                {'-','-','-'},
                {'-','-','-'}};

            Console.WriteLine("Creating a new board");
        }
        public int chooseFirstPlayer()
        {
            Random num = new Random();
            return num.Next(1, 3);  // finds a number (1-2) to see who will go first
        }

        public char boardChange(int playerTurn, int row, int column)
        {
            if (board[row, column] != '-')
            {
                return board[row, column];
            }
            else if (playerTurn == 1)
            {
                board[row, column] = 'X';
                checkForWin(playerTurn);
                return 'X';
            }
            else
            {
                board[row, column] = 'O';
                checkForWin(playerTurn);
                return 'O';
            }
        }


        public void checkForWin(int playerTurn)
        {
            // only checks for horizontal / row wins
            int matches;

            for (int row = 0; row < 3; row++)
            {
                matches = 0;

                for (int column = 1; column < 3; column++)
                {
                    if (board[row, 0] == '-')
                    {
                        continue;
                    }
                    else if (board[row, 0] == board[row, column])
                    {
                        matches++;
                    }
                }
            }

            // only checks for vertical / column wins
            for (int column = 0; column < 3; column++)
            {
                matches = 0;

                for (int row = 1; row < 3; row++)
                {
                    if (board[0, column] == '-')
                    {
                        continue;
                    }
                    else if (board[0, column] == board[row, column])
                    {
                        matches++;
                    }
                }






                //runs if there is a win

                if (matches == 2 && playerTurn == 1)
                {
                    Console.WriteLine("Player 1 Wins");
                    break;
                }
                else if (matches == 2 && playerTurn == 2)
                {
                    Console.WriteLine("Player 2 Wins");
                    break;
                }
            }
        }
    }
}
