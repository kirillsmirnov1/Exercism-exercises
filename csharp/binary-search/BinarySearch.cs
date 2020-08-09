using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int iL = 0;
        int iR = input.Length - 1;

        while(true)
        {
            if (iL > iR) return -1;

            int iMid = (iL + iR) / 2;

            if (input[iMid] == value) return iMid;
            else if (input[iMid] > value) iR = iMid - 1;
            else iL = iMid + 1;
        }
    }
}