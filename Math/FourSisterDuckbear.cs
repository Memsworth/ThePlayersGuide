namespace Math;

public class FourSisterDuckbear
{
    public static void RunProgram()
    {
        Console.WriteLine("How many choco eggs?");
        int chocoEggs = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

        int duckBearEggs = chocoEggs % 4;

        Console.WriteLine($"Choco eggs for each sister: {chocoEggs/4}");
        Console.WriteLine($"Choco eggs for duckbear: {duckBearEggs}");
    }
}