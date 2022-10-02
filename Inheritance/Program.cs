namespace Inheritance
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack(10, 20, 30);

            while (true)
            {
                DisplayMenu(pack);

                int choice = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

                InventoryItem item = choice switch
                {
                    1 => new Arrow(),
                    2 => new Bow(),
                    3 => new Rope(),
                    4 => new Water(),
                    5 => new FoodRations(),
                    6 => new Sword()
                };


                if (!pack.Add(item))
                {
                    Console.WriteLine("Couldn't add item");
                }
            }
        }

        private static void DisplayMenu(Pack pack)
        {
            Console.WriteLine(
                $"Pack is currently at {pack.CurrentCount}/{pack.SumOfItems} items, " +
                $"{pack.CurrentWeight}/{pack.MaximumWeight} weight, " +
                $"and {pack.CurrentVolume}/{pack.MaximumVolume} volume.");
            
            Console.WriteLine("What do you want to add?");
            Console.WriteLine("1 - Arrow");
            Console.WriteLine("2 - Bow");
            Console.WriteLine("3 - Rope");
            Console.WriteLine("4 - Water");
            Console.WriteLine("5 - Food");
            Console.WriteLine("6 - Sword");
        }
    }
}