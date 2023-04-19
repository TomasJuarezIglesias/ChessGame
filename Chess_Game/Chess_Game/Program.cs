using Chess_Game.Services;
using System;

namespace Chess_Game // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreateTable table = new CreateTable();
            ShowTable tableShow = new ShowTable();
            tableShow.Show(table.Create());



            Console.ReadLine();

        }
    }
}
