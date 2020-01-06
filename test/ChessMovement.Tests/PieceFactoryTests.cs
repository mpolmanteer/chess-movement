using System;
using Xunit;

namespace ChessMovement.Tests
{
    public class PieceFactoryTests
    {
        [Fact]
        public void BishopCapital()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("Bishop", true);

            Assert.True(piece is Bishop);
        }

        [Fact]
        public void BishopLowerCase()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("bishop", true);

            Assert.True(piece is Bishop);
        }
        [Fact]
        public void KingCapital()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("King", true);

            Assert.True(piece is King);
        }

        [Fact]
        public void KingLowerCase()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("king", true);

            Assert.True(piece is King);
        }
        [Fact]
        public void KnightCapital()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("Knight", true);

            Assert.True(piece is Knight);
        }

        [Fact]
        public void KnightLowerCase()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("knight", true);

            Assert.True(piece is Knight);
        }
        [Fact]
        public void PawnCapital()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("Pawn", true);

            Assert.True(piece is Pawn);
        }

        [Fact]
        public void PawnLowerCase()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("pawn", true);

            Assert.True(piece is Pawn);
        }
        [Fact]
        public void QueenCapital()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("Queen", true);

            Assert.True(piece is Queen);
        }

        [Fact]
        public void QueenLowerCase()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("queen", true);

            Assert.True(piece is Queen);
        }

        [Fact]
        public void RookCapital()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("Rook", true);

            Assert.True(piece is Rook);
        }

        [Fact]
        public void RookLowerCase()
        {
            var pieceFactory = new PieceFactory();

            var piece = pieceFactory.CreatePiece("rook", true);

            Assert.True(piece is Rook);
        }

        [Fact]
        public void InvalidValue()
        {
            IPiece piece;
            var pieceFactory = new PieceFactory();

            Assert.Throws<ArgumentException>(() => piece = pieceFactory.CreatePiece("Piece", true));
        }

        [Fact]
        public void BlankValue()
        {
            IPiece piece;
            var pieceFactory = new PieceFactory();

            Assert.Throws<ArgumentException>(() => piece = pieceFactory.CreatePiece("", true));
        }
    }
}
