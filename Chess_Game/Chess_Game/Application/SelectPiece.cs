using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Application
{
    public class SelectPiece
    {
        // Method for selecting a piece and where to move by coordinates.
        public SelectPiece()
        {
            input = new();
        }
        Input_VerificationValues input;
   
        bool canContinue = false;
        public int[] SelectPieceToMove(IPiece[,] actualTable, Player thePlayer)
        {
            
            string text = "the piece";
            int[] coordinates = input.InputVerificationOfValues(actualTable, text, thePlayer.NumPlayer.ToString());

            // the coordinates of the selected piece are added
            thePlayer.AddCurrentPiece(coordinates[0], coordinates[1]);
            // validation to see if the piece belongs to the player
            canContinue = PieceValidationForPlayer.Validate(actualTable, thePlayer);

            if (!canContinue) return SelectPieceToMove(actualTable, thePlayer);

            return coordinates; 
        }

        public int[] WhereToMove(IPiece[,] actualTable, string playerTurn)
        {
            string text = "where to move";

            int[] coordinates = input.InputVerificationOfValues(actualTable, text, playerTurn);

            return coordinates;
        }

    }
}
