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
			var validMoves = new List<Location>();

			validMoves.AddRange(diagonalMovement.MoveNorthEast(board, location, IsWhite, board.Size));
			validMoves.AddRange(diagonalMovement.MoveNorthWest(board, location, IsWhite, board.Size));
			validMoves.AddRange(diagonalMovement.MoveSouthEast(board, location, IsWhite, board.Size));
			validMoves.AddRange(diagonalMovement.MoveSouthWest(board, location, IsWhite, board.Size));

			return validMoves;

		}
	}
}