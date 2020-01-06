using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMovement
{
    public class LateralMovement : ILateralMovement
    {
        public List<Location> MoveEast(Board board, Location location, bool isWhite, int maxMoves)
        {
            var validMoves = new List<Location>();

            if (location.File >= (board.Size - 1))
            {
                return validMoves;
            }
            for (int file = location.File + 1; file < board.Size; file++)
            {
                try
                {
                    AddValidMoveToList(isWhite, file, location.Rank, validMoves, board);
                }
                catch (Exception e)
                {
                    break;
                }
            }

            return validMoves;
        }

        public List<Location> MoveNorth(Board board, Location location, bool isWhite, int maxMoves)
        {
            var validMoves = new List<Location>();

            SquareStatus targetSquareStatus;

            if (location.Rank >= (board.Size - 1))
            {
                return validMoves;
            }
            for (int rank = location.Rank + 1; rank < board.Size; rank++)
            {
                try
                {
                    AddValidMoveToList(isWhite, location.File, rank, validMoves, board);
                }
                catch (Exception e)
                {
                    break;
                }
            }

            return validMoves;
        }

        public List<Location> MoveSouth(Board board, Location location, bool isWhite, int maxMoves)
        {
            var validMoves = new List<Location>();

            SquareStatus targetSquareStatus;

            if (location.Rank < 0)
            {
                return validMoves;
            }
            for (int rank = location.Rank - 1; rank >= 0; rank--)
            {
                try
                {
                    AddValidMoveToList(isWhite, location.File, rank, validMoves, board);
                }
                catch (Exception e)
                {
                    break;
                }
            }

            return validMoves;
        }

        public List<Location> MoveWest(Board board, Location location, bool isWhite, int maxMoves)
        {
            var validMoves = new List<Location>();

            if (location.File < 0)
            {
                return validMoves;
            }
            for (int file = location.File - 1; file >= 0; file--)
            {
                try
                {
                    AddValidMoveToList(isWhite, file, location.Rank, validMoves, board);
                }
                catch (Exception e)
                {
                    break;
                }
            }

            return validMoves;
        }

        private void AddValidMoveToList(bool isWhite, int file, int rank, List<Location> validMoves, Board board)
        {
            SquareStatus targetSquareStatus;
            targetSquareStatus = board.GetSquareStatus(isWhite, new Location(file, rank));

            if (targetSquareStatus == SquareStatus.Empty)
            {
                validMoves.Add(new Location(file, rank));
                return;
            }

            if (targetSquareStatus == SquareStatus.Foe)
            {
                validMoves.Add(new Location(file, rank));
                throw new EarlyMovementTerminationException();
            }
            throw new InvalidMoveException();
        }
    }
}
