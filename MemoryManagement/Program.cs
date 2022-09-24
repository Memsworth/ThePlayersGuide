namespace MemoryManagement
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int manticoreHp = 10;
            int consolasHp = 15;
            int manticoreDistance =
                AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore?", 0,
                    100);
            int round = 0;
            
            Console.WriteLine("Player 2, it is your turn.");

            do
            {
                ++round;
                DisplayStatus(round, consolasHp, manticoreHp);
                int dps = 1;
                if (round % 15 == 0)
                    dps = 10;
                else if (round % 5 == 0 || round % 3 == 0)
                    dps = 3;
                
                DamageStatus(round, dps);
                int canonInput = AskForNumberInRange("Enter desired cannon range", 0, 100);
                
                if (HitStatus(canonInput, manticoreDistance))
                    manticoreHp -= dps;

                --consolasHp;
                
            } while (manticoreHp >= 1 && consolasHp >= 1);


            Console.WriteLine(WhoWon(manticoreHp) ? "city won" : "manticore won");
        }


        private static bool WhoWon(int hp)
        {
            return hp < 1;
        }
        private static bool HitStatus(int canonInput, int manticoreDistance)
        {
            if (canonInput > manticoreDistance)
            {
                Console.WriteLine("That round OVERSHOT the target.");
            }
            else if (canonInput < manticoreDistance)
            {
                Console.WriteLine("That round FELL SHORT of the target.");
            }
            else
            {
                Console.WriteLine("That round was a DIRECT HIT!");
                return true;
            }

            return false;
        }
        private static void DamageStatus(int round, int dps)
        {
            Console.ForegroundColor = default;
            Console.Write("The cannon is expected to deal ");

            if (round % 15 == 0) Console.ForegroundColor = ConsoleColor.Blue;
            else if (round % 5 == 0) Console.ForegroundColor = ConsoleColor.Yellow;
            else if (round % 3 == 0) Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = default;

            Console.Write($"{dps} damage ");
            
            Console.ForegroundColor = default;
            Console.WriteLine("this round.");
        }
        
        private static void DisplayStatus(int currentRound, int cityHp, int manticoreHp)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine($"STATUS: Round: {currentRound}   City: {cityHp}/15   Manticore: {manticoreHp}/10");
        }
        private static int AskForNumberInRange(string text, int min, int max)
        {
            int number = 0;
            while (true)
            {
                Console.Write($"{text} ");
                number = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
                if (number<max && number > min) break;
            }

            return number;
        }
    }
}