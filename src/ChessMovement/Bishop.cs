using System;
using System.Collections.Generic;

namespace ChessMovement
{
	public class Bishop : IPiece
	{
		public bool IsWhite { get; set; }

		public Bishop(bool isWhite)
		{
			IsWhite = isWhite;
		}

		public List<Location> GetValidMoves(Board board, Location location)
		{
			throw new NotImplementedException();
		}
	}
}