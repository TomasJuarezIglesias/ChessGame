using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class LetterValidation
    {

        // Here the input string is validated
        public static bool Validate(string? response)
        {
            string[] words = { "a", "b", "c", "d", "e", "f", "g", "h" };
            if (response == null) 
            {
                Console.Clear();
                Console.WriteLine("Invalid coordinate");
                return false; 
            }

            
            foreach (var item in words)
            {
                if (item.ToLower() == response.ToLower()) { return true; }
            }

            Console.Clear();
            Console.WriteLine("Invalid coordinate");
            return false;

        }

    }
}
