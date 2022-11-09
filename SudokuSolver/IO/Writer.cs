namespace SudokuSolver
{
    public static class Writer
    {
        public static void NpcTalk(string text, int sleepTime, bool clear, ConsoleColor consoleColor = ConsoleColor.Cyan)
        {
            Console.ForegroundColor = consoleColor;

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
            sudoku.Print();

            Thread.Sleep(sleepTime);

            if (clear)
            {
                Console.Clear();
            }
        }

        public static void ButtonAwaiter(string text, bool clear = false)
        {
            Console.WriteLine("");
            Console.Write(text);
            Console.ReadKey();

            if (clear)
            {
                Console.Clear();
            }
        }
    }
}
