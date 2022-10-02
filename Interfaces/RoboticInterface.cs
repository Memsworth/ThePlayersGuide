namespace Interfaces;

public class RobotTest
{
    public static void RunProgram()
    {
        Robot robot = new Robot();

        for (int i = 0; i < robot.Commands.Length; i++)
        {
            string? input = Console.ReadLine();
            IRobotCommands newCommand = input switch
            {
                "on" => new OnCommand(),
                "off" => new OffCommand(),
                "north" => new NorthCommand(),
                "south" => new SouthCommand(),
                "east" => new EastCommand(),
                "west" => new WestCommand(),
            };

            robot.Commands[i] = newCommand;
        }

        Console.WriteLine();
        
        robot.Run();
    }
}

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommands?[] Commands { get; } = new IRobotCommands?[3];

    public void Run()
    {
        foreach (IRobotCommands? commands in Commands)
        {
            commands.Run(this);
            Console.WriteLine($"[{X}  {Y}   {IsPowered}]");
        }
    }
}
public interface IRobotCommands
{
    void Run(Robot robot);
}

public class OnCommand : IRobotCommands
{
    public  void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommands
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : IRobotCommands
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y += 1;
        }
    }
}

public class SouthCommand : IRobotCommands
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y -= 1;
        }
    }
}

public class WestCommand : IRobotCommands
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X -= 1;
        }
    }

}

public class EastCommand : IRobotCommands
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X += 1;
        }
    }
}
