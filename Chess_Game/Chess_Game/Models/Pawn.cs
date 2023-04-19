using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Pawn : ChessPieces, IPiece
    {
        public override string? Piece { get; set; } = "\u2659";
        

        public Pawn(bool isBlack)
        {
            if (!isBlack)
            {
                Piece = "\u265F";
            }
        }
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
