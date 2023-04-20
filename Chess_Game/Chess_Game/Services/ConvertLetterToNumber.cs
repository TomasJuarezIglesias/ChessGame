using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class ConvertLetterToNumber
    {

        // Here the index of the letter is obtained and returned with +1 to obtain the actual value needed for the matrix
        public static string ConvertLetter(string response)
        {
            string[] words = { "a", "b", "c", "d", "e", "f", "g", "h" };

            var word = words.Select((letter, i) => (letter, i))
                            .FirstOrDefault(x => x.letter == response)
                            .i;

            return $"{word + 1}";
        }
    }
}
