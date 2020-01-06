using System;

namespace ChessMovement
{
    class Program
    {
        static Board board = new Board(8);
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter Piece Type: Bishop, King, Knight, Pawn, Queen, Rook or 'q' to quit");

                var input = Console.ReadLine().ToLowerInvariant().Trim();
                {
                    if (input == "q")
                        break;
                }
           
                try
                {
                    var pieceFactory = new PieceFactory();
                    var piece = pieceFactory.CreatePiece(input, true);

                    var pieceLocation = new Location(0, 0);

                    var moves = piece.GetValidMoves(board, pieceLocation);
                    var joined = string.Join(",", moves);
                    Console.WriteLine(joined);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
