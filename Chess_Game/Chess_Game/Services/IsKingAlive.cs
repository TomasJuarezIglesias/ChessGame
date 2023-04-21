using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class IsKingAlive
    {
        SomeoneWins someoneWins = new();
        SearchWinner searchWinner = new();
        public bool IsAlive(ChessPieces[,] actualTable)
        {
            // This method looks for if both kings are still alive.
            bool gameOver = someoneWins.IteratePieces(actualTable);

            if (gameOver)
            {
                // This method looks for the winner through the ownership property if it belongs to a certain player.
                searchWinner.Search(actualTable);
                return true;
            }
            return false;

        }
    }
}
