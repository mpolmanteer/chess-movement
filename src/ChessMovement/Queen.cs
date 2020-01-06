using System;
using System.Collections.Generic;

namespace ChessMovement
{
    public class Queen : IPiece
    {
        public bool IsWhite { get; set; }
        private ILateralMovement lateralMovement;
        private IDiagonalMovement diagonalMovement;
        public Queen(bool isWhite, ILateralMovement lateralMovement, IDiagonalMovement diagonalMovement)
        {
            IsWhite = isWhite;
            this.lateralMovement = lateralMovement;
            this.diagonalMovement = diagonalMovement;
        }
        public List<Location> GetValidMoves(Board board, Location location)
        {
            var validMoves = new List<Location>();

            validMoves.AddRange(diagonalMovement.MoveNorthEast(board, location, IsWhite, board.Size));
            validMoves.AddRange(diagonalMovement.MoveNorthWest(board, location, IsWhite, board.Size));
            validMoves.AddRange(diagonalMovement.MoveSouthEast(board, location, IsWhite, board.Size));
            validMoves.AddRange(diagonalMovement.MoveSouthWest(board, location, IsWhite, board.Size));
            validMoves.AddRange(lateralMovement.MoveEast(board, location, IsWhite, board.Size));
            validMoves.AddRange(lateralMovement.MoveNorth(board, location, IsWhite, board.Size));
            validMoves.AddRange(lateralMovement.MoveWest(board, location, IsWhite, board.Size));
            validMoves.AddRange(lateralMovement.MoveSouth(board, location, IsWhite, board.Size));


            return validMoves;
        }
    }
}