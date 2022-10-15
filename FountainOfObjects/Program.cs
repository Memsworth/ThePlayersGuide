FountainOfObject game = new FountainOfObject();
game.Run();

public class FountainOfObject
{
    public Map Map { get; set;}
    public Player Player { get; set; }
    
    public Fountain Fountain { get; set; }

    public FountainOfObject()
    {
        Map = new Map(4, 4);
        Player = new Player("ABD", new Location(0, 0));
        Fountain = new Fountain(new Location(3, 3));

    }

    public void Run()
    {
        
    }
}

public class Fountain
{
    public bool FountainOpen { get; private set; }
    public Location FountainLocation { get; private set; }

    public Fountain(Location fountainLocation)
    {
        FountainOpen = false;
        FountainLocation = fountainLocation;
    }
}
public class Map
{
    public int Row { get; }
    public int Col { get; }
    public RoomType[,] CavernGrid  { get; private set; }
    public Map(int row, int col)
    {
        Row = row;
        Col = col;
        CavernGrid = new RoomType[row,col];
    }

    private bool LocationOutBound(Location location)
    {
        if (location.Row > CavernGrid.GetLength(0) || location.Row < 0) return false;
        if (location.Col > CavernGrid.GetLength(1) || location.Col < 0) return false;
        return true;
    }
    public void SetRoomType(Location location, RoomType roomType)
    {
        if (LocationOutBound(location)) CavernGrid[location.Row, location.Col] = roomType;
    }
}
public interface ICommand
{
    public bool Execute();
}

public class MoveCommand : ICommand
{
    public Direction Direction { get; private set; }
    
    public bool Execute()
    {
        return false;
    }
}

public class FountainCommand : ICommand
{
    public bool Execute()
    {
        throw new NotImplementedException();
    }
}

public class Player
{
    public string PlayerName { get; }
    public Location PlayerLocation { get; set; }

    public Player(string playerName, Location playerLocation)
    {
        PlayerName = playerName;
        PlayerLocation = playerLocation;
    }
}

public class Location
{
    public int Row { get; }
    public int Col { get; }
    public Location(int row, int col)
    {
        Row = row;
        Col = col;
    }
}

public enum Direction
{
    North, East, South, West
};

public enum RoomType
{
    Empty, Entrance, Fountain
};