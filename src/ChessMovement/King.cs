using System;
using System.Collections.Generic;

namespace ChessMovement
{
	public class King : IPiece
	{
		public bool IsWhite { get; set; }
		private ILateralMovement lateralMovement;
		private IDiagonalMovement diagonalMovement;
		public King(bool isWhite, ILateralMovement lateralMovement, IDiagonalMovement diagonalMovement)
		{
			IsWhite = isWhite;
			this.lateralMovement = lateralMovement;
			this.diagonalMovement = diagonalMovement;
		}

		public List<Location> GetValidMoves(Board board, Location location)
		{
			var moves = new List<Location>();
			return moves;
		}
	}
}