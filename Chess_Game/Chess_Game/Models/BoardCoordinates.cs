using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    // This class is used to show the coordinates values in the table
    public class BoardCoordinates : ChessPieces
    {
        public override string? Piece { get; set; }
        public override bool IsPlayer1 { get; set; }

        public BoardCoordinates(string coordinate)
        {
            Piece = coordinate;
        }
    }
}
