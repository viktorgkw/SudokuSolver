﻿namespace SudokuSolver.SudokuRelated
{
    public static class SudokuPatterns
    {
        public static int[,] SetPattern()
        {
            int[,] sudokuPattern = new int[9, 9];

            int patternNumber = new Random().Next(1, Patterns.PatternsCount + 1);

            List<int[]> rows = Patterns.Set(patternNumber);

            for (int row = 0; row < Sudoku.sudokuSize; row++)
            {
                int[] currentRow = rows[row];

                for (int col = 0; col < Sudoku.sudokuSize; col++)
                {
                    sudokuPattern[row, col] = currentRow[col];
                }
            }

            return sudokuPattern;
        }
    }
}
