using System;
using System.Collections.Generic;
using System.Text;

namespace ChessKnightProblem.CLI
{
    public class BoardWriter
    {
        private int numberOfCells = 8;

        public BoardWriter()
        {
            DrawCellHeaders();
            DrawCellSeparators();

            for (int i = 0; i < numberOfCells; i++)
            {
                DrawRowOfCells();
                DrawCellSeparators();
            }
        }

        private void DrawCellHeaders()
        {
            Console.Write("    ");
            for (int i = 0; i < numberOfCells; i++)
            {
                Console.Write($"  {i}   ");
            }
        }

        private void DrawCellSeparators()
        {
            Console.WriteLine();
            Console.Write("   |");

            for (int i = 0; i < numberOfCells; i++)
            {
                Console.Write("-----|");
            }
        }

        private void DrawRowOfCells()
        {
            Console.WriteLine();
            Console.Write(" A |");

            for (int i = 0; i < numberOfCells; i++)
            {
                Console.Write("     |");
            }
        }
    }
}
