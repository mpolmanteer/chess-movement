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

                var inputPiece = Console.ReadLine().ToLowerInvariant().Trim();
                {
                    if (inputPiece == "q")
                        break;
                }
           
                try
                {
                    var pieceFactory = new PieceFactory();
                    var piece = pieceFactory.CreatePiece(inputPiece, true);

                    Console.WriteLine("Enter Piece Location in Chess notation (a1) to (h8)");
                    var inputLocation = Console.ReadLine().ToLowerInvariant().Trim();

                    var pieceLocation = Location.ParseChessNotation(inputLocation);
                    var validMoves = piece.GetValidMoves(board, pieceLocation);

                    Console.WriteLine("Possible Moves: "+ Location.GetAvailableLocations(validMoves));

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
