namespace Looping;

public class Prototype
{
    public static void RunProgram()
    {
        int targetNumber;
        int hunterNumber;

        do
        {
            Console.Write($"user 1, enter a number between 0 to 100:   ");
            targetNumber = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
        } while (targetNumber is < 0 or > 100);

        Console.WriteLine($"user 2, guess a number");

        do
        {
            Console.Write("What is your next guess? ");
            hunterNumber = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

            if (hunterNumber > targetNumber)
            {
                Console.WriteLine($"{hunterNumber} is too high");
            }

            else if (hunterNumber < targetNumber)
            { 
                Console.WriteLine($"{hunterNumber} is too low");
            }
                
        } while (hunterNumber != targetNumber);


        if (hunterNumber == targetNumber)
        {
            Console.WriteLine("You guessed right");
        }
    }
    
}