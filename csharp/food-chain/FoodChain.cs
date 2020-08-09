using System.Linq;
using System.Text;

public static class FoodChain
{
    private static readonly string[] creatures = new string[] 
        { "fly", "spider", "bird", "cat", "dog", "goat", "cow", "horse" };

    private static readonly string[] creaturesSecondLines = new string[]
        {
            "",
            "It wriggled and jiggled and tickled inside her.\n",
            "How absurd to swallow a bird!\n",
            "Imagine that, to swallow a cat!\n",
            "What a hog, to swallow a dog!\n",
            "Just opened her throat and swallowed a goat!\n",
            "I don't know how she swallowed a cow!\n",
            ""
        };

    public static string Recite(int verseNumber)
    {
        StringBuilder stringBuilder = new StringBuilder();
        int verse = verseNumber - 1;

        stringBuilder.Append($"I know an old lady who swallowed a {creatures[verse]}.\n");
        stringBuilder.Append(creaturesSecondLines[verse]);

        if (verse == 7)
        {
            stringBuilder.Append("She's dead, of course!");
            return stringBuilder.ToString();
        }

        for(int i = verse; i > 0; --i)
        {
            if (i == 2)
                stringBuilder.Append("She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\n");
            else
                stringBuilder.Append($"She swallowed the {creatures[i]} to catch the {creatures[i - 1]}.\n");
        }

        stringBuilder.Append("I don't know why she swallowed the fly. Perhaps she'll die.");

        return stringBuilder.ToString();
    }

    public static string Recite(int startVerse, int endVerse)
        => Enumerable.Range(startVerse, endVerse - startVerse + 1)
        .Select(x => Recite(x))
        .Aggregate((song, verse) => song + "\n\n" + verse);
}