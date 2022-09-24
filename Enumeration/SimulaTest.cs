using System.Threading.Channels;

namespace Enumeration;

public class SimulaTest
{
    public static void RunProgram()
    {
        ChestState chest = ChestState.Locked;

        while (true)
        {
            Console.Write($"The chest is {chest.ToString().ToLower()}. What do you want to do? ");
            string choice = Console.ReadLine() ?? throw new ArgumentNullException();

            switch (chest)
            {
                case ChestState.Locked when choice.ToLower() == "unlock":
                    chest = ChestState.Closed;
                    break;
                case ChestState.Closed when choice.ToLower() == "open":
                    chest = ChestState.Opened;
                    break;
                case ChestState.Opened when choice.ToLower() == "close":
                    chest = ChestState.Closed;
                    break;
                case ChestState.Closed when choice.ToLower() == "lock":
                    chest = ChestState.Locked;
                    break;
                default:
                        Console.WriteLine("input valid argument");
                    break;
            }
        }

    }

    

   
    enum ChestState {Opened, Closed, Locked}
    
}