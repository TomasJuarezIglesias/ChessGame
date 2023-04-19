using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Tower : ChessPieces, IPiece
    {
        public override string? Piece { get; set; } = "\u2656";
        

        public Tower(bool isBlack)
        {
            if (!isBlack)
            {
                Piece = "\u265C";
            }
        }
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
