namespace FivePrototypes;

public class Point
{
    public int PositionX { get; private set; }
    public int PositionY { get; private set; }

    public Point(int positionX, int positionY)
    {
        PositionX = positionX;
        PositionY = positionY;
    }


    public Point() : this(0, 0)
    {
        
    }

    public string DisplayPoint() => $"({PositionX}, {PositionY})";
}