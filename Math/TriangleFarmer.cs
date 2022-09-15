namespace Math;

public class TriangleFarmer
{
    public static void RunProgram()
    {
        Console.Write("input triangle base: ");
        float areaBase = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());
        
        Console.Write("input triangle height: ");
        float areaHeight = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());

        float areaOfTriangle = (areaBase * areaHeight) / 2.0f;

        Console.WriteLine($"area is {areaOfTriangle}");
    }
}