using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Board
    {
        private Cell[,] _cells = new Cell[8, 8];
        
        public Board()
        {
            InitCells();
        }

        private void InitCells()
        {
            int numberOfCells = 0;

            string[] columns = new string[8] { "A", "B", "C", "D", "E", "F", "G", "H" };

            int numberOfRows = 8;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < columns.Length; j++)
                {
                    _cells[i, j] = new Cell()
                    {
                        Row = i.ToString(),
                        Column = j.ToString(),
                        IsValidMove = false
                    };

                    numberOfCells++;
                }
            }

            Console.WriteLine($"Board initialised with {numberOfCells} cells");
        }
    }
}
