using System;
using Xunit;

namespace ChessMovement.Tests
{
    public class PieceFactoryTests
    {
        [Fact]
        public void BishopCapital()
        {
            var piece = PieceFactory.CreatePiece("Bishop",true);
            Assert.True(piece is Bishop);
        }

        [Fact]
        public void BishopLowerCase()
        {
            var piece = PieceFactory.CreatePiece("bishop", true);
            Assert.True(piece is Bishop);
        }
        [Fact]
        public void KingCapital()
        {
            var piece = PieceFactory.CreatePiece("King", true);
            Assert.True(piece is King);
        }

        [Fact]
        public void KingLowerCase()
        {
            var piece = PieceFactory.CreatePiece("king", true);
            Assert.True(piece is King);
        }
        [Fact]
        public void KnightCapital()
        {
            var piece = PieceFactory.CreatePiece("Knight", true);
            Assert.True(piece is Knight);
        }

        [Fact]
        public void KnightLowerCase()
        {
            var piece = PieceFactory.CreatePiece("knight", true);
            Assert.True(piece is Knight);
        }
        [Fact]
        public void PawnCapital()
        {
            var piece = PieceFactory.CreatePiece("Pawn", true);
            Assert.True(piece is Pawn);
        }

        [Fact]
        public void PawnLowerCase()
        {
            var piece = PieceFactory.CreatePiece("pawn", true);
            Assert.True(piece is Pawn);
        }
        [Fact]
        public void QueenCapital()
        {
            var piece = PieceFactory.CreatePiece("Queen", true);
            Assert.True(piece is Queen);
        }

        [Fact]
        public void QueenLowerCase()
        {
            var piece = PieceFactory.CreatePiece("queen", true);
            Assert.True(piece is Queen);
        }
        [Fact]
        public void RookCapital()
        {
            var piece = PieceFactory.CreatePiece("Rook", true);
            Assert.True(piece is Rook);
        }

        [Fact]
        public void RookLowerCase()
        {
            var piece = PieceFactory.CreatePiece("rook", true);
            Assert.True(piece is Rook);
        }
        [Fact]
        public void InvalidValue()
        {
            IPiece piece;
            Assert.Throws<ArgumentException>(() => piece = PieceFactory.CreatePiece("Piece", true));
        }
        [Fact]
        public void BlankValue()
        {
            IPiece piece;
            Assert.Throws<ArgumentException>(() => piece = PieceFactory.CreatePiece("", true));
        }
    }
}
