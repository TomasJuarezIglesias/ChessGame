using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Application
{
    public class Input_VerificationValues
    {
        public Input_VerificationValues()
        {
            inputValidations = new();
        }
        InputValidations inputValidations;
        // Reusable method for taking data during the player's turn
        bool canContinue = false;
        public int[] InputVerificationOfValues(IPiece[,] actualTable, string txt, string playerTurn)
        {
            Console.Clear();
            Console.WriteLine($"It is player {playerTurn} turn");
            Console.WriteLine("==================");
            ShowBoard.Show(actualTable);
            Console.WriteLine("==================");
            Console.WriteLine($"Enter the X-coordinate to choose {txt}: ");
            string? responseX = Console.ReadLine();

            // Here the input string is validated
            canContinue = inputValidations.ValidateLetter(responseX);

            if (!canContinue)return InputVerificationOfValues(actualTable, txt, playerTurn);

            responseX = inputValidations.ConvertLetter(responseX);
            Console.WriteLine($"Enter the Y-coordinate to choose {txt}: ");
            string? responseY = Console.ReadLine();

            // Here the int input is validated
            canContinue = inputValidations.ValidateNumber(responseY);

            if (!canContinue) return InputVerificationOfValues(actualTable, txt, playerTurn);

            int[] coordinates = {  int.Parse(responseY) - 1, int.Parse(responseX)};
            return coordinates;
        }

    }
}
