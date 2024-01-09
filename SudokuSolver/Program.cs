using SudokuSolver.IO;
using SudokuSolver.SudokuRelated;

try
{
    Sudoku sudoku = new();

    IO.Start(sudoku);
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Sorry, an error occured while trying to solve the Sudoku.");
    Console.WriteLine("Exception message:");
    Console.WriteLine(" ");
    Console.WriteLine(ex.Message);
}