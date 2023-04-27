using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class King : IPiece
    {
        public  string? Piece { get; set; } = "\u2654";
        // if it changes color to white it is because it belongs to another player
        public  bool IsPlayer1 { get; set; } = true;
        public King(bool isBlack)
        {
            if (!isBlack)
            {
                Piece = "\u265A";
                IsPlayer1 = false;
            }
        }

        // here returns who owns the instance of the piece 
        public int Playerpiece()
        {
            if(IsPlayer1) 
            {
                return 1; 
            }
            return 2;
        }

        public bool Move(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable)
        {
            int numberOfSquares = whereToMove[0] - pieceSelect[0];
            int lateralMovements = whereToMove[1] - pieceSelect[1];

            //Validation for king movement that allows movement in all directions.
            if (numberOfSquares < -1 || numberOfSquares > 1 || lateralMovements < -1 || lateralMovements > 1) return false; 

            return true;
        }
    }
}
