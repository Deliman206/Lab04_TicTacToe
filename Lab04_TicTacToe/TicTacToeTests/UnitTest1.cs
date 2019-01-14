using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTests
{
    public class CheckForWinnerTests
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

            Assert.Equal("true", CheckForWinner(board).ToString());
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
    public class SwitchPlayerTests
    {
        Player p1 = new Player();
        Player p2 = new Player();

        [Fact]
        public void SwitchTurnOnPlayerOne()
        {
           
            Assert.Equal("True", p1.IsTurn.ToString());
            SwitchPlayer();
            Assert.Equal("False", p1.IsTurn.ToString());
        }
        [Fact]
        public void SwitchTurnOnPlayerTwo()
        {
            Assert.Equal("True", p2.IsTurn.ToString());
            SwitchPlayer();
            Assert.Equal("False", p2.IsTurn.ToString());
        }
    }
    public class MarkerToCorrectBoardPosition
    {
        [Fact]
        public void test1()
        {

        }
    }
}
