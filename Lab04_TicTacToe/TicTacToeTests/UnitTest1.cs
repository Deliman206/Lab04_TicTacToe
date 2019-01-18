using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTests
{
    public class CheckForWinnerTests
    {
        [Fact]
        public void PlayerOneWinsCheckForWinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Player pd = new Player();
            Game game = new Game(p1, p2, pd);

            Board board = new Board();
            string[,] XWinnerGameBoard = new string[,]
            {
            {"X", "O", "X"},
            {"O", "X", "O"},
            {"X", "8", "9"},
            };
            board.GameBoard = XWinnerGameBoard;
            game.Board = board;
            Assert.True(game.CheckForWinner());
        }

        [Fact]
        public void PlayerTwoWinsCheckForWinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Player pd = new Player();
            Game game = new Game(p1, p2, pd);

            Board board = new Board();

            string[,] OWinnerGameBoard = new string[,]
            {
            {"O", "O", "X"},
            {"O", "X", "X"},
            {"O", "X", "9"},
            };
            board.GameBoard = OWinnerGameBoard;
            game.Board = board;
            Assert.True(game.CheckForWinner());
        }


        [Fact]
        public void PlayerDrawWinsCheckForWinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Player pd = new Player();
            Game game = new Game(p1, p2, pd);

            Board board = new Board();

            string[,] DrawGameBoard = new string[,]
            {
                {"X", "O", "X"},
                {"O", "X", "X"},
                {"O", "X", "O"},
            };
            board.GameBoard = DrawGameBoard;
            game.Board = board;
            Assert.False(game.CheckForWinner());
        }
    }
    public class SwitchPlayerTests
    {
        [Fact]
        public void SwitchTurnOnPlayerOne()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Player pd = new Player();
            Game game = new Game(p1, p2, pd);
            game.SwitchPlayer();
            bool p1Turn = p1.IsTurn;
            bool p2Turn = p2.IsTurn;
            Assert.True(p1Turn && !p2.IsTurn);
        }
    }
    public class MarkerToCorrectBoardPosition
    {
        [Fact]
        public void POneMarkerToPostionOne()
        {
            Player p1 = new Player();
            p1.Marker = "X";
            Player p2 = new Player();
            Player pd = new Player();
            Game game = new Game(p1, p2, pd);

            Board board = new Board();
            Board literalBoard = new Board();

            string[,] POneMarkerPositionAtOneGameBoard = new string[,]
            {
            {"X", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
            };
            literalBoard.GameBoard = POneMarkerPositionAtOneGameBoard;

            Position pOneDesiredPosition = new Position(0, 0);
            board.GameBoard[pOneDesiredPosition.Row, pOneDesiredPosition.Column] = p1.Marker;

            Assert.Equal(literalBoard.ToString(), board.ToString());
        }

        [Fact]
        public void PlayerTwoMarkerToPostionOne()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            p2.Marker = "O";
            Player pd = new Player();
            Game game = new Game(p1, p2, pd);

            Board board = new Board();
            Board literalBoard = new Board();

            string[,] PTwoMarkerPositionAtOneGameBoard = new string[,]
            {
            {"O", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
            };
            literalBoard.GameBoard = PTwoMarkerPositionAtOneGameBoard;

            Position pTwoDesiredPosition = new Position(0, 0);
            board.GameBoard[pTwoDesiredPosition.Row, pTwoDesiredPosition.Column] = p1.Marker;

            Assert.Equal(literalBoard.ToString(), board.ToString());
        }
    }
}
