using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class ShowTable
    {
        public void Show(ChessPieces[,] table)
        {
            foreach (var item in table)
            {
                bool isNumber = int.TryParse(item.Piece, out int num);

                if (isNumber && int.Parse(item.Piece) != 8 || item.Piece == "=")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.OutputEncoding = Encoding.Unicode;
                Console.Write(item.Piece);

                Console.Write(' ');
            }
        }

    }
}
