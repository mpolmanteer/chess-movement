using System;

namespace ChessMovement
{
	public static class PieceFactory
	{
		public static IPiece CreatePiece(string pieceType, bool isWhite)
		{
			if (pieceType == "King" || pieceType == "king")
			{
				return new King(isWhite);
			}
			else if (pieceType == "Queen" || pieceType == "queen")
			{
				return new Queen(isWhite);
			}
			else if (pieceType == "Rook" || pieceType == "rook")
			{
				return new Rook(isWhite);
			}
			else if (pieceType == "Bishop" || pieceType == "bishop")
			{
				return new Bishop(isWhite);
			}
			else if (pieceType == "Knight" || pieceType == "knight")
			{
				return new Knight(isWhite);
			}
			else if (pieceType == "Pawn" || pieceType == "pawn")
			{
				return new Pawn(isWhite);
			}
			else 
			{
				throw new ArgumentException("Invalid Piece");
			}
		}
	}
}