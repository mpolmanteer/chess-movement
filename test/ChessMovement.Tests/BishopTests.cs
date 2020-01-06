using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChessMovement.Tests
{
    public class BishopTests
    {
        [Fact]
        public void BishopA1EmptyBoard()
        {
            Board board = new Board(8);
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Bishop(true, diagonalMovement);
            var pieceLocation = new Location(0, 0);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 7);
        }

        [Fact]
        public void BishopA8EmptyBoard()
        {
            Board board = new Board(8);
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Bishop(true, diagonalMovement);
            var pieceLocation = new Location(0, 7);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 7);
        }

        [Fact]
        public void BishopH8EmptyBoard()
        {
            Board board = new Board(8);
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Bishop(true, diagonalMovement);
            var pieceLocation = new Location(7, 7);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 7);
        }

        [Fact]
        public void BishopH1EmptyBoard()
        {
            Board board = new Board(8);
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Bishop(true, diagonalMovement);
            var pieceLocation = new Location(7, 0);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 7);
        }

        [Fact]
        public void BishopA1Friend()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Bishop(true, diagonalMovement);
            var pieceLocation = new Location(0, 0);
            board.AddPieceToSquare(new King(true, lateralMovement, diagonalMovement), new Location(1, 1));

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 0);
        }

        [Fact]
        public void BishopA1Foe()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Bishop(true, diagonalMovement);
            var pieceLocation = new Location(0, 0);
            board.AddPieceToSquare(new King(false, lateralMovement, diagonalMovement), new Location(1, 1));

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 1);
        }

        [Fact]
        public void BishopD3EmptyBoard()
        {
            Board board = new Board(8);
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Bishop(true, diagonalMovement);
            var pieceLocation = new Location(3, 2);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 11);
        }
    }
}
