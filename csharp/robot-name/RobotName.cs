using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    private readonly Random random = new Random();

    private static readonly HashSet<string> names = new HashSet<string>();
    private string name;
    public string Name
    {
        get
        {
            if (name == null)
            {
                name = GenerateNewName();
            }

            return name;
        }
    }

    private string GenerateNewName()
    {
        var stringBuilder = new StringBuilder();

        do
        {
            stringBuilder.Clear();
            stringBuilder
                .Append(GenerateChar('A', 'Z'))
                .Append(GenerateChar('A', 'Z'))
                .Append(GenerateChar('0', '9'))
                .Append(GenerateChar('0', '9'))
                .Append(GenerateChar('0', '9'));
        } while (!names.Add(stringBuilder.ToString()));

        return stringBuilder.ToString();
    }

    private char GenerateChar(char from, char to)
        => (char)(random.Next(from, to + 1));

    public void Reset()
    {
        names.Remove(name);
        name = null;
    }
}