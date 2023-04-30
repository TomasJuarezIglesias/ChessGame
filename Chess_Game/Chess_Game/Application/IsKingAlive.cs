using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Application
{
    public class IsKingAlive
    {

        public bool IsAlive(IPiece[,] actualTable)
        {
            // This method looks for if both kings are still alive.
            bool gameOver = IteratePieces(actualTable);

            if (!gameOver) return false;

            // This method looks for the winner through the ownership property if it belongs to a certain player.
            Search(actualTable);
            return true;
        }

        public bool IteratePieces(IPiece[,] actualTable)
        {
            int counter = 0;
            foreach (var piece in actualTable)
            {
                if (piece.GetType() == typeof(King))
                {
                    counter++;
                };
            }

            if (counter != 2)
            {
                return true;
            }

            return false;
        }

        public void Search(IPiece[,] actualTable)
        {
            Console.Clear();
            foreach (var piece in actualTable)
            {
                if (piece.GetType() == typeof(King))
                {
                    if (!piece.IsPlayer1)
                    {
                        Console.WriteLine("Player number 2 wins");
                        break;
                    }
                    Console.WriteLine("Player number 1 wins");
                    break;
                }
            }
        }

    }
}
