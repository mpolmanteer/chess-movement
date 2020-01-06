using System;
using System.Collections.Generic;

namespace ChessMovement
{
	public class Queen : IPiece
	{
		public bool IsWhite { get; set; }

		public Queen(bool isWhite)
		{
			IsWhite = isWhite;
		}
		public List<Location> GetValidMoves(Board board, Location location)
		{
			throw new NotImplementedException();
		}
	}
}