using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class StartGame
    {
        // This method creates the board and displays which player is going to be each one.
        public IPiece[,] Start()
        {
            CreateBoard createTable = new();
            IPiece[,] actualTable = createTable.Create();

            Console.WriteLine("Player 1 : Black");
            Console.WriteLine("Player 2 : White");
            Console.WriteLine("==================");
            ShowBoard.Show(actualTable);
            Console.WriteLine("==================");

            Thread.Sleep(5000);
            Console.Clear();

            return actualTable;
        }



    }


    
}
