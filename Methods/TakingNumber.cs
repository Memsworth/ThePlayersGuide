namespace Methods;

public class TakingNumber
{
        public static void RunProgram()
        {
                int result = AskForNumberInRange("What is your age?", 1, 150);
                Console.WriteLine($"You are {result} years old");
        }

        private static int AskForNumber(string text)
        {
                Console.WriteLine(text);
                var numberInput = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
                return numberInput;
        }

        private static int AskForNumberInRange(string text, int min, int max)
        {

                int number = 0;
                while (true)
                {
                        Console.WriteLine(text);
                        number = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
                        if (number<max && number > min) break;
                }

                return number;
        }
}