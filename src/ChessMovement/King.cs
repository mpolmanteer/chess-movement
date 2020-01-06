using System;
using System.Collections.Generic;

namespace ChessMovement
{
	public class King : IPiece
	{
		public bool IsWhite { get; set; }
		public King(bool isWhite)
		{
			IsWhite = isWhite;
		}

		public List<Location> GetValidMoves(Board board, Location location)
		{
			var moves = new List<Location>();
			return moves;
		}
	}
}