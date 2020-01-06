using System;
using System.Collections.Generic;

namespace ChessMovement
{
	public class Bishop : IPiece
	{
		public bool IsWhite { get; set; }
		private IDiagonalMovement diagonalMovement;
		public Bishop(bool isWhite, IDiagonalMovement diagonalMovement)
		{
			IsWhite = isWhite;
			this.diagonalMovement = diagonalMovement;
		}

		public List<Location> GetValidMoves(Board board, Location location)
		{
			throw new NotImplementedException();
		}
	}
}