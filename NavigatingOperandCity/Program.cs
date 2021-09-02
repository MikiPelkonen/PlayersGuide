using System;

BlockCoordinate _bc = new BlockCoordinate(5, 3);
BlockOffset _oc = new BlockOffset(2, 0);
BlockCoordinate _result = _bc + _oc;
Console.WriteLine(_result);

Console.WriteLine((BlockOffset)Direction.South);

Console.WriteLine(_result[0]);
Console.WriteLine(_result[1]);

_oc = Direction.North;

Console.WriteLine(_oc);


public record BlockOffset(int RowOffset, int ColumnOffset)
{
    public static implicit operator BlockOffset(Direction d)
    {
        return d switch
        {
            Direction.North    =>  new BlockOffset(-1, 0),
            Direction.South    =>  new BlockOffset(1, 0),
            Direction.East     =>  new BlockOffset(0, 1),
            Direction.West     =>  new BlockOffset(0, -1)
        };
    }
}
public record BlockCoordinate(int Row, int Column)
{
    public int this[int number]
    {
        get
        {
            if (number == 0) return Row;
            return Column;
        }
    }
    public static BlockCoordinate operator +(BlockCoordinate c, BlockOffset o) => new BlockCoordinate(c.Row + o.RowOffset, c.Column + o.ColumnOffset);
    public static BlockCoordinate operator +(BlockCoordinate c, Direction d)
    {
        return c + (d switch
        {
            Direction.North =>  new BlockOffset(-1, 0),
            Direction.South =>  new BlockOffset(+1, 0),
            Direction.East  =>  new BlockOffset(0, +1),
            Direction.West  =>  new BlockOffset(0, -1)
        }); 
    }
}
public enum Direction { North, East, West, South }
