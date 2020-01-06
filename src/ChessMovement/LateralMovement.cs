using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMovement
{
    public class LateralMovement : ILateralMovement
    {
        public List<Location> MoveEast(Board board, Location location, bool isWhite, int maxMoves)
        {
			var validMoves = new List<Location>();

			SquareStatus hasOpponent;

			//Move East
			if (location.File < (board.Size - 1))
			{
				for (int file = location.File + 1; file < board.Size; file++)
				{
					hasOpponent = (SquareStatus)board.GetSquareStatus(isWhite, new Location(file, location.Rank));

					if (hasOpponent == SquareStatus.Empty)
					{
						validMoves.Add(new Location(file, location.Rank));
					}
					else
					{
						if (hasOpponent == SquareStatus.Foe)
						{
							validMoves.Add(new Location(file, location.Rank));
						}
						break;
					}
				}
			}

			return validMoves;
		}

        public List<Location> MoveNorth(Board board, Location location, bool isWhite, int maxMoves)
        {
			var validMoves = new List<Location>();

			SquareStatus hasOpponent;

			if (location.Rank < (board.Size - 1))
			{
				for (int rank = location.Rank + 1; rank < board.Size; rank++)
				{
					hasOpponent = (SquareStatus)board.GetSquareStatus(isWhite, new Location(location.File, rank));

					if (hasOpponent == SquareStatus.Empty)
					{
						validMoves.Add(new Location(location.File, rank));
					}
					else
					{
						if (hasOpponent == SquareStatus.Foe)
						{
							validMoves.Add(new Location(location.File, rank));
						}
						break;
					}
				}
			}

			return validMoves;
		}

        public List<Location> MoveSouth(Board board, Location location, bool isWhite, int maxMoves)
        {
            throw new NotImplementedException();
        }

        public List<Location> MoveWest(Board board, Location location, bool isWhite, int maxMoves)
        {
            throw new NotImplementedException();
        }
    }
}
