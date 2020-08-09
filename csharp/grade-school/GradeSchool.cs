using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly SortedDictionary<int, List<string>> roster = new SortedDictionary<int, List<string>>();
    public void Add(string student, int grade)
    {
        if (!roster.ContainsKey(grade))
            roster.Add(grade, new List<string>());
        roster[grade].Add(student);
        roster[grade].Sort();
    }

    public IEnumerable<string> Roster()
        => roster.Aggregate(new List<string>(), (a, b) => a.AddAll(b.Value));

    public IEnumerable<string> Grade(int grade)
        => roster.ContainsKey(grade) ? roster[grade] : new List<string>();
}

public static class ListExtension
{
    public static List<T> AddAll<T>(this List<T> list, List<T> anotherList)
    {
        list.AddRange(anotherList);
        return list;
    }
}