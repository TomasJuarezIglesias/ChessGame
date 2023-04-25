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
        // Here we have the call to methods to carry out the respective processes of each player's turn

        SelectPiece selectPiece = new();
        SelectWhereToMove selectWhereToMove = new();
        MovePiece movePiece = new();
        public IPiece[,] StartTurn(IPiece[,] actualTable, Player thePlayer)
        {
            // Here I obtain the coordinates of the piece selected by the player.
            int[] coordinatesPieceSelect = selectPiece.SelectPieceToMove(actualTable, thePlayer);
            // Here I obtain where the player wants to move that piece.
            int[] coordinatesWhereToMove = selectWhereToMove.WhereToMove(actualTable, thePlayer.NumPlayer.ToString());

            // It validates if the same coordinate has been entered for both, the selected piece and the destination to move.
            if (coordinatesPieceSelect == coordinatesWhereToMove) return StartTurn(actualTable, thePlayer);

            // Here the movement of the piece is made and if it captures any piece from the opposite team.
            var movement = movePiece.Move(coordinatesPieceSelect, coordinatesWhereToMove, actualTable);

            if(movement == null) return StartTurn(actualTable, thePlayer);

            actualTable = movement;

            return actualTable;
        }

    }
}
