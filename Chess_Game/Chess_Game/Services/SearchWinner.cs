using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class SearchWinner
    {

        public void Search(ChessPieces[,] actualTable)
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
