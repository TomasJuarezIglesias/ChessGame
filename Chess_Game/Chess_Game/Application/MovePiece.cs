using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Application
{
    public class MovePiece
    {
        public IPiece[,]? Move(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable)
        {
            // Here, the method for each piece is called to perform the corresponding validation.
            bool canContinue = actualTable[pieceSelect[0], pieceSelect[1]].Move(pieceSelect, whereToMove, actualTable);
            if(!canContinue) 
            {
                Console.Clear();
                Console.WriteLine("You cannot make this move!!!");
                Thread.Sleep(2000);
                return null;
            }


            // Checking if it belongs to the same team
            if (actualTable[whereToMove[0], whereToMove[1]].IsPlayer1 == actualTable[pieceSelect[0], pieceSelect[1]].IsPlayer1 && actualTable[whereToMove[0], whereToMove[1]].GetType() != typeof(EmptySpace))
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
            IPiece temp = actualTable[whereToMove[0], whereToMove[1]];
            actualTable[whereToMove[0], whereToMove[1]] = actualTable[pieceSelect[0], pieceSelect[1]];
            actualTable[pieceSelect[0], pieceSelect[1]] = temp;


            Console.Clear();
            ShowBoard.Show(actualTable);

            return actualTable;
        }

    }
}
