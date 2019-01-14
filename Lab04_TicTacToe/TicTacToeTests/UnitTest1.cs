using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe;

namespace TicTacToeTests
{
    public class UnitTest1
    {
        Board board = new Board();

        string[,] XWinnerGameBoard = new string[,]
        {
            {"X", "O", "X"},
            {"O", "X", "O"},
            {"X", "8", "9"},
        };
        string[,] OWinnerGameBoard = new string[,]
        {
            {"O", "O", "X"},
            {"O", "X", "X"},
            {"O", "X", "9"},
        };
        string[,] DrawGameBoard = new string[,]
        {
            {"X", "O", "X"},
            {"O", "X", "X"},
            {"O", "X", "O"},
        };

        board.GameBoard = XWinnerGameBoard;

        [Fact]
        public void PlayerOneWinsCheckForWinner()
        {
            Assert.Equal("true", Game.CheckForWinner(board).ToString());
        }

        board.GameBoard = OWinnerGameBoard;

        [Fact]
        public void PlayerTwoWinsCheckForWinner()
        {
            Assert.Equal("true", Game.CheckForWinner(board).ToString());
        }

        board.GameBoard = DrawGameBoard;

        [Fact]
        public void PlayerDrawWinsCheckForWinner()
        {
            Assert.Equal("true", Game.CheckForWinner(board).ToString());
        }
    }
}
