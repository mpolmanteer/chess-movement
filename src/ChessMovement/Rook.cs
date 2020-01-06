using System;
using System.Collections.Generic;

namespace ChessMovement
{
	public class Rook : IPiece
	{
		public bool IsWhite { get; set; }

		public Rook(bool isWhite)
		{
			IsWhite = isWhite;
		}

		public List<Location> GetValidMoves(Board board, Location location)
		{
			var validMoves = new List<Location>();
			bool? hasOpponent;

			//Move East
			if (location.File < (board.Size - 1))
			{				
				for (int file = location.File + 1; file < board.Size; file++)
				{
					hasOpponent = board.HasOpponent(IsWhite, new Location(file, location.Rank));

					if (hasOpponent == null)
					{
						validMoves.Add(new Location(file, location.Rank));
					}
					else
					{
						if (hasOpponent == true)
						{
							validMoves.Add(new Location(file, location.Rank));
						}
						break;
					}
				}
			}
			//List<Location> ExploreDirections(MoveDirectionEnum direction, short maxDistance)
			
			//Move North
			if (location.Rank < (board.Size - 1))
			{
				for (int rank = location.Rank + 1; rank < board.Size; rank++)
				{
					hasOpponent = board.HasOpponent(IsWhite, new Location(location.File, rank));

					if (hasOpponent == null)
					{
						validMoves.Add(new Location(location.File, rank));
					}
					else
					{
						if (hasOpponent == true)
						{
							validMoves.Add(new Location(location.File, rank));
						}
						break;
					}
				}
			}

			return validMoves;

		}
	}
}