namespace Classes;

public static class VinFletcherArrows
{
    public static void RunProgram()
    {
        var myArrow = new Arrow();
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
    public ArrowHead _arrowHead;
    public Fletching _fletching;
    public float _shaftLength;

    public Arrow()
    {
        _arrowHead = VinFletcherArrows.GetArrowHeadFromUser();
        _fletching = VinFletcherArrows.GetFletchingFromUser();
        _shaftLength = VinFletcherArrows.GetShaftLength();
    }

    public float GetCost()
    {
        float cost = 0.0f;

        cost += 0.05f * _shaftLength;

        cost += _arrowHead switch
        {
            ArrowHead.Steel =>  10f,
            ArrowHead.Wood => 3f,
            ArrowHead.Obsidian => 5f
        };

        cost += _fletching switch
        {
            Fletching.Plastic => 10f,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3
        };

        return cost;
    }
}