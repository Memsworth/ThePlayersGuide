public class Map
{
    public RoomType[,] GameMap { get; private set; }

    public Map(uint boardDimensions)
    {
        GameMap = new RoomType[boardDimensions, boardDimensions];
    }
}

public class Location
{
    public int Row { get; }
    public int Col { get; }
    
}

public class Fountain
{
    public bool FountainCondition { get; private set; }

    public Fountain()
    {
        FountainCondition = false;
    }
}

public class Player : ISense
{
    public string PlayerName { get; }
    public Player(string playerName)
    {
        PlayerName = playerName;
    }
    public Direction GetPlayerCommand()
    {
        Direction options = Console.ReadLine() switch
        {
            "1" => Direction.North,
            "2" => Direction.East,
            "3" => Direction.South,
            "move west" => Direction.West,
        };

        return options;
    }

    public RoomSense GetRoomSense()
    {
        throw new NotImplementedException();
    }
}


public interface ISense
{
    public RoomSense GetRoomSense();
}

public enum RoomType
{
    Empty
};

public enum RoomSense
{
};
public enum Direction
{
    North, East, South, West
};

