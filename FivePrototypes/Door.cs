namespace FivePrototypes;

public class DoorTest
{
    public static void RunProgram()
    {
        var door = new Door(1234);

        while (true)
        {
            Console.WriteLine(door);
            Console.Write("What you want to do? ");
            string input = Console.ReadLine() ?? throw new ArgumentNullException();

            int inputPass;
            switch (input)
            {
                case "open":
                    Console.WriteLine(door.Open() ? "Door is opening....." : "Nothing happened");
                    break;
                case "close":
                    Console.WriteLine(door.Close() ? "Door is closing....." : "Nothing happened");
                    break;
                case "lock":
                    Console.WriteLine(door.Lock() ? "Door is locking....." : "Nothing happened");
                    break;
                case "unlock":
                    Console.Write("Enter pass: ");
                    inputPass = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
                    Console.WriteLine(door.Unlock(inputPass) ? "Door is unlocking....." : "Nothing happened");
                    break;
                case "change passcode":
                    Console.Write("Enter pass: ");
                    inputPass = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
                    Console.Write("Enter new pass: ");
                    int updatePass = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
                    Console.WriteLine(door.ChangePassCode(inputPass, updatePass) ? "Door is unlocking....." : "Nothing happened");
                    break;
                default:
                    Console.WriteLine("not a valid input");
                    break;

            }
        }
    }
}

public class Door
{
    public DoorStates DoorState { get; private set; } = DoorStates.Locked;
    public int DoorPass { get; private set; }


    public Door(int doorPass)
    {
        DoorPass = doorPass;
    }


    public bool Open()
    {
        if (DoorState != DoorStates.Closed) return false;
        DoorState = DoorStates.Open;
        return true;
    }


    public bool Close()
    {
        if (DoorState != DoorStates.Open) return false;
        DoorState = DoorStates.Closed;
        return true;
    }


    public bool Lock()
    {
        if (DoorState != DoorStates.Closed) return false;
        DoorState = DoorStates.Locked;
        return true;
    }

    public bool Unlock(int passCode)
    {
        if (DoorState != DoorStates.Locked) return false;
        if (passCode != DoorPass) return false;
        DoorState = DoorStates.Closed;
        return true;
    }
    
    
    public bool ChangePassCode(int initialPass, int updatePass)
    {
        if (initialPass != DoorPass) return false;
        DoorPass = updatePass; 
        return true;
    }

    public override string ToString() => $"The door is {DoorState.ToString().ToLower()}";
}


public enum DoorStates
{
    Locked, Closed, Open
};