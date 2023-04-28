using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Application
{
    public class ShowBoard
    {
        // This method is used to show the board
        public static void Show(IPiece[,] board)
        {
            foreach (var item in board)
            {
                bool isNumber = int.TryParse(item.Piece, out int num);

                if (isNumber && int.Parse(item.Piece) != 1 || item.Piece == "=")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.OutputEncoding = Encoding.Unicode;
                Console.Write(item.Piece);

                Console.Write(' ');
            }
            
            Console.WriteLine();
        }

    }
}
