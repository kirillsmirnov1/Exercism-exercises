using System;
using System.Collections.Generic;

public static class ListOps
{
    public static int Length<T>(List<T> input)
        => Foldl(input, 0, (count, i) => count + 1);

    public static List<T> Reverse<T>(List<T> input)
    {
        List<T> output = new List<T>();

        for (int i = Length(input) - 1; i >= 0; --i)
        {
            output.Add(input[i]);
        }

        return output;
    }

    public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
    {
        List<TOut> output = new List<TOut>();

        foreach (var item in input)
        {
            output.Add(map(item));
        }

        return output;
    }

    public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
    {
        List<T> output = new List<T>();

        foreach (var item in input)
        {
            if (predicate(item))
            {
                output.Add(item);
            }
        }

        return output;
    }

    public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
    {
        foreach (var item in input)
        {
            start = func(start, item);
        }

        return start;
    }

    public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
        => Foldl(Reverse(input), start, (acc, x) => func(x, acc));

    public static List<T> Concat<T>(List<List<T>> input)
        => Foldl(input, new List<T>(), (acc, i) => Append(acc, i));

    public static List<T> Append<T>(List<T> left, List<T> right)
    {
        foreach(var item in right)
        {
            left.Add(item);
        }

        return left;
    }
}