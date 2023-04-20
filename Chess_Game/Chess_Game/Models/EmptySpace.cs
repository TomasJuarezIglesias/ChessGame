using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    // This class is used to show the free spaces on the board
    public class EmptySpace : ChessPieces
    {
        public override string? Piece { get; set; } = "*";
        public override bool IsPlayer1 { get; set; }

    }
}
