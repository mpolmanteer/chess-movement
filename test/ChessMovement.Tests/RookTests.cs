using System;
using Xunit;

namespace ChessMovement.Tests
{
    public class RookTests
    {
        [Fact]
        public void RookA1EmptyBoard()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            var piece = new Rook(true,lateralMovement);
            var pieceLocation = new Location(0, 0);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 14);
        }

        [Fact]
        public void RookA1FriendToRight()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Rook(true, lateralMovement);
            var pieceLocation = new Location(0, 0);
            board.Grid[0, 1].Piece = new King(true, lateralMovement, diagonalMovement);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 7);
        }

        [Fact]
        public void RookA1FoeToRight()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Rook(true, lateralMovement);
            var pieceLocation = new Location(0, 0);
            board.Grid[0, 1].Piece = new King(false, lateralMovement, diagonalMovement);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 8);
        }
    }
}
