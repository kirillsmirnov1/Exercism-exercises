using System.Collections.Generic;

public enum Plant
{
    Violets     = 'V',
    Radishes    = 'R',
    Clover      = 'C',
    Grass       = 'G'
}

public class KindergartenGarden
{
    private readonly string diagram;

    public KindergartenGarden(string diagram)
        => this.diagram = diagram;

    public IEnumerable<Plant> Plants(string student)
    {
        int index = student[0] - 'A';

        foreach(var row in diagram.Split("\n"))
        {
            yield return (Plant)row[index * 2];
            yield return (Plant)row[index * 2 + 1];
        }
    }
}