using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    // This class is used to show the coordinates values in the table
    public class BoardCoordinates : IPiece
    {
        public  string? Piece { get; set; }
        public  bool IsPlayer1 { get; set; }

        public BoardCoordinates(string coordinate)
        {
            Piece = coordinate;
        }

        public bool Move(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable)
        {
            throw new NotImplementedException();
        }

        public int Playerpiece()
        {
            throw new NotImplementedException();
        }
    }
}
