using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class Input_VerificationValues
    {

        // Reusable method for taking data during the player's turn
        bool canContinue = false;
        public int[] InputVerificationOfValues(ChessPieces[,] actualTable, string txt)
        {
            Console.Clear();
            Console.WriteLine("==================");
            ShowBoard.Show(actualTable);
            Console.WriteLine("==================");
            Console.WriteLine($"Enter the X-coordinate to choose {txt}: ");
            string? responseX = Console.ReadLine();

            // Here the input string is validated
            canContinue = LetterValidation.Validate(responseX);
            if (!canContinue)
            {
                return InputVerificationOfValues(actualTable,txt);
            }

            responseX = ConvertLetterToNumber.ConvertLetter(responseX);
            Console.WriteLine($"Enter the Y-coordinate to choose {txt}: ");
            string? responseY = Console.ReadLine();

            // Here the int input is validated
            canContinue = NumberValidation.Validate(responseY);
            if (!canContinue)
            {
                return InputVerificationOfValues(actualTable,txt);
            }


            int[] coordinates = { int.Parse(responseX), int.Parse(responseY) };
            return coordinates;
        }

    }
}
