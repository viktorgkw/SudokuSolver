namespace SudokuSolver
{
    public static class SudokuPattern
    {
        private static int[,] sudokuPattern = new int[9,9]; 

        public static int[,] GetPattern()
        {
            FillSudoku();

            return sudokuPattern;
        }

        private static void FillSudoku()
        {
            List<int[]> rows = GetRows();

            for (int row = 0; row < sudokuPattern.GetLength(0); row++)
            {
                int[] currentRow = rows[row];

                for (int col = 0; col < sudokuPattern.GetLength(1); col++)
                {
                    sudokuPattern[row, col] = currentRow[col];
                }
            }
        }

        private static List<int[]> GetRows()
        {
            List<int[]> rows = new List<int[]>();

            rows.Add(new int[9] { 0, 5, 0, 0, 0, 1, 0, 0, 0 });
            rows.Add(new int[9] { 0, 9, 0, 0, 0, 2, 0, 0, 0 });
            rows.Add(new int[9] { 0, 8, 0, 0, 0, 3, 0, 0, 0 });

            rows.Add(new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            rows.Add(new int[9] { 8, 7, 6, 0, 0, 0, 0, 0, 0 });
            rows.Add(new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            rows.Add(new int[9] { 0, 0, 0, 0, 0, 0, 2, 0, 1 });
            rows.Add(new int[9] { 0, 0, 0, 0, 0, 0, 9, 0, 8 });
            rows.Add(new int[9] { 7, 4, 9, 0, 0, 0, 5, 0, 3 });

            return rows;
        }
    }
}
