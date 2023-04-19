using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class King : ChessPieces , IPiece
    {
        public override string? Piece { get; set; } = "\u2654";
        

        public King(bool isBlack)
        {
            if (!isBlack)
            {
                Piece = "\u265A";
            }
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
