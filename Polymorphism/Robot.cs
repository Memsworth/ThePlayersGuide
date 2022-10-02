namespace Polymorphism;

public class RobotTest
{
    public static void RunProgram()
    {
        Robot robot = new Robot();

        for (int i = 0; i < robot.Commands.Length; i++)
        {
            string? input = Console.ReadLine();
            RobotCommands newCommand = input switch
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
    public RobotCommands?[] Commands { get; } = new RobotCommands?[3];

    public void Run()
    {
        foreach (RobotCommands? commands in Commands)
        {
            commands.Run(this);
            Console.WriteLine($"[{X}  {Y}   {IsPowered}]");
        }
    }
}
public abstract class RobotCommands
{
    public abstract void Run(Robot robot);
}

public class OnCommand : RobotCommands
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommands
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommands
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y += 1;
        }
    }
}

public class SouthCommand : RobotCommands
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y -= 1;
        }
    }
}

public class WestCommand : RobotCommands
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X -= 1;
        }
    }

}

public class EastCommand : RobotCommands
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X += 1;
        }
    }
}
