using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMovement
{
    public interface ILateralMovement
    {
        List<Location> MoveEast(Board board, Location location, bool isWhite, int maxMoves);
        List<Location> MoveNorth(Board board, Location location, bool isWhite, int maxMoves);
        List<Location> MoveWest(Board board, Location location, bool isWhite, int maxMoves);
        List<Location> MoveSouth(Board board, Location location, bool isWhite, int maxMoves);
    }
}
