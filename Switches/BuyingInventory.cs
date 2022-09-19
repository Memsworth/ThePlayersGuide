namespace Switches;

public class BuyingInventory
{
    public static void RunProgram()
    {
        int rope = 10;
        int torches = 16;
        int climbingEquipment = 24;
        int cleanWater = 2;
        int machete = 20;
        int canoe = 200;
        int foodSupplies = 2;

        ShowMenu();
        Console.Write("What number do you want to see the price of? ");
        int input = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

        switch (input)
        {
            case 1:
                Console.WriteLine($"Ropes cost {rope} gold");
                break;
            case 2:
                Console.WriteLine($"Torches cost {torches} gold");
                break;
            case 3:
                Console.WriteLine($"Climbing Equipment cost {climbingEquipment} gold");
                break;
            case 4:
                Console.WriteLine($"Clean Water cost {cleanWater} gold");
                break;
            case 5:
                Console.WriteLine($"Machete cost {machete} gold");
                break;
            case 6:
                Console.WriteLine($"Canoe cost {canoe} gold");
                break;
            case 7:
                Console.WriteLine($"Food Supplies cost {foodSupplies} gold");
                break;
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine("The following items are available: ");
        Console.WriteLine("1- Rope");
        Console.WriteLine("2- Torches");
        Console.WriteLine("3- Climbing Equipment");
        Console.WriteLine("4- Clean Water");
        Console.WriteLine("5- Machete");
        Console.WriteLine("6- Canoe");
        Console.WriteLine("7- Food Supplies");
    }
}