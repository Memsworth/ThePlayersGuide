namespace DecisionMaking;

public class WatchTower
{
    public static void RunProgram()
    {
        Console.WriteLine("Enter Y value = ");
        int positionY = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
        
        Console.WriteLine("Enter X value = ");
        int positionX = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());


        switch (positionY)
        {
            case > 0:
                switch (positionX)
                {
                    case < 0:
                        Console.WriteLine("NW");
                        break;
                    case 0:
                        Console.WriteLine("N");
                        break;
                    case > 0:
                        Console.WriteLine("NE");
                        break;
                }

                break;
            case 0:
                switch (positionX)
                {
                    case < 0:
                        Console.WriteLine("W");
                        break;
                    case 0:
                        Console.WriteLine("The enemy is here");
                        break;
                    case  > 0:
                        Console.WriteLine("E");
                        break;
                }
                break;
            case < 0:
                switch (positionX)
                {
                    case < 0:
                        Console.WriteLine("SW");
                        break;
                    case 0:
                        Console.WriteLine("S");
                        break;
                    case > 0:
                        Console.WriteLine("SE");
                        break;
                }
                break;
        }
            
    }
}