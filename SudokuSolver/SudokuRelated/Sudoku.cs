using SudokuSolver.SudokuRelated.Patterns;
using SudokuSolver.SudokuRelated.Simulation;

namespace SudokuSolver
{
    public class Sudoku
    {
        public const int sudokuSize = 9;
        private int[,] sudokuMatrix;

        public Sudoku()
        {
            var pattern = PatternSetter.SetPattern();
            GeneratedPattern.pattern = new int[sudokuSize, sudokuSize];
            sudokuMatrix = new int[sudokuSize, sudokuSize];
            ArrayTransferer(sudokuMatrix, pattern);
            ArrayTransferer(GeneratedPattern.pattern, pattern);
        }

        private void ArrayTransferer(int[,] location, int[,] actualMatrix)
        {
            for (int row = 0; row < sudokuSize; row++)
            {
                for (int col = 0; col < sudokuSize; col++)
                {
                    location[row, col] = actualMatrix[row, col];
                }
            }
        }

        public void Print()
        {
            for (int row = 0; row < sudokuSize; row++)
            {
                if (row == 0 || row == 3 || row == 6 )
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("|---|---|-|---|---|-|---|---|");
                }
                for (int col = 0; col < sudokuSize; col++)
                {
                    if (col == 3 || col == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($" |");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"{sudokuMatrix[row, col]}");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"|");

                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"|");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{sudokuMatrix[row, col]}");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"|");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("|---|---|-|---|---|-|---|---|");

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void StaticPrint(int[,] outsideSudoku, int currentRow, int currentCol)
        {
            for (int row = 0; row < sudokuSize; row++)
            {
                if (row == 0 || row == 3 || row == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("|---|---|-|---|---|-|---|---|");
                }
                for (int col = 0; col < sudokuSize; col++)
                {
                    if (col == 3 || col == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($" |");
                        IsCurrentLocation(outsideSudoku, row, col, currentRow, currentCol);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"|");

                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"|");
                    IsCurrentLocation(outsideSudoku, row, col, currentRow, currentCol);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"|");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("|---|---|-|---|---|-|---|---|");

            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void IsCurrentLocation(int[,] sudokuMatrix, int row, int col, int expectedRow, int expectedCol)
        {
            if (row == expectedRow && col == expectedCol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{sudokuMatrix[row, col]}");
                return;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{sudokuMatrix[row, col]}");
        }

        public bool Solve()
        {
            for (int row = 0; row < sudokuSize; row++)
            {
                for (int col = 0; col < sudokuSize; col++)
                {
                    if (sudokuMatrix[row, col] == 0)
                    {
                        for (int number = 1; number <= sudokuSize; number++)
                        {
                            if (IsPlaceable(row, col, number))
                            {
                                sudokuMatrix[row, col] = number;

                                if (Solve())
                                {
                                    return true;
                                }
                                else
                                {
                                    sudokuMatrix[row, col] = 0;
                                }
                            }
                        }

                        return false;
                    }
                }
            }

            return true;
        }

        private bool IsPlaceable(int row, int col, int number)
        {
            for (int i = 0; i < sudokuSize; i++)
            {
                // If there is another row with the same column and same number we return false.
                if (sudokuMatrix[i, col] != 0 && sudokuMatrix[i, col] == number)
                {
                    return false;
                }
                
                // Same validation but with each column.
                if (sudokuMatrix[row, i] != 0 && sudokuMatrix[row, i] == number)
                {
                    return false;
                }

                // Checks if the 3x3 we are at contains the number we are trying to put
                if (sudokuMatrix[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3] != 0
                    &&
                    sudokuMatrix[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3] == number)
                {
                    return false;
                }           
            }

            return true;
        }

        public void Simulate()
        {
            Simulation.Simulate();
        }
    }
}
