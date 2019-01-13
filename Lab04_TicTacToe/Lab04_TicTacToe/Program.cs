using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Player draw = new Player();

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            Console.WriteLine("Who would like to me Player One?");
            string playerOneName = Console.ReadLine();
            p1.Name = playerOneName;
            p1.Marker = "X";

            Console.WriteLine("Who would like to be Player Two?");
            string playerTwoName = Console.ReadLine();
            p2.Name = playerTwoName;
            p2.Marker = "O";


            Game game = new Game(p1, p2, draw);
            Player winnerOfGame = game.Play();
            if (winnerOfGame.Name == "Draw")
            {
                Console.WriteLine("Sorry, this game was a draw.");
            }
            Console.WriteLine($"{winnerOfGame.Name}, you win this game!");
            Console.Read();
        }
    }
}
