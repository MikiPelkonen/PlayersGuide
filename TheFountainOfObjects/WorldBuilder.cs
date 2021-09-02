public class WorldBuilder
{
    public GameSize GameSize { get; }
    public WorldBuilder(GameSize gs)
    {
        GameSize = gs;
    }
    public World BuildWorld()
    {
        int length = GameSize switch
        {
            GameSize.Small  =>  4,
            GameSize.Medium =>  6,
            GameSize.Large  =>  8
        };

        Room[,] rooms = new Room[length, length];

        for(int row = 0; row < rooms.GetLength(0); row++)
        {
            for (int column = 0; column < rooms.GetLength(1); column++)
            {
                rooms[row, column] = new Room(RoomType.Empty);
            }
        }

        rooms[0, 0] = new Entrance();
        rooms[0, length / 2] = new FountainRoom();

        World world = new World(rooms);

        return world;
    }
}
