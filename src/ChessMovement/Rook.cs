using System;
using System.Collections.Generic;

namespace ChessMovement
{
	public class Rook : IPiece
	{
		public bool IsWhite { get; set; }
		private ILateralMovement _lateralMovement;

		public Rook(bool isWhite, ILateralMovement lateralMovement)
		{
			IsWhite = isWhite;
			_lateralMovement = lateralMovement;
		}

		public List<Location> GetValidMoves(Board board, Location location)
		{
			var validMoves = new List<Location>();

			validMoves.AddRange(_lateralMovement.MoveEast(board, location, IsWhite, board.Size));
			validMoves.AddRange(_lateralMovement.MoveNorth(board, location, IsWhite, board.Size));
			//validMoves.AddRange(_lateralMovement.MoveWest(board, location, IsWhite, board.Size));
			//validMoves.AddRange(_lateralMovement.MoveSouth(board, location, IsWhite, board.Size));

			return validMoves;

		}
	}
}