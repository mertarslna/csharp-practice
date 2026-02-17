using System;

class Program
{
    static void Main()
    {
        GameStart();
    }

    static void GameStart()
    {
        while (true)
        {
            PlayGame();
            Console.Write("Play again? (y/n): ");
            var response = Console.ReadLine();
            if (response.ToLower()[0] != 'y') break;
            Console.Clear();
        }
    }

    static void PlayGame()
    {
        char[,] board = new char[3, 3];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                board[i, j] = ' ';

        char current = 'X';
        int moves = 0;
        while (true)
        {
            PrintBoard(board);
            Console.WriteLine($"Player { (current=='X'?1:2) } ({current}), enter your move as row and column (1-3, separated by space):");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            var parts = input.Split(new[] {' ', ',', ';'}, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2 || !int.TryParse(parts[0], out int r) || !int.TryParse(parts[1], out int c))
            {
                Console.WriteLine("Please enter two numbers between 1 and 3 separated by a space.");
                continue;
            }
            r--; c--;
            if (r < 0 || r > 2 || c < 0 || c > 2)
            {
                Console.WriteLine("Row and column must be between 1 and 3.");
                continue;
            }
            if (board[r, c] != ' ')
            {
                Console.WriteLine("That cell is already taken. Choose another.");
                continue;
            }

            board[r, c] = current;
            moves++;

            if (CheckWin(board, current))
            {
                PrintBoard(board);
                Console.WriteLine($"Player {(current=='X'?1:2)} ({current}) wins!");
                break;
            }
            if (moves == 9)
            {
                PrintBoard(board);
                Console.WriteLine("It's a draw!");
                break;
            }

            current = current == 'X' ? 'O' : 'X';
        }
    }

    static void PrintBoard(char[,] b)
    {
        Console.WriteLine();
        Console.WriteLine("   1   2   3");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("  ---+---+---");
            Console.Write($"{i+1} ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" ");
                Console.Write(b[i, j]);
                Console.Write(" ");
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
        }
        Console.WriteLine("  ---+---+---");
        Console.WriteLine();
    }

    static bool CheckWin(char[,] b, char p)
    {
        // rows
        for (int i = 0; i < 3; i++)
            if (b[i,0] == p && b[i,1] == p && b[i,2] == p) return true;
        // cols
        for (int j = 0; j < 3; j++)
            if (b[0,j] == p && b[1,j] == p && b[2,j] == p) return true;
        // diagonals
        if (b[0,0] == p && b[1,1] == p && b[2,2] == p) return true;
        if (b[0,2] == p && b[1,1] == p && b[2,0] == p) return true;
        return false;
    }
}