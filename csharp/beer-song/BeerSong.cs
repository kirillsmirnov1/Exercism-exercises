using System;
using System.Linq;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
        => Enumerable.Range(startBottles - takeDown + 1, takeDown)
        .Reverse()
        .Select(Verse)
        .Aggregate("", (song, verse) => song + verse + "\n\n")
        .RemoveLast("\n\n");

    private static string Verse(int i)
        => FirstLine(i) + SecondLine(i);

    private static string RemoveLast(this string str, string rm) 
        => str.Remove(str.LastIndexOf(rm));

    private static string FirstLine(int i)
        => NumberOfBottles(i) + BottleEnding(i) + " of beer on the wall, "
            + RightPart(i) + ".\n";

    private static string SecondLine(int i)
        => ((i == 0) 
                ? "Go to the store and buy some more, " 
                : $"Take {((i == 1) ? "it" : "one")} down and pass it around, "
            )
            + RightPart((i == 0) ? 99 : i - 1) + " on the wall.";

    private static string RightPart(int i)
        => NumberOfBottles(i).ToLower() + BottleEnding(i) + " of beer";

    private static string NumberOfBottles(int i)
        => (i == 0) ? "No more" : $"{i}";

    private static string BottleEnding(int i)
        => " bottle" + ((i == 1) ? "" : "s");
}