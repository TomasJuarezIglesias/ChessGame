using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Application
{
    public class InputValidations
    {
        // Here the input string is validated
        public bool ValidateLetter(string? response)
        {
            string[] words = { "a", "b", "c", "d", "e", "f", "g", "h" };
            if (response == null) 
            {
                Console.Clear();
                Console.WriteLine("Invalid coordinate");
                Thread.Sleep(1000);
                return false; 
            }

            
            foreach (var item in words)
            {
                if (item.ToLower() == response.ToLower()) return true; 
            }

            Console.Clear();
            Console.WriteLine("Invalid coordinate");
            Thread.Sleep(1000);
            return false;

        }

        // Here the index of the letter is obtained and returned with +1 to obtain the actual value needed for the matrix
        public string ConvertLetter(string response)
        {
            string[] words = { "a", "b", "c", "d", "e", "f", "g", "h" };

            var word = words.Select((letter, i) => (letter, i))
                            .FirstOrDefault(x => x.letter == response)
                            .i;

            return $"{word + 1}";
        }

        // Here the int input is validated
        public bool ValidateNumber(string? response)
        {
            if (response == null)
            {
                Console.Clear();
                Console.WriteLine("Invalid coordinate");
                Thread.Sleep(1000);
                return false;
            }

            bool canParse = int.TryParse(response, out _);

            if (!canParse)
            {
                Console.Clear();
                Console.WriteLine("Invalid coordinate");
                Thread.Sleep(1000);
                return false;
            }

            if (int.Parse(response) < 1 || int.Parse(response) > 9)
            {
                Console.Clear();
                Console.WriteLine("Invalid coordinate");
                Thread.Sleep(1000);
                return false;
            }

            return true;

        }
    }
}
