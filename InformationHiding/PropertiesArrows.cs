namespace InformationHiding;

public static class PropertiesArrows
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
