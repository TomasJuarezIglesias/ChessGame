using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    // Interface for all classes that inherit from this one, some classes may not implement all its methods and properties.
    public interface IPiece
    {
        public  string? Piece { get; set; }
        public  bool IsPlayer1 { get; set; }
        public bool Move(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable);
        public int Playerpiece();

    }
}
