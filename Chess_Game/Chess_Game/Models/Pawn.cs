using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Pawn : IPiece
    {
        public string? Piece { get; set; } = "\u2659";
        // if it changes color to white it is because it belongs to another player
        public bool IsPlayer1 { get; set; } = true;
        private bool FirstMove = true;
        public Pawn(bool isBlack)
        {
            if (!isBlack)
            {
                Piece = "\u265F";
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

        // Here we have the validation of the pawn's movement
        public bool Move(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable)
        {
            // Calculations are made for movements
            int numberOfSquares = whereToMove[0] - pieceSelect[0];
            int lateralMovements = whereToMove[1] - pieceSelect[1];
            bool canContinue = true;

            if (!IsPlayer1)
            {
                // If a sideways movement is made and one square is advanced, it is verified that it is not an empty space.
                if (lateralMovements == 1 && numberOfSquares == -1|| lateralMovements == -1 && numberOfSquares == -1)
                {
                    if (actualTable[whereToMove[0], whereToMove[1]].GetType() == typeof(EmptySpace)) return false;                    
                    canContinue = false;
                }

                if (canContinue)
                {
                    // Validation if there is a movement backwards or more than allowed. It also checks if there is any movement sideways.
                    // Indirectly, it also verifies if the lateral movements are more than allowed.
                    if (numberOfSquares != -2 && numberOfSquares != -1 || lateralMovements != 0) return false;

                    if (numberOfSquares == -2 && !FirstMove) return false;

                    // Here we verify if a piece is not an empty space.
                    for (int i = pieceSelect[0] - 1; i >= whereToMove[0]; i--)
                    {
                        if (actualTable[i, pieceSelect[1]].GetType() != typeof(EmptySpace)) return false;
                    }
                }

                FirstMove = false;
                return true;
            }

            // If a sideways movement is made and one square is advanced, it is verified that it is not an empty space.
            if (lateralMovements == 1 && numberOfSquares == 1 || lateralMovements == -1 && numberOfSquares == 1)
            {                
                if (actualTable[whereToMove[0], whereToMove[1]].GetType() == typeof(EmptySpace)) return false;
                canContinue = false;
            }

            if (canContinue)
            {
                // Validation if there is a movement backwards or more than allowed. It also checks if there is any movement sideways.
                // Indirectly, it also verifies if the lateral movements are more than allowed.
                if (numberOfSquares != 2 && numberOfSquares != 1 || lateralMovements != 0)  return false;
                if (numberOfSquares == 2 && !FirstMove) return false;   

                // Here we verify if a piece is not an empty space.
                for (int i = pieceSelect[0] + 1; i <= whereToMove[0]; i++)
                {
                    if (actualTable[i, pieceSelect[1]].GetType() != typeof(EmptySpace)) return false;
                }
            }
            FirstMove = false;
            return true;
        }

    }
}
