using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        bool question = statement.EndsWith("?");
        bool yell = statement.ToUpper().Equals(statement) && statement.Any(char.IsLetter);
        bool yellAQuestion = question && yell;
        bool empty = statement.Length == 0;

        if (empty) return "Fine. Be that way!";
        if (yellAQuestion) return "Calm down, I know what I'm doing!";
        if (question) return "Sure.";
        if (yell) return "Whoa, chill out!";
        
        return "Whatever.";
    }
}