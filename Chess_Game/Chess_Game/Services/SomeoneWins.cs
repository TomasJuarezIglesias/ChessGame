using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class SomeoneWins
    {
        public bool IteratePieces(ChessPieces[,] actualTable)
        {
            int counter = 0;
            foreach (var piece in actualTable)
            {
                if(piece.GetType() == typeof(King))
                {
                    counter++;
                }; 
            }

            if(counter != 2)
            {
                return true;
            }

            return false;
        }



    }
}
