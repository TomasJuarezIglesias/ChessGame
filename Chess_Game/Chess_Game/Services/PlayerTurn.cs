using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class PlayerTurn
    {
        // Here we will only use the index.
        bool canContinue = false;

        SelectPiece selectPiece = new();
        SelectWhereToMove selectWhereToMove = new();
        public ChessPieces[,] StartTurn(ChessPieces[,] actualTable, Player thePlayer)
        {

            int[] coordinatesPieceSelect = selectPiece.SelectPieceToMove(actualTable, thePlayer);

            int[] coordinatesWhereToMove = selectWhereToMove.WhereToMove(actualTable);



            return actualTable;
        }

    }
}
