using System.ComponentModel;
using System.Text;

namespace SudokuSolver
{
    public class Sudoku
    {
        private int[,] sudokuMatrix;
        public Sudoku()
        {
            sudokuMatrix = new int[9, 9];
            SetStartPattern();
        }

        private void SetStartPattern()
        {
            sudokuMatrix = SudokuPattern.GetPattern();
        }

        public void Print()
        {
            for (int row = 0; row < sudokuMatrix.GetLength(0); row++)
            {
                if (row == 0 || row == 3 || row == 6 )
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("|---|---|-|---|---|-|---|---|");
                }
                for (int col = 0; col < sudokuMatrix.GetLength(1); col++)
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

        public void Solve()
        {
            sudokuMatrix = Solver.Solve(sudokuMatrix);
        }
    }
}
