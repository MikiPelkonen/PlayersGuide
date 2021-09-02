using System;

Coordinate A = new Coordinate(1, 3);
Coordinate B = new Coordinate(1, 1);

Console.WriteLine(A.IsAdjacent(B));

public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public bool IsAdjacent(Coordinate c)
    {
        int rowChange = Row - c.Row;
        int columnChange = Column - c.Column;

        if (Math.Abs(rowChange) <= 1 && columnChange == 0) return true;
        if (Math.Abs(columnChange) <= 1 && rowChange == 0) return true;

        return false;
    }
}
