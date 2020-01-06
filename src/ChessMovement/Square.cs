using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMovement
{
    public class Square
    {
        public Location Location { get; set; }
        public IPiece Piece { get; set; }

        public Square(Location location) 
        {
            Location = location;
            Piece = null;
        }
    }
}
