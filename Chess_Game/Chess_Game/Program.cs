using Chess_Game.Models;
using Chess_Game.Application;
using System;

namespace Chess_Game // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here the table is created, already calling a method to give the game board.
            IPiece[,] actualTable = StartGame.Start();

            PlayerTurn playerTurn = new();
            Player player1 = new(1);
            Player player2 = new(2);

            bool gameOver = false;
            IsKingAlive isKingAlive = new();

            while (!gameOver)
            {

                // here begins the turn of player 1.
                actualTable = playerTurn.StartTurn(actualTable ,player1);

                // Validation to check if someone has won by check.
                gameOver = isKingAlive.IsAlive(actualTable);
                if (gameOver)
                {
                    break;
                }

                // here begins the turn of player 2.
                actualTable = playerTurn.StartTurn(actualTable, player2);

                // Validation to check if someone has won by check.
                gameOver = isKingAlive.IsAlive(actualTable);
            }

            Console.ReadLine();
        }
    }
}
