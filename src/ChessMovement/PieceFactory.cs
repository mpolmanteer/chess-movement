using System;

namespace ChessMovement
{
	public class PieceFactory
	{
		private ILateralMovement lateralMovement = new LateralMovement();
		private IDiagonalMovement diagonalMovement = new DiagnalMovement();
		private ILateralMovement pawnLateralMovement = new PawnLateralMovement();
		private IDiagonalMovement pawnDiagonalMovement = new PawnDiagonalMovement();

		public PieceFactory()
		{
		}
		public IPiece CreatePiece(string pieceType, bool isWhite)
		{
			if (pieceType == "King" || pieceType == "king")
			{
				return new King(isWhite, lateralMovement, diagonalMovement);
			}
			else if (pieceType == "Queen" || pieceType == "queen")
			{
				return new Queen(isWhite, lateralMovement, diagonalMovement);
			}
			else if (pieceType == "Rook" || pieceType == "rook")
			{
				return new Rook(isWhite, lateralMovement);
			}
			else if (pieceType == "Bishop" || pieceType == "bishop")
			{
				return new Bishop(isWhite, diagonalMovement);
			}
			else if (pieceType == "Knight" || pieceType == "knight")
			{
				return new Knight(isWhite);
			}
			else if (pieceType == "Pawn" || pieceType == "pawn")
			{
				return new Pawn(isWhite, pawnLateralMovement, pawnDiagonalMovement);
			}
			else 
			{
				throw new ArgumentException("Invalid Piece");
			}
		}
	}
}