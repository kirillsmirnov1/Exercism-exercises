﻿using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
        => white.Row == black.Row
           || white.Column == black.Column
           || Math.Abs(white.Row - black.Row) == Math.Abs(white.Column - black.Column);

    public static Queen Create(int row, int column) 
        => OnBoard(row) && OnBoard(column) 
            ? new Queen(row, column)
            : throw new ArgumentOutOfRangeException();

    private static bool OnBoard(int pos) 
        => pos >= 0 && pos < 8;
    
}