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

        public ChessPieces[,] StartTurn(ChessPieces[,] actualTable, Player thePlayer)
        {
            Console.WriteLine("==================");
            ShowBoard.Show(actualTable);
            Console.WriteLine("==================");
            Console.WriteLine("Put X coordinate to select the piece: ");
            string? responseX = Console.ReadLine();

            Console.WriteLine("Put Y coordinate to select the piece: ");
            string? responseY = Console.ReadLine();

            // the coordinates of the selected piece are added
            thePlayer.AddCurrentPiece(int.Parse(responseX), int.Parse(responseY));
            // validation to see if the piece belongs to the player
            bool canContinue = PieceValidationForPlayer.Validation(actualTable, thePlayer); 

            if (!canContinue)
            {
                return StartTurn(actualTable, thePlayer);
            }





            return actualTable;
        }

    }
}
