# Sudoku Solver🕹️

## Languages & Technologies
- C#

## About
> **Sudoku Solver** is a **C# Console Application** that gets random **Pattern** and uses algorithm to see if its solveable.

> If there is a possible **solve** the program prints the **solved sudoku** in a **fancy** way.

> The application uses **Backtracking Algorithm**.

## How it works?
> #### <a href="https://github.com/viktorgkw/SudokuSolver/blob/main/SudokuSolver/SudokuRelated/SudokuPatterns.cs#L14"> First the program gets the starting sudoku pattern.</a>
>
> #### <a href="https://github.com/viktorgkw/SudokuSolver/blob/main/SudokuSolver/SudokuRelated/SudokuPatterns.cs#L7">Then sets it.</a>
>
> #### <a href="https://github.com/viktorgkw/SudokuSolver/blob/main/SudokuSolver/SudokuRelated/Sudoku.cs#L58">Then we start the algorithm.</a>
>
> #### <a href="https://github.com/viktorgkw/SudokuSolver/blob/main/SudokuSolver/SudokuRelated/Sudoku.cs#L96">The algorithm checks if the number we try to enter is already on the same row.</a>
>
> #### <a href="https://github.com/viktorgkw/SudokuSolver/blob/main/SudokuSolver/SudokuRelated/Sudoku.cs#L102">Then it checks if the same number is in the other rows with the current column.</a>
>
> #### <a href="https://github.com/viktorgkw/SudokuSolver/blob/main/SudokuSolver/SudokuRelated/Sudoku.cs#L108">And lastly it checks if the number exists in the same 3x3 block.</a>
>
> #### <a href="https://github.com/viktorgkw/SudokuSolver/blob/main/SudokuSolver/SudokuRelated/Sudoku.cs#L58">If all those are false we put the number and repeat until we find a solution.</a>
>
> #### <a href="https://github.com/viktorgkw/SudokuSolver/blob/dea67d7a55aa48a22a6422ae864fa2e50d1259ce/SudokuSolver/SudokuRelated/SimulationRelated/Simulation.cs#L11">At the end of the program there is a simple answer awaiter that if you say yes the program will simulate the algorithm else it will stop.</a>

## Resources Used
> - #### <a href="https://sudokuprimer.com/patterns.php">Patterns</a>
> - #### <a href="https://www.conceptispuzzles.com/index.aspx?uri=puzzle/sudoku/techniques">Solving Techniques</a>

## Fun facts
> #### This algorithm is actually pretty easy to understand and write.

<br />

## Thanks for checking out the repository!
