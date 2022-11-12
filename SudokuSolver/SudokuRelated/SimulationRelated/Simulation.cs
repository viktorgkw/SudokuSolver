using SudokuSolver.IO.Writers;
using SudokuSolver.SudokuRelated.Patterns;

namespace SudokuSolver.SudokuRelated.SimulationRelated
{
    public static class Simulation
    {
        private static int[,] _sudokuMatrix;
        private static SimulationWriter simulationWriter = new SimulationWriter();

        public static void Simulate()
        {
            _sudokuMatrix = GeneratedPattern.pattern;

            Solve();
        }

        private static bool Solve()
        {
            for (int row = 0; row < Sudoku.sudokuSize; row++)
            {
                for (int col = 0; col < Sudoku.sudokuSize; col++)
                {
                    if (_sudokuMatrix[row, col] == 0)
                    {
                        simulationWriter.Write(_sudokuMatrix, $"Row: {row} Col: {col} are empty so we try to set a number.", row, col);
                        for (int number = 1; number <= Sudoku.sudokuSize; number++)
                        {
                            simulationWriter.Write(_sudokuMatrix, $"We try to place {number} on Row: {row} Col: {col}", row, col);
                            if (IsPlaceable(row, col, number))
                            {
                                _sudokuMatrix[row, col] = number;
                                simulationWriter.Write(_sudokuMatrix, $"{number} placed at Row: {row} Col: {col}", row, col);

                                if (Solve())
                                {
                                    return true;
                                }
                                else
                                {
                                    _sudokuMatrix[row, col] = 0;
                                    simulationWriter.Write(_sudokuMatrix, $"{number} removed from Row: {row} Col: {col}", row, col);
                                }
                            }
                            else
                            {
                                simulationWriter.Write(_sudokuMatrix, $"{number} cannot be placed at Row: {row} Col: {col}", row, col, $"Number: {number} is either in the 3x3 or on the same row.");
                            }
                        }
                        simulationWriter.Write(_sudokuMatrix, $"Algorithm couldn't find a number for this spot.\n So we use the \"Backtracking\" Technique and we go a step back.", row, col);
                        return false;
                    }

                    simulationWriter.Write(_sudokuMatrix, $"Row: {row} Col: {col} is not empty.", row, col, $"We can't replace already filled cells.");
                }
            }

            return true;
        }

        private static bool IsPlaceable(int row, int col, int number)
        {
            for (int i = 0; i < Sudoku.sudokuSize; i++)
            {
                // If there is another row with the same column and same number we return false.
                if (_sudokuMatrix[i, col] != 0 && _sudokuMatrix[i, col] == number)
                {
                    return false;
                }

                // Same validation but with each column.
                if (_sudokuMatrix[row, i] != 0 && _sudokuMatrix[row, i] == number)
                {
                    return false;
                }

                // Checks if the 3x3 we are at contains the number we are trying to put
                if (_sudokuMatrix[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3] != 0
                    &&
                    _sudokuMatrix[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3] == number)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
