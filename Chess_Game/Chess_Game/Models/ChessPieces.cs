﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    // abstract class that forces the implementation of the string for the value of the piece
    public abstract class ChessPieces
    {
        public abstract string? Piece { get; set; }
        public abstract bool IsPlayer1 { get; set; }
        

    }
}
