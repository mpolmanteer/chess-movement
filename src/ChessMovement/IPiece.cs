using System;
using System.Collections.Generic;

namespace ChessMovement
{
    public interface IPiece
    {
        bool IsWhite { get; set; }
        List<Location> GetValidMoves(Board board, Location location);
    }

}
