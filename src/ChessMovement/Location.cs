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

        public static Location ParseChessNotation(string notation) 
        {
            Location parsedLocation;
            try
            {
                var file = notation.Substring(0, 1);
                var rank = notation.Substring(1, 1);
                int tempRank = (int)(int.Parse(rank) - 1);

                if (file == "a")
                {
                    parsedLocation = new Location(0, tempRank);
                }
                else if (file == "b")
                {
                    parsedLocation = new Location(1, tempRank);
                }
                else if (file == "c")
                {
                    parsedLocation = new Location(2, tempRank);
                }
                else if (file == "d")
                {
                    parsedLocation = new Location(3, tempRank);
                }
                else if (file == "e")
                {
                    parsedLocation = new Location(4, tempRank);
                }
                else if (file == "f")
                {
                    parsedLocation = new Location(5, tempRank);
                }
                else if (file == "g")
                {
                    parsedLocation = new Location(6, tempRank);
                }
                else if (file == "h")
                {
                    parsedLocation = new Location(7, tempRank);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error parsing notation, please use values a-h and numbers 1-8.");
            }
            return parsedLocation;
        }

        private static string ConvertLocationToChessString(Location location)
        {
            string sLocation = "";

            if (location.File == 0)
            {
                sLocation = "a";
            }
            else if (location.File == 1)
            {
                sLocation = "b";
            }
            else if (location.File == 2)
            {
                sLocation = "c";
            }
            else if (location.File == 3)
            {
                sLocation = "d";
            }
            else if (location.File == 4)
            {
                sLocation = "e";
            }
            else if (location.File == 5)
            {
                sLocation = "f";
            }
            else if (location.File == 6)
            {
                sLocation = "g";
            }
            else if (location.File == 7)
            {
                sLocation = "h";
            }

            return sLocation + (location.Rank + 1).ToString();
        }

        public static string GetAvailableLocations(List<Location> locations)
        {
            string validMovesCSV = "";

            foreach (Location loc in locations)
            {
                if (validMovesCSV != "")
                {
                    validMovesCSV = validMovesCSV + ", ";
                }
                validMovesCSV = validMovesCSV + Location.ConvertLocationToChessString(loc);
            }

            return validMovesCSV;
        }
    }
}
