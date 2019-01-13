using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        /// Converts the Multidimentional to a visual board in the console.
        /// </summary>
		public void DisplayBoard()
		{
            string board = "";
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int k = 0; k < GameBoard.GetLength(1); k++)
                {
                    board +=  $"|{GameBoard[i, k]}|";
                }
                board += "\n";
            }
            Console.WriteLine(board);
        }
	}
}
