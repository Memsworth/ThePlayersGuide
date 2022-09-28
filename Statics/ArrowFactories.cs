namespace Statics;

public static class ArrowFactories
{
    public static void RunProgram()
    {

        Console.WriteLine("What type of arrow? 1= elite 2=beginner 3= marksman 4= custom");
        Arrow myArrow = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException()) switch
        {
            1 => Arrow.CreateEliteArrow(),
            2 => Arrow.CreateBeginnerArrow(),
            3 => Arrow.CreateMarksmanArrow(),
            4 => GetCustomArrow()
        };
        Console.WriteLine($"The arrow costs {myArrow.GetCost():N} gold");
    }


    public static float GetShaftLength() => AskForNumberInRange("Enter arrow length between 60 to 100cm", 59, 101);
    public static ArrowHead GetArrowHeadFromUser()
    {
        Console.WriteLine("Steel, Wood, Obsidian");
        string input = Console.ReadLine() ?? throw new ArgumentNullException();

        ArrowHead arrowHead = input.ToLower() switch
        {
            "steel" => ArrowHead.Steel,
            "wood" => ArrowHead.Wood,
            "obsidian" => ArrowHead.Obsidian,
            _ => ArrowHead.Wood

        };

        return arrowHead;
    }

    public static Fletching GetFletchingFromUser()
    {
        Console.WriteLine("Plastic, TurkeyFeathers, GooseFeathers");
        string input = Console.ReadLine() ?? throw new ArgumentNullException();

        Fletching fletching = input.ToLower() switch
        {
            "plastic" => Fletching.Plastic,
            "turkey feathers" => Fletching.TurkeyFeathers,
            "goose feathers" => Fletching.GooseFeathers,
            _ => Fletching.GooseFeathers

        };

        return fletching;
    }

    private static Arrow GetCustomArrow() =>
        new Arrow(GetArrowHeadFromUser(), GetFletchingFromUser(), GetShaftLength());
    private static float AskForNumberInRange(string text, float min, float max)
    {
        float number = 0;
        while (true)
        {
            Console.Write($"{text} ");
            number = float.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
            if (number<max && number > min) break;
        }

        return number;
    }
}

public enum ArrowHead
{
    Steel, Wood, Obsidian
}

public enum Fletching
{
    Plastic, TurkeyFeathers, GooseFeathers
}

public class Arrow
{
    private ArrowHead _ArrowHead { get; }
    private Fletching _Fletching { get; }
    private float _ShaftLength { get; }

    public Arrow(ArrowHead arrowHead, Fletching fletching, float shaftLength)
    {
        _ArrowHead = arrowHead;
        _Fletching = fletching;
        _ShaftLength = shaftLength;
    }

    public float GetCost()
    {
        float cost = 0.0f;

        cost += 0.05f * _ShaftLength;

        cost += _ArrowHead switch
        {
            ArrowHead.Steel =>  10f,
            ArrowHead.Wood => 3f,
            ArrowHead.Obsidian => 5f
        };

        cost += _Fletching switch
        {
            Fletching.Plastic => 10f,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3
        };

        return cost;
    }

    public static Arrow CreateEliteArrow() => new Arrow(ArrowHead.Steel, Fletching.Plastic, 95f);
    public static Arrow CreateBeginnerArrow() => new Arrow(ArrowHead.Wood, Fletching.GooseFeathers, 75f);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowHead.Steel, Fletching.GooseFeathers, 65f);

}