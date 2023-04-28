using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Horse : IPiece
    {
        public  string? Piece { get; set; } = "\u2658";

        // if it changes color to white it is because it belongs to another player
        public bool IsPlayer1 { get; set; } = false;
        public Horse(bool isBlack)
        {
            if (!isBlack)
            {
                Piece = "\u265E";
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
            int numberOfSquares = whereToMove[0] - pieceSelect[0];
            int lateralMovements = whereToMove[1] - pieceSelect[1];
            bool movementIsOK = false;

            // Here a first general validation is made.
            if (numberOfSquares > 2 && numberOfSquares < -2 || lateralMovements > 2 && numberOfSquares < -2) return false;

            // All these validations are for each of the movement possibilities of the horse.
            if (numberOfSquares == 2 && lateralMovements == 1 || numberOfSquares == 2 && lateralMovements == -1) movementIsOK = true;
            
            if (numberOfSquares == -2 && lateralMovements == 1 || numberOfSquares == -2 && lateralMovements == -1) movementIsOK = true;

            if (lateralMovements == 2 && numberOfSquares == 1 || lateralMovements == 2 && numberOfSquares == -1) movementIsOK = true;

            if (lateralMovements == -2 && numberOfSquares == 1 || lateralMovements == -2 && numberOfSquares == -1) movementIsOK = true;

            if (!movementIsOK) return false;

            // This validation is to check if it is a piece of its own team.
            if (actualTable[pieceSelect[0], pieceSelect[1]].IsPlayer1 == actualTable[whereToMove[0], whereToMove[1]].IsPlayer1 
                && actualTable[whereToMove[0], whereToMove[1]].GetType() != typeof(EmptySpace))
            {
                return false;
            }

            return true;
        }
    }
}
