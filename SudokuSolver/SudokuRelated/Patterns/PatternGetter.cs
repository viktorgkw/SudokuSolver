namespace SudokuSolver.SudokuRelated.Patterns
{
    public static class PatternGetter
    {
        public const int PatternsCount = 6;

        public static List<int[]> Set(int patternNumber)
        {
            switch (patternNumber)
            {
                case 1:
                    return PatternOne();
                case 2:
                    return PatternTwo();
                case 3:
                    return PatternThree();
                case 4:
                    return PatternFour();
                case 5:
                    return PatternFive();
                case 6:
                    return PatternSix();
            }

            throw new ArgumentException($"Pattern number {patternNumber} does not exist.");
        }

        private static List<int[]> PatternOne()
        {
            List<int[]> pattern = new List<int[]>
            {
                new int[Sudoku.sudokuSize] { 0, 5, 0, 0, 0, 1, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 9, 0, 0, 0, 2, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 8, 0, 0, 0, 3, 0, 0, 0 },

                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 8, 7, 6, 0, 0, 0, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },

                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 0, 0, 2, 0, 1 },
                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 0, 0, 9, 0, 8 },
                new int[Sudoku.sudokuSize] { 7, 4, 9, 0, 0, 0, 5, 0, 3 }
            };

            return pattern;
        }

        private static List<int[]> PatternTwo()
        {
            List<int[]> pattern = new List<int[]>
            {
                new int[Sudoku.sudokuSize] { 0, 0, 3, 0, 4, 8, 0, 2, 5 },
                new int[Sudoku.sudokuSize] { 0, 8, 6, 0, 0, 2, 0, 9, 1 },
                new int[Sudoku.sudokuSize] { 0, 2, 5, 3, 0, 0, 0, 0, 0 },

                new int[Sudoku.sudokuSize] { 0, 6, 0, 7, 0, 0, 0, 0, 8 },
                new int[Sudoku.sudokuSize] { 1, 0, 0, 0, 0, 0, 0, 0, 2 },
                new int[Sudoku.sudokuSize] { 8, 0, 0, 0, 0, 5, 0, 6, 0 },

                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 0, 7, 2, 8, 0 },
                new int[Sudoku.sudokuSize] { 5, 7, 0, 2, 0, 0, 9, 4, 0 },
                new int[Sudoku.sudokuSize] { 3, 4, 0, 8, 6, 0, 5, 0, 0 }
            };

            return pattern;
        }

        private static List<int[]> PatternThree()
        {
            List<int[]> pattern = new List<int[]>
            {
                new int[Sudoku.sudokuSize] { 8, 0, 0, 0, 0, 0, 0, 5, 6 },
                new int[Sudoku.sudokuSize] { 2, 0, 0, 0, 0, 6, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 2, 3, 0, 0, 0 },

                new int[Sudoku.sudokuSize] { 0, 3, 1, 0, 0, 0, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 0, 7, 0, 4, 0, 3, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 0, 0, 7, 2, 0 },

                new int[Sudoku.sudokuSize] { 0, 0, 0, 8, 3, 0, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 0, 0, 9, 0, 0, 0, 0, 1 },
                new int[Sudoku.sudokuSize] { 4, 6, 0, 0, 0, 0, 0, 0, 5 }
            };

            return pattern;
        }

        private static List<int[]> PatternFour()
        {
            List<int[]> pattern = new List<int[]>
            {
                new int[Sudoku.sudokuSize] { 7, 0, 0, 0, 0, 0, 2, 8, 0 },
                new int[Sudoku.sudokuSize] { 0, 0, 0, 3, 0, 0, 0, 5, 9 },
                new int[Sudoku.sudokuSize] { 0, 0, 8, 4, 0, 0, 0, 0, 0 },

                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 4, 0, 5, 1, 0 },
                new int[Sudoku.sudokuSize] { 0, 0, 0, 8, 0, 9, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 3, 6, 0, 1, 0, 0, 0, 0 },

                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 0, 5, 6, 0, 0 },
                new int[Sudoku.sudokuSize] { 4, 1, 0, 0, 0, 8, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 6, 5, 0, 0, 0, 0, 0, 2 }
            };

            return pattern;
        }

        private static List<int[]> PatternFive()
        {
            List<int[]> pattern = new List<int[]>
            {
                new int[Sudoku.sudokuSize] { 0, 6, 0, 5, 0, 4, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 0, 9, 0, 0, 0, 0, 1, 0 },
                new int[Sudoku.sudokuSize] { 0, 7, 0, 0, 3, 0, 0, 0, 0 },

                new int[Sudoku.sudokuSize] { 0, 9, 0, 8, 0, 6, 0, 0, 4 },
                new int[Sudoku.sudokuSize] { 4, 0, 0, 0, 2, 0, 0, 0, 1 },
                new int[Sudoku.sudokuSize] { 3, 0, 0, 9, 0, 7, 0, 6, 0 },

                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 9, 0, 0, 7, 0 },
                new int[Sudoku.sudokuSize] { 0, 1, 0, 0, 0, 0, 9, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 0, 0, 4, 0, 1, 0, 5, 0 }
            };

            return pattern;
        }

        private static List<int[]> PatternSix()
        {
            List<int[]> pattern = new List<int[]>
            {
                new int[Sudoku.sudokuSize] { 0, 6, 0, 5, 0, 4, 0, 0, 0 },
                new int[Sudoku.sudokuSize] { 1, 0, 9, 0, 0, 2, 0, 1, 0 },
                new int[Sudoku.sudokuSize] { 0, 7, 0, 0, 3, 0, 0, 0, 0 },

                new int[Sudoku.sudokuSize] { 0, 9, 0, 8, 0, 6, 0, 0, 4 },
                new int[Sudoku.sudokuSize] { 4, 0, 1, 0, 2, 0, 1, 0, 1 },
                new int[Sudoku.sudokuSize] { 3, 0, 0, 9, 0, 7, 0, 6, 0 },

                new int[Sudoku.sudokuSize] { 0, 0, 0, 0, 9, 1, 0, 7, 0 },
                new int[Sudoku.sudokuSize] { 0, 1, 0, 0, 0, 0, 9, 0, 0 },
                new int[Sudoku.sudokuSize] { 0, 0, 0, 4, 0, 1, 0, 5, 0 }
            };

            return pattern;
        }
    }
}
