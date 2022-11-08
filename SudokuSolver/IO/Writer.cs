namespace SudokuSolver
{
    public static class Writer
    {
        public static void NpcTalk(string text, int sleepTime, bool clear = false)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(text);
            Console.WriteLine(" ");

            Thread.Sleep(sleepTime);

            if (clear)
            {
                Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SudokuPrint(Sudoku sudoku, int sleepTime, bool clear = false)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            sudoku.Print();

            Thread.Sleep(sleepTime);

            if (clear)
            {
                Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ButtonAwaiter(bool clear = false)
        {
            Console.WriteLine("");
            Console.Write("If you are done looking at the starting pattern click ANY button.");
            Console.ReadKey();

            if (clear)
            {
                Console.Clear();
            }
        }
    }
}
