using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class NumberValidation
    {
        // Here the int input is validated
        public static bool Validate(string? response)
        {
            if (response == null) 
            {
                Console.Clear();
                Console.WriteLine("Invalid coordinate");
                return false; 
            }

            bool canParse = int.TryParse(response, out int value);

            if (!canParse) 
            {
                Console.Clear();
                Console.WriteLine("Invalid coordinate");
                return false; 
            }

            if (int.Parse(response) < 1 || int.Parse(response) > 9)
            {
                Console.Clear();
                Console.WriteLine("Invalid coordinate");
                return false;
            }

            return true;

        }
    }
}
