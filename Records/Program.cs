// See https://aka.ms/new-console-template for more information

var swordA = new Sword(MaterialType.Iron, GemStoneType.Empty, 75.2f, 30.5f);
var swordB = new Sword(MaterialType.Iron, GemStoneType.Empty, 75.2f, 30.5f);
var swordC = swordA with { materialType = MaterialType.Iron, gemStoneType = GemStoneType.Amber };


Console.WriteLine(swordC);

public record Sword(MaterialType materialType, GemStoneType gemStoneType, float swordLength, float swordWidth);

public enum MaterialType
{
    Wood, Bronze, Iron, Steel, Binarium
};

public enum GemStoneType
{
    Empty, Emerald, Amber, Sapphire, Diamond, Bitstone
};