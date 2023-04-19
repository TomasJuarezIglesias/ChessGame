using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class CreateTable
    {
        public ChessPieces[,] Create()
        {
            ChessPieces[,] table =
            {
                { new TableCoordinates("8"), new Tower(true), new Horse(true), new Bishop(true), new Queen(true), new King(true), new Bishop(true), new Horse(true), new Tower(true) },
                { new TableCoordinates("7"), new Pawn(true), new Pawn(true) , new Pawn(true), new Pawn(true), new Pawn(true), new Pawn(true), new Pawn(true), new Pawn(true) },
                { new TableCoordinates("6"), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace() },
                { new TableCoordinates("5"), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace() },
                { new TableCoordinates("4"), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace() },
                { new TableCoordinates("3"), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace() },
                { new TableCoordinates("2"), new Pawn(false), new Pawn(false) , new Pawn(false), new Pawn(false), new Pawn(false), new Pawn(false), new Pawn(false), new Pawn(false) },
                { new TableCoordinates("1"), new Tower(false), new Horse(false), new Bishop(false), new Queen(false), new King(false), new Bishop(false), new Horse(false), new Tower(false) },
                { new TableCoordinates("="), new TableCoordinates("A"), new TableCoordinates("B"), new TableCoordinates("C"), new TableCoordinates("D"), new TableCoordinates("E"), new TableCoordinates("F"), new TableCoordinates("G"), new TableCoordinates("H") },


            };


            return table;
        }
    }
}
