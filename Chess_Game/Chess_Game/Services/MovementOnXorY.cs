using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class MovementOnXorY
    {
        public bool Movement(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable)
        {
            int numberOfSquares = whereToMove[0] - pieceSelect[0];
            int lateralMovements = whereToMove[1] - pieceSelect[1];

            // Validation if they try to make movements not allowed by the tower 
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

    }
}
