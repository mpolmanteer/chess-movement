using System;
using System.Collections.Generic;

namespace ChessMovement
{
	public class Pawn : IPiece
	{
		public bool IsWhite { get; set; }

		public Pawn(bool isWhite)
		{
			IsWhite = isWhite;
		}

		public List<Location> GetValidMoves(Board board, Location location)
		{
			throw new NotImplementedException();
		}
	}
}