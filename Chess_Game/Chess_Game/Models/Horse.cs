﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Horse : ChessPieces, IPiece
    {
        public override string? Piece { get; set; } = "\u2658";

        // if it changes color to white it is because it belongs to another player
        public override bool IsPlayer1 { get; set; } = true;
        public Horse(bool isBlack)
        {
            if (!isBlack)
            {
                Piece = "\u265E";
                IsPlayer1 = false;
            }
        }

        // here returns who owns the instance of the piece 
        public int Playerpiece()
        {
            if (IsPlayer1)
            {
                return 1;
            }
            return 2;
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

    }
}
