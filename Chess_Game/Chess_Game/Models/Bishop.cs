using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Bishop : ChessPieces, IPiece
    {
        public override string? Piece { get; set; } = "\u2657";
        

        public Bishop(bool isBlack) 
        {
            if (!isBlack)
            {
                Piece = "\u265D";
            }    
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
