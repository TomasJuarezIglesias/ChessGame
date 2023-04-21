using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class MovePiece
    {
        public ChessPieces[,]? Move(int[] pieceSelect, int[] whereToMove, ChessPieces[,] actualTable)
        {
            // Checking if it belongs to the same team
            if (actualTable[whereToMove[0], whereToMove[1]].IsPlayer1 == actualTable[pieceSelect[0], pieceSelect[1]].IsPlayer1)
            {
                Console.Clear();
                Console.WriteLine("The piece you want to eliminate belongs to your own team.!!");
                Thread.Sleep(2000);
                return null;
            }


            // Here we have the validation if it is a piece of the other player.
            if (actualTable[whereToMove[0], whereToMove[1]].GetType() != typeof(EmptySpace))
            {
                actualTable[whereToMove[0], whereToMove[1]] = actualTable[pieceSelect[0], pieceSelect[1]];
                actualTable[pieceSelect[0], pieceSelect[1]] = new EmptySpace();

                Console.Clear();
                ShowBoard.Show(actualTable);

                return actualTable;
            }

            // Here the exchange of pieces is made
            ChessPieces temp = actualTable[whereToMove[0], whereToMove[1]];
            actualTable[whereToMove[0], whereToMove[1]] = actualTable[pieceSelect[0], pieceSelect[1]];
            actualTable[pieceSelect[0], pieceSelect[1]] = temp;


            Console.Clear();
            ShowBoard.Show(actualTable);

            return actualTable;
        }

    }
}
