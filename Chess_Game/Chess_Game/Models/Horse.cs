using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Horse : ChessPieces, IPiece
    {
        public override string? Piece { get; set; } = "\u2658";
       
        public Horse(bool isBlack)
        {
            if (!isBlack)
            {
                Piece = "\u265E";
            }
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
