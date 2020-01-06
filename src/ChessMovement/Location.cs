using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMovement
{
    public class Location
    {
        public int Rank { get; set; }
        public int File { get; set; }

        public Location(int file, int rank)
        {
            Rank = rank;
            File = file;
        }
    }
}
