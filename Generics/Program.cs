
ColoredItem<Sword> sword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
ColoredItem<Bow> bow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
ColoredItem<Axe> axe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);


sword.Display();
bow.Display();
axe.Display();

public class ColoredItem<T>
{

    public ColoredItem(T itemType, ConsoleColor color)
    {
        Type = itemType;
        Color = color;
    }
    
    public T Type { get; }
    public ConsoleColor Color { get; }

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(ToString());
    }

    public override string ToString() => $"{Type}";
}

public class Sword
{
}

public class Bow
{
    
}

public class Axe
{
    
}