namespace FivePrototypes;

public class Color
{
    public byte Red { get; }
    public byte Green { get; }
    public byte Blue { get; }

    public Color(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public override string ToString() => $"{Red}, {Green}, {Blue}";

    public static Color GetWhite => new Color(255, 255, 255);
    public static Color GetBlack => new Color(0, 0, 0);
    public static Color GetRed => new Color(255, 0, 0);
    public static Color GetOrange => new Color(255,165, 0);
    public static Color GetYellow => new Color(255, 255, 0);
    public static Color GetGreen => new Color(0, 128, 0);
    public static Color GetBlue => new Color(0, 0, 255);
    public static Color GetPurple => new Color(128, 0, 128);
}