using System.Linq;

public static class Minesweeper
{
    public static string[] Annotate(string[] input)
    {
        if (input.Length == 0) return new string[0];

        int ROWS = input.Length;
        int COLS = input[0].Length;

        char[][] MINES = new char[ROWS][];

        // Set mine rows
        for (int row = 0; row < ROWS; ++row)
        {
            MINES[row] = input[row].ToCharArray();
        }

        // Check every position for mine
        for (int row = 0; row < ROWS; ++row)
        {
            for (int col = 0; col < COLS; ++col)
            {
                if (MINES[row][col] == '*')
                {
                    HandleMineAtPosition(row, col);
                }
            }
        }

        return MINES.Select(row => new string(row)).ToArray();

        // Checks every position around mine. 
        void HandleMineAtPosition(int row, int col)
        {
            for (int iRow = row - 1; iRow <= row + 1; ++iRow)
            {
                for (int iCol = col - 1; iCol <= col + 1; ++iCol)
                {
                    // If position can be reached and doesn't contain mine — increment counter at position
                    if (iRow >= 0 && iRow < ROWS && iCol >= 0 && iCol < COLS && MINES[iRow][iCol] != '*')
                    {
                        IncrementCounterAt(iRow, iCol);
                    }
                }
            }
        }

        void IncrementCounterAt(int row, int col)
        {
            if (MINES[row][col] == ' ')
                MINES[row][col] = '1';
            else
                MINES[row][col]++;
        }
    }
}
