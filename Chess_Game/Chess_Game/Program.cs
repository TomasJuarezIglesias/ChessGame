using Chess_Game.Models;
using Chess_Game.Services;
using System;

namespace Chess_Game // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartGame newGame = new();
            PlayerTurn playerTurn = new();
            ChessPieces[,] actualTable = newGame.Start();

            bool gameOver = false;
            Player player1 = new(1);
            Player player2 = new(2);

            while (!gameOver)
            {
                // here begins the turn of each player
                actualTable = playerTurn.StartTurn(actualTable ,player1);

                actualTable = playerTurn.StartTurn(actualTable ,player2);

                

                
            }


            Console.ReadLine();



            
        }
    }
}
