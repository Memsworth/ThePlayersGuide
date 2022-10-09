// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


public class Map
{
    public RoomType[,] GameMap { get; private set; }

    public Map(uint boardDimensions)
    {
        GameMap = new RoomType[boardDimensions, boardDimensions];
        int[3,3] = 
    }
}

public enum RoomType
{

};
public enum Direction
{
    North, East, South, West
};

