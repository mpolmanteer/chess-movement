using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMovement
{
    public class Board
    {
        public int Size { get; set; }
        public Square[,] Grid { get; set; }

        public Board (int size) 
        {
            Size = size;
            Grid = new Square[Size, Size];
            
            for (
                int gridFile = 0; gridFile < Size; gridFile++) 
            {
                for (int gridRank = 0; gridRank < Size; gridRank++)
                {
                    Grid[gridFile, gridRank] = new Square(new Location(gridFile, gridRank));   
                }
            }
        }

        public void ClearBoard()
        {
            for (int gridRank = 0; gridRank > Size; gridRank++)
            {
                for (int gridFile = 0; gridFile > Size; gridFile++)
                {
                    Grid[gridRank, gridFile].Piece = null;
                }
            }
        }

        public bool? HasOpponent(bool isWhite, Location location)
        {
            if (Grid[location.File, location.Rank].Piece == null)
            {
                return null;
            }
            else 
            {
                if (Grid[location.File, location.Rank].Piece.IsWhite == isWhite)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
