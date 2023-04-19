using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Queen : ChessPieces, IPiece
    {
        public override string? Piece { get; set; } = "\u2655";
        

        public Queen(bool isBlack)
        {
            if (!isBlack) 
            {
                Piece = "\u265B";
            }
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
