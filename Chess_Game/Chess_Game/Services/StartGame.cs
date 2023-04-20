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

        public ChessPieces[,] Start()
        {
            CreateBoard createTable = new();
            ChessPieces[,] actualTable = createTable.Create();

            Console.WriteLine("Player 1 : Black");
            Console.WriteLine("Player 2 : White");
            Console.WriteLine("==================");

            ShowBoard.Show(actualTable);
            Thread.Sleep(2000);
            Console.Clear();

            return actualTable;
        }



    }


    
}
