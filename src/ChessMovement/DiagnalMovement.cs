using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMovement
{
    public class DiagnalMovement : IDiagonalMovement
    {
        public List<Location> MoveNorthEast(Board board, Location location, bool isWhite, int maxMoves)
        {
            var validMoves = new List<Location>();

            //Move East
            if (location.File > board.Size - 1 || location.Rank >= board.Size)
            {
                return validMoves;
            }
            var rank = location.Rank;
            for (int file = location.File + 1; file < board.Size; file++)
            {

                rank += 1;
                try
                {
                    AddValidMoveToList(isWhite, file, rank, validMoves, board);
                }
                catch (Exception e)
                {
                    break;
                }
            }

            return validMoves;
        }

        public List<Location> MoveNorthWest(Board board, Location location, bool isWhite, int maxMoves)
        {
            var validMoves = new List<Location>();

            //Move East
            if (location.File < 0 || location.Rank >= board.Size)
            {
                return validMoves;
            }
            var rank = location.Rank;
            for (int file = location.File - 1; file >= 0; file--)
            {

                rank += 1;
                try
                {
                    AddValidMoveToList(isWhite, file, rank, validMoves, board);
                }
                catch (Exception e)
                {
                    break;
                }
            }

            return validMoves;
        }

        public List<Location> MoveSouthEast(Board board, Location location, bool isWhite, int maxMoves)
        {
            var validMoves = new List<Location>();

            //Move East
            if (location.File >= board.Size || location.Rank >= board.Size)
            {
                return validMoves;
            }
            var rank = location.Rank;
            for (int file = location.File + 1; file < board.Size; file++)
            {

                rank -= 1;
                try
                {
                    AddValidMoveToList(isWhite, file, rank, validMoves, board);
                }
                catch (Exception e)
                {
                    break;
                }
            }

            return validMoves;
        }

        public List<Location> MoveSouthWest(Board board, Location location, bool isWhite, int maxMoves)
        {
            var validMoves = new List<Location>();

            //Move East
            if (location.File <= 0 || location.Rank <= 0)
            {
                return validMoves;
            }
            var rank = location.Rank;
            for (int file = location.File - 1; file >= 0; file--)
            {

                rank -= 1;
                try
                {
                    AddValidMoveToList(isWhite, file, rank, validMoves, board);
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
