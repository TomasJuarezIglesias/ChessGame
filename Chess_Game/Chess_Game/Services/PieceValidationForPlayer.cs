using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class PieceValidationForPlayer
    {
        // This method is to know whose piece it is 
        public static bool Validate(ChessPieces[,] board, Player thePlayer)
        {
            ChessPieces aPiece = board[thePlayer.CurrentPiecePlace[0], thePlayer.CurrentPiecePlace[1]];

            if(aPiece.GetType() == typeof(EmptySpace) || aPiece.GetType() == typeof(BoardCoordinates)) 
            {
                Console.Clear();
                Console.WriteLine("You have selected a wrong piece");
                return false;
            }

            if (thePlayer.NumPlayer == 1 && !aPiece.IsPlayer1 || thePlayer.NumPlayer == 2 && aPiece.IsPlayer1)
            {
                Console.Clear();
                Console.WriteLine("You have selected a wrong piece");
                return false;
            }

            return true;
        }


    }
}
