using Chess_Game.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Bishop : IPiece, IDiagonalMovement
    {
        public  string? Piece { get; set; } = "\u2657";

        // if it changes color to white it is because it belongs to another player
        public  bool IsPlayer1 { get; set; } = false;

        public Bishop(bool isBlack) 
        {
            if (!isBlack)
            {
                Piece = "\u265D";
                IsPlayer1 = true;
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

        public bool Move(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable)
        {
            
            return DiagonalMovement(pieceSelect, whereToMove, actualTable);
        }

        public bool DiagonalMovement(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable)
        {
            int numberOfSquares = whereToMove[0] - pieceSelect[0];
            int lateralMovements = whereToMove[1] - pieceSelect[1];

            // This is the method to check if the results of the operation have the same absolute value, and then get their sign.
            if (Math.Abs(numberOfSquares) != Math.Abs(lateralMovements)) return false;

            int signNumberOfSquares = Math.Sign(numberOfSquares);
            int signLateralMovements = Math.Sign(lateralMovements);

            int y = pieceSelect[0];
            int x = pieceSelect[1];
            bool canContinue = true;
            do
            {
                _ = signNumberOfSquares == 1 ? y++ : y--;

                _ = signLateralMovements == 1 ? x++ : x--;

                //Validation to check if it belongs to the same team.
                if (actualTable[pieceSelect[0], pieceSelect[1]].IsPlayer1 == actualTable[y, x].IsPlayer1 && actualTable[y, x].GetType() != typeof(EmptySpace)) return false;

                // When the same values are obtained, the iteration is stopped.
                if (whereToMove[0] == y && whereToMove[1] == x) canContinue = false;

            } while (canContinue);


            return true;
        }
    }
}
