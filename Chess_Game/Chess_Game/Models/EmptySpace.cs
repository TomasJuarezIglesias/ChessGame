using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class EmptySpace : ChessPieces
    {
        public override string? Piece { get; set; } = "*";

    }
}
