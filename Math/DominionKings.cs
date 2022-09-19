namespace Math;

public class DominionKings
{
    public static void RunProgram()
    {
        int estate = 1;
        int duchy = 3;
        int province = 6;

        Console.WriteLine("How many estates?");
        int input = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
        estate *= input;

        Console.WriteLine("How many duchy?");
        input = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
        duchy *= input;


        Console.WriteLine("How many province?");
        input = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
        province *= input;

        Console.WriteLine($"Total point: {estate+duchy+province}");
    }
}