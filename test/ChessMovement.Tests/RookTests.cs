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
            var piece = new Rook(true);
            var pieceLocation = new Location(0, 0);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 14);
        }

        [Fact]
        public void RookA1FriendToRight()
        {
            Board board = new Board(8);
            var piece = new Rook(true);
            var pieceLocation = new Location(0, 0);
            board.Grid[0, 1].Piece = new King(true);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 7);
        }

        [Fact]
        public void RookA1FoeToRight()
        {
            Board board = new Board(8);
            var piece = new Rook(true);
            var pieceLocation = new Location(0, 0);
            board.Grid[0, 1].Piece = new King(false);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 8);
        }
    }
}
