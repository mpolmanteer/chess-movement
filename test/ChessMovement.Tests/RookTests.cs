using System;
using System.Collections.Generic;
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
            board.AddPieceToSquare(new King(true, lateralMovement, diagonalMovement), new Location(1, 0));

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 7);
        }

        [Fact]
        public void RookA1FoeToRight()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            board.AddPieceToSquare(new King(false, lateralMovement, diagonalMovement), new Location(1, 0));
            var piece = new Rook(true, lateralMovement);
            var pieceLocation = new Location(0, 0);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 8);
        }

        [Fact]
        public void RookA1SurroundedByFriend()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            board.AddPieceToSquare(new King(true, lateralMovement, diagonalMovement), new Location(1, 0));
            board.AddPieceToSquare(new Queen(true, lateralMovement, diagonalMovement), new Location(0, 1));
            var piece = new Rook(true, lateralMovement);
            var pieceLocation = new Location(0, 0);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 0);
        }

        [Fact]
        public void RookA1SurroundedByFoe()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            board.AddPieceToSquare(new King(false, lateralMovement, diagonalMovement), new Location(1, 0));
            board.AddPieceToSquare(new Queen(false, lateralMovement, diagonalMovement), new Location(0, 1));
            var piece = new Rook(true, lateralMovement);
            var pieceLocation = new Location(0, 0);

            List<Location> validMoves = piece.GetValidMoves(board, pieceLocation);
            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.Equal("b1, a2", Location.GetAvailableLocations(validMoves));
            Assert.True(validMovesCount == 2);
        }

        [Fact]
        public void RookD3EmptyBoard()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Rook(true, lateralMovement);
            var pieceLocation = new Location(3, 2);

            List<Location> validMoves = piece.GetValidMoves(board, pieceLocation);
            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.Equal("e3, f3, g3, h3, d4, d5, d6, d7, d8, c3, b3, a3, d2, d1", Location.GetAvailableLocations(validMoves));
            Assert.True(validMovesCount == 14);
        }

        [Fact]
        public void RookA8EmptyBoard()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            var piece = new Rook(true, lateralMovement);
            var pieceLocation = new Location(0, 7);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 14);
        }

        [Fact]
        public void RookH8EmptyBoard()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            var piece = new Rook(true, lateralMovement);
            var pieceLocation = new Location(7, 7);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 14);
        }

        [Fact]
        public void RookH1EmptyBoard()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();

            var piece = new Rook(true, lateralMovement);
            var pieceLocation = new Location(7, 0);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 14);
        }
    }
}
