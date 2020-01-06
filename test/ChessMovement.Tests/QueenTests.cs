using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChessMovement.Tests
{
    public class QueenTests
    {
        [Fact]
        public void QueenA1EmptyBoard()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Queen(true, lateralMovement, diagonalMovement);
            var pieceLocation = new Location(0, 0);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 21);
        }

        [Fact]
        public void QueenA1SurroundedFriend()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Queen(true, lateralMovement, diagonalMovement);
            var pieceLocation = new Location(0, 0);
            board.AddPieceToSquare(new King(true, lateralMovement, diagonalMovement), new Location(1, 0));
            board.AddPieceToSquare(new King(true, lateralMovement, diagonalMovement), new Location(1, 1));
            board.AddPieceToSquare(new King(true, lateralMovement, diagonalMovement), new Location(0, 1));

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 0);
        }

        [Fact]
        public void QueenA1SurroundedFoe()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Queen(true, lateralMovement, diagonalMovement);
            var pieceLocation = new Location(0, 0);
            board.AddPieceToSquare(new King(false, lateralMovement, diagonalMovement), new Location(1, 0));
            board.AddPieceToSquare(new King(false, lateralMovement, diagonalMovement), new Location(1, 1));
            board.AddPieceToSquare(new King(false, lateralMovement, diagonalMovement), new Location(0, 1));

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 3);
        }

        [Fact]
        public void QueenA8EmptyBoard()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Queen(true, lateralMovement, diagonalMovement);
            var pieceLocation = new Location(0, 7);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 21);
        }

        [Fact]
        public void QueenH8EmptyBoard()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Queen(true, lateralMovement, diagonalMovement);
            var pieceLocation = new Location(7, 7);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 21);
        }

        [Fact]
        public void QueenH1EmptyBoard()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Queen(true, lateralMovement, diagonalMovement);
            var pieceLocation = new Location(7, 0);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 21);
        }

        [Fact]
        public void QueenD3EmptyBoard()
        {
            Board board = new Board(8);
            ILateralMovement lateralMovement = new LateralMovement();
            IDiagonalMovement diagonalMovement = new DiagnalMovement();
            var piece = new Queen(true, lateralMovement, diagonalMovement);
            var pieceLocation = new Location(3, 2);

            int validMovesCount = piece.GetValidMoves(board, pieceLocation).Count;

            Assert.True(validMovesCount == 25);
        }
    }
}
