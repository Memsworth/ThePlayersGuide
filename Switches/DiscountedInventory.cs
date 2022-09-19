namespace Switches;

public class DiscountedInventory
{
    public static void RunProgram()
    {
        int rope = 10;
        int torches = 15;
        int climbingEquipment = 24;
        int cleanWater = 2;
        int machete = 20;
        int canoe = 200;
        int foodSupplies = 2;
        string favoriteCustomer = "Abubakar";
        
        ShowMenu();
        Console.Write("What number do you want to see the price of? ");
        int input = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

        Console.WriteLine("Who sent you? ");
        string nameInput = Console.ReadLine() ?? throw new ArgumentNullException();

        switch (input)
        {
            case 1:
                printPrice(favoriteCustomer, nameInput, "Ropes", rope);
                break;
            case 2:
                printPrice(favoriteCustomer, nameInput, "Torches", torches);
                break;
            case 3:
                printPrice(favoriteCustomer, nameInput, "Climbing Equipment", climbingEquipment);
                break;
            case 4:
                printPrice(favoriteCustomer, nameInput, "Clean Water", cleanWater);
                break;
            case 5:
                printPrice(favoriteCustomer, nameInput, "Machete", machete);
                break;
            case 6:
                printPrice(favoriteCustomer, nameInput, "Canoe", canoe);
                break;
            case 7:
                printPrice(favoriteCustomer, nameInput, "Food Supplies", foodSupplies);

                break;
        }
    }

    private static void printPrice(string favoriteCustomer, string nameInput, string item, int cost)
    {
        if (favoriteCustomer == nameInput)
        {
            Console.WriteLine("Great. Here's your 50% discount"); 
            Console.WriteLine($"{item} cost {cost/2.0f} gold");
        }
        else
        {
            Console.WriteLine($"{item} cost {cost} gold");
            
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