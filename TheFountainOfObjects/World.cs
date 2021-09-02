public class World
{
    private readonly Room[,] _grid;


    public World(Room[,] rooms)
    {
        _grid = rooms;
    }

    public RoomType GetRoomType(Coordinate c)
    {
        Room room = _grid[c.Row, c.Column];
        
        return room.Type;
    }
}
