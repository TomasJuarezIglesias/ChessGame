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
        public IsKingAlive()
        {
            someoneWins = new();
            searchWinner = new();
        }
        SomeoneWins someoneWins;
        SearchWinner searchWinner;

        public bool IsAlive(IPiece[,] actualTable)
        {
            // This method looks for if both kings are still alive.
            bool gameOver = someoneWins.IteratePieces(actualTable);

            if (!gameOver) return false;

            // This method looks for the winner through the ownership property if it belongs to a certain player.
            searchWinner.Search(actualTable);
            return true;
        }
    }
}
