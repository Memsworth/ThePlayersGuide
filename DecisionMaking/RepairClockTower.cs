namespace DecisionMaking;

public class RepairClockTower
{
    public static void RunProgram()
    {
        Console.Write("Enter input: ");
        int towerInput = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

        if (towerInput % 2 == 0)
        {
            Console.WriteLine("Tick");
        }
        else
        {
            Console.WriteLine("Tock");
        }
    }
}