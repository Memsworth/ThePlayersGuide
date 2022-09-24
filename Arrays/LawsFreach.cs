namespace Arrays;

public class LawsFreach
{
    public static void RunProgram()
    {
        int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
        int currentSmallest = int.MaxValue; // Start higher than anything in the array.
        foreach (var item in array)
        {
            if (item<currentSmallest)
            {
                currentSmallest = item;
            }
        }

        Console.WriteLine(currentSmallest);
        Console.WriteLine($"sum: {array.Sum()}");
        Console.WriteLine($"average: {array.Average()}");
    }
}