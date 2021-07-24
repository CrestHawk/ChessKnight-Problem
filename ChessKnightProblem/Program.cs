using System;
using Chess;

namespace ChessKnightProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string startingPosition = args[0];
            string desiredPosition = args[1];
            int numberOfMoves;
                
            int.TryParse(args[2], out numberOfMoves);

            Console.WriteLine($"Hello! Knight is starting at position {startingPosition}, and will attempt to move to {desiredPosition} in {numberOfMoves} moves");

            Board chessBoard = new Board();
            
            Console.ReadLine();
        }
    }
}
