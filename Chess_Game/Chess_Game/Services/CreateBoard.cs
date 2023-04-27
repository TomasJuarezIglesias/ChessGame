using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Services
{
    public class CreateBoard
    {
        // here the board is created to start the game
        public IPiece[,] Create()
        {
            IPiece[,] table =
            {
                { new BoardCoordinates("1"), new Rook(true), new Horse(true), new Bishop(true), new Queen(true), new King(true), new Bishop(true), new Horse(true), new Rook(true) },
                { new BoardCoordinates("2"), new Pawn(true), new Pawn(true) , new Pawn(true), new Pawn(true), new Pawn(true), new Pawn(true), new Pawn(true), new Pawn(true) },
                { new BoardCoordinates("3"), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace() },
                { new BoardCoordinates("4"), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace() },
                { new BoardCoordinates("5"), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace() },
                { new BoardCoordinates("6"), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace(), new EmptySpace() },
                { new BoardCoordinates("7"), new Pawn(false), new Pawn(false) , new Pawn(false), new Pawn(false), new Pawn(false), new Pawn(false), new Pawn(false), new Pawn(false) },
                { new BoardCoordinates("8"), new Rook(false), new Horse(false), new Bishop(false), new Queen(false), new King(false), new Bishop(false), new Horse(false), new Rook(false) },
                { new BoardCoordinates("="), new BoardCoordinates("A"), new BoardCoordinates("B"), new BoardCoordinates("C"), new BoardCoordinates("D"), new BoardCoordinates("E"), new BoardCoordinates("F"), new BoardCoordinates("G"), new BoardCoordinates("H") },


            };


            return table;
        }
    }
}
