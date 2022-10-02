
structTests.RunProgram();

public static class structTests
{
    public static void RunProgram()
    {
        var a = new Coordinate(5,4);
        var b = new Coordinate(4, 4);
        var c = new Coordinate(4, 3);
        
        Console.WriteLine(Coordinate.IsAdjacent(a, b)); // Should be True
        Console.WriteLine(Coordinate.IsAdjacent(b, c)); // Should be True
        Console.WriteLine(Coordinate.IsAdjacent(a, c)); // Should be True
    }

}

public struct Coordinate
{
    private int Row { get; }
    private int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public static bool IsAdjacent(Coordinate a, Coordinate b)
    {
        int changeRow = a.Row - b.Row;
        int changeCol = a.Column - b.Column;

        if (Math.Abs(changeRow) <= 1 && changeCol == 0) return true;
        if (Math.Abs(changeCol) <= 1 && changeRow == 0) return true;

        return false;
    }
}