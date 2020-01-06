using System;
using System.Collections.Generic;

namespace ChessMovement
{
	public class Knight : IPiece
	{
		public bool IsWhite { get; set; }

		public Knight(bool isWhite)
		{
			IsWhite = isWhite;
		}

		public List<Location> GetValidMoves(Board board, Location location)
		{
			throw new NotImplementedException();
		}
	}
}