using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<List<int>> result = new List<List<int>>();

        for (int iRow = 0; iRow < rows; ++iRow)
        {
            int rowSize = iRow + 1;

            int[] row = new int[rowSize];

            row[0] = 1;

            for (int i = 1; i < (rowSize + 1) / 2; ++i)
            {
                row[i] = result[iRow - 1][i - 1] + result[iRow - 1][i];
            }

            for (int i = 0; i < rowSize / 2; ++i)
            {
                row[iRow - i] = row[i];
            }

            result.Add(new List<int>(row));
        }

        return result;
    }

}