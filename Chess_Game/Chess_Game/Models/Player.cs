using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Player
    {
        public int NumPlayer { get; set; }

        public int[] CurrentPiecePlace = new int[2];

        
        public Player(int numPlayer)
        {
            NumPlayer = numPlayer;
        }

        public void AddCurrentPiece(int x, int y)
        {
            CurrentPiecePlace[0] = y - 1;
            CurrentPiecePlace[1] = x;
        }

    }
}
