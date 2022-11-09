namespace SudokuSolver.SudokuRelated
{
    public static class SudokuPatterns
    {
        private const int sudokuSize = 9;
        private static int[,] sudokuPattern = new int[9, 9];

        public static int[,] SetPattern()
        {
            GetPattern();

            return sudokuPattern;
        }

        private static void GetPattern()
        {
            int patternNumber = new Random().Next(1, 6);

            List<int[]> rows = Patterns.Set(patternNumber);

            for (int row = 0; row < sudokuSize; row++)
            {
                int[] currentRow = rows[row];

                for (int col = 0; col < sudokuSize; col++)
                {
                    sudokuPattern[row, col] = currentRow[col];
                }
            }
        }
    }
}
