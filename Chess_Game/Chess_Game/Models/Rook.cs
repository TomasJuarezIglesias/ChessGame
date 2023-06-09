﻿using Chess_Game.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    public class Rook : IPiece , IVerticalHorizontalMovement
    {
        public  string? Piece { get; set; } = "\u2656";

        // if it changes color to white it is because it belongs to another player
        public  bool IsPlayer1 { get; set; } = false;

        public Rook(bool isBlack)
        {
            if (!isBlack)
            {
                Piece = "\u265C";
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
            return VerticalHorizontalMovement(pieceSelect, whereToMove,actualTable);
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
    }
}
