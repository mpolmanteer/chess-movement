using System;
using System.Collections.Generic;

namespace ChessMovement
{
	public class Pawn : IPiece
	{
		public bool IsWhite { get; set; }
		private ILateralMovement lateralMovement;
		private IDiagonalMovement diagonalMovement;
		public Pawn(bool isWhite, ILateralMovement lateralMovement, IDiagonalMovement diagonalMovement)
		{
			IsWhite = isWhite;
			this.lateralMovement = lateralMovement;
			this.diagonalMovement = diagonalMovement;
		}

		public List<Location> GetValidMoves(Board board, Location location)
		{
			throw new NotImplementedException();
		}
	}
}