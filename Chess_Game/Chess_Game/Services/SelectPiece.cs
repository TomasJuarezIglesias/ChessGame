using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class SelectPiece
    {
        // Method for selecting a piece by coordinates.
        bool canContinue = false;
        public int[] SelectPieceToMove(IPiece[,] actualTable, Player thePlayer)
        {
            Input_VerificationValues input = new();
            string text = "the piece";
            int[] coordinates = input.InputVerificationOfValues(actualTable, text, thePlayer.NumPlayer.ToString());

            // the coordinates of the selected piece are added
            thePlayer.AddCurrentPiece(coordinates[0], coordinates[1]);
            // validation to see if the piece belongs to the player
            canContinue = PieceValidationForPlayer.Validate(actualTable, thePlayer);

            if (!canContinue) return SelectPieceToMove(actualTable, thePlayer);

            return coordinates; 
        }

    }
}
