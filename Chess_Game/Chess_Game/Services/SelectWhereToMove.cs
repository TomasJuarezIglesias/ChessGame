using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class SelectWhereToMove
    {
        // Here the destination for the movement is selected
        public int[] WhereToMove(ChessPieces[,] actualTable)
        {
            Input_VerificationValues input = new();
            string text = "where to move";

            int[] coordinates = input.InputVerificationOfValues(actualTable, text);

            return coordinates;
        }


    }
}
