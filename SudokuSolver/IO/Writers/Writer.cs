using SudokuSolver.IO.Interfaces;
using SudokuSolver.SudokuRelated;

namespace SudokuSolver.IO.Writers
{
    public class Writer : IWriter, ISudokuPrinter, IButtonAwaiter, IResponseAwaiter
    {
        public void Write(string text, int sleepTime, bool clear, ConsoleColor consoleColor = ConsoleColor.Cyan)
        {
            Console.ForegroundColor = consoleColor;

            Console.WriteLine(text);
            Console.WriteLine(" ");

            Thread.Sleep(sleepTime);

            if (clear)
            {
                Console.Clear();
            }
        }

        public void PrintSudoku(Sudoku sudoku, int sleepTime, bool clear = false)
        {
            sudoku.Print();
            Console.WriteLine("");

            Thread.Sleep(sleepTime);

            if (clear)
            {
                Console.Clear();
            }
        }

        public void ButtonAwaiter(string text, bool clear = false)
        {
            Console.Write(text);
            Console.ReadKey();

            if (clear)
            {
                Console.Clear();
            }
        }

        public string ResponseAwaiter(bool clear = false)
        {
            string response = Console.ReadLine().ToLower();
            while (true)
            {
                if (response == "yes" || response == "no")
                {
                    break;
                }

                response = Console.ReadLine().ToLower();
            }

            if (clear)
            {
                Console.Clear();
            }

            return response;
        }
    }
}
