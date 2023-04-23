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
            // Variables used to perform the operations
            int numberOfSquares;
            int lateralMovements;
            bool canContinue = true;

            if (!IsPlayer1)
            {

                // Calculations are made for movements
                numberOfSquares = pieceSelect[0] - whereToMove[0];
                lateralMovements = whereToMove[1] - pieceSelect[1];

                // If a movement is made to the right or left, it is checked whether there is any opponent's piece in its upward movement.
                if (lateralMovements == 1 || lateralMovements == -1)
                {
                    for (int i = pieceSelect[0] - 1; i >= whereToMove[0]; i--)
                    {
                        // If the upward movement is greater than 1, it is already trapped by this condition.
                        if (actualTable[i, whereToMove[1]].GetType() == typeof(EmptySpace)) return false;                    
                    }
                    canContinue = false;
                }

                if (canContinue)
                {
                    // Here we verify if a piece is not an empty space.
                    for (int i = pieceSelect[0] - 1; i >= whereToMove[0]; i--)
                    {
                        if (actualTable[i, pieceSelect[1]].GetType() != typeof(EmptySpace)) return false;
                    }

                    // Validation if there is a movement backwards or more than allowed. It also checks if there is any movement sideways.
                    if (numberOfSquares != 2 && numberOfSquares != 1 || lateralMovements != 0) return false;

                    if (numberOfSquares == 2 && !FirstMove) return false;

                    FirstMove = false;
                    return true;
                }

                // Specific operations are performed again to validate if a diagonal kill is possible.
                lateralMovements = pieceSelect[1] - whereToMove[1];
                numberOfSquares = pieceSelect[0] - whereToMove[0];

                // Validation to capture diagonally
                if (numberOfSquares != 1 || lateralMovements != 1 && lateralMovements != -1) return false;
                
                if (actualTable[whereToMove[0], whereToMove[1]].GetType() == typeof(EmptySpace)) return false;
                

                FirstMove = false;
                return true;
            }

            // Calculations are made for movements
            // This is in a different context as other operations are performed to make it easier to understand.
            numberOfSquares = whereToMove[0] - pieceSelect[0];
            lateralMovements = whereToMove[1] - pieceSelect[1];

            // If a movement is made to the right or left, it is checked whether there is any opponent's piece in its upward movement.
            if (lateralMovements == 1 || lateralMovements == -1)
            {
                for (int i = pieceSelect[0] + 1; i <= whereToMove[0]; i++)
                {
                    // If the upward movement is greater than 1, it is already trapped by this condition.
                    if (actualTable[i, whereToMove[1]].GetType() == typeof(EmptySpace)) return false;

                }
                canContinue = false;
            }


            if (canContinue)
            {
                // Here we verify if a piece is not an empty space.
                for (int i = pieceSelect[0] + 1; i <= whereToMove[0]; i++)
                {
                    if (actualTable[i, pieceSelect[1]].GetType() != typeof(EmptySpace)) return false;
                }
                // Validation if there is a movement backwards or more than allowed. It also checks if there is any movement sideways.
                if (numberOfSquares != 2 && numberOfSquares != 1 || lateralMovements != 0)  return false;
            
                if (numberOfSquares == 2 && !FirstMove) return false;   

                FirstMove = false;
                return true;
            }


            // Specific operations are performed again to validate if a diagonal kill is possible.
            lateralMovements = pieceSelect[1] - whereToMove[1];
            numberOfSquares = whereToMove[0] - pieceSelect[0];

            // Validation to capture diagonally
            if (numberOfSquares != 1 || lateralMovements != 1 && lateralMovements != -1)return false;

            if (actualTable[whereToMove[0], whereToMove[1]].GetType() == typeof(EmptySpace))return false;

            FirstMove = false;
            return true;
        }

    }
}
