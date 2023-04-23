using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Tower : IPiece
    {
        public  string? Piece { get; set; } = "\u2656";

        // if it changes color to white it is because it belongs to another player
        public  bool IsPlayer1 { get; set; } = true;

        public Tower(bool isBlack)
        {
            if (!isBlack)
            {
                Piece = "\u265C";
                IsPlayer1 = false;
            }
        }

        // here returns who owns the instance of the piece 
        public int Playerpiece()
        {
            if (IsPlayer1)
            {
                return 1;
            }
            return 2;
        }

        public bool Move(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable)
        {
            throw new NotImplementedException();
        }
    }
}
