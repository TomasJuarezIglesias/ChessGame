using Chess_Game.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Queen : IPiece, IVerticalHorizontalMovement, IDiagonalMovement
    {
        public  string? Piece { get; set; } = "\u2655";
        // if it changes color to white it is because it belongs to another player
        public  bool IsPlayer1 { get; set; } = true;

        public Queen(bool isBlack)
        {
            if (!isBlack) 
            {
                Piece = "\u265B";
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

        public bool Move(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable)
        {

            bool canMove = VerticalHorizontalMovement(pieceSelect, whereToMove, actualTable);

            if (canMove) return true;

            return DiagonalMovement(pieceSelect, whereToMove, actualTable);
        }

        public bool VerticalHorizontalMovement(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable)
        {
            int numberOfSquares = whereToMove[0] - pieceSelect[0];
            int lateralMovements = whereToMove[1] - pieceSelect[1];

            // Validation if they try to make movements not allowed 
            if (numberOfSquares != 0 && lateralMovements != 0) return false;


            // In each for loop, there is an if statement to validate that it is not a piece of the same team.
            if (numberOfSquares != 0)
            {
                if (numberOfSquares < 0)
                {
                    // For loop for upward movements.
                    for (int i = pieceSelect[0] - 1; i >= whereToMove[0]; i--)
                    {
                        if (actualTable[i, pieceSelect[1]].GetType() != typeof(EmptySpace) && !actualTable[i, pieceSelect[1]].IsPlayer1 && !actualTable[pieceSelect[0], pieceSelect[1]].IsPlayer1) return false;
                        if (actualTable[i, pieceSelect[1]].GetType() != typeof(EmptySpace) && actualTable[i, pieceSelect[1]].IsPlayer1 && actualTable[pieceSelect[0], pieceSelect[1]].IsPlayer1) return false;
                    }
                    return true;
                }

                // For loop for downward movements.
                for (int i = pieceSelect[0] + 1; i <= whereToMove[0]; i++)
                {
                    if (actualTable[i, pieceSelect[1]].GetType() != typeof(EmptySpace) && !actualTable[i, pieceSelect[1]].IsPlayer1) return false;
                    if (actualTable[i, pieceSelect[1]].GetType() != typeof(EmptySpace) && actualTable[i, pieceSelect[1]].IsPlayer1 && actualTable[pieceSelect[0], pieceSelect[1]].IsPlayer1) return false;
                }
                return true;
            }

            if (lateralMovements > 0)
            {
                // For loop for right movements.
                for (int i = pieceSelect[1] + 1; i <= whereToMove[1]; i++)
                {
                    if (actualTable[pieceSelect[0], i].GetType() != typeof(EmptySpace) && !actualTable[pieceSelect[0], i].IsPlayer1 && !actualTable[pieceSelect[0], pieceSelect[1]].IsPlayer1) return false;
                    if (actualTable[pieceSelect[0], i].GetType() != typeof(EmptySpace) && actualTable[pieceSelect[0], i].IsPlayer1 && actualTable[pieceSelect[0], pieceSelect[1]].IsPlayer1) return false;
                }
                return true;
            }

            // For loop for left movements.
            for (int i = pieceSelect[1] - 1; i >= whereToMove[1]; i--)
            {
                if (actualTable[pieceSelect[0], i].GetType() != typeof(EmptySpace) && !actualTable[pieceSelect[0], i].IsPlayer1) return false;
                if (actualTable[pieceSelect[0], i].GetType() != typeof(EmptySpace) && actualTable[pieceSelect[0], i].IsPlayer1 && actualTable[pieceSelect[0], pieceSelect[1]].IsPlayer1) return false;
            }
            return true;
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
