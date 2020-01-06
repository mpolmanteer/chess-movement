using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMovement
{
    public interface IDiagonalMovement
    {
        List<Location> MoveNorthEast(Board board, Location location, int maxMoves);
        List<Location> MoveNorthWest(Board board, Location location, int maxMoves);
        List<Location> MoveSouthWest(Board board, Location location, int maxMoves);
        List<Location> MoveSouthEast(Board board, Location location, int maxMoves);
    }
}
