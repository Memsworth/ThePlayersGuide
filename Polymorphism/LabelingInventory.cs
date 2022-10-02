namespace Polymorphism;

public class Pack
{
    public int SumOfItems { get; }
    public float MaximumWeight { get; }
    public float MaximumVolume { get; }
    private InventoryItem[] _items;

    public int CurrentCount { get; private set; } = 0;
    public float CurrentWeight { get; private set; } = 0f;
    public float CurrentVolume { get; private set; } = 0f;
    
    public Pack(int sumOfItems, float maximumWeight, float maximumVolume)
    {
        SumOfItems = sumOfItems;
        MaximumWeight = maximumWeight;
        MaximumVolume = maximumVolume;
        _items = new InventoryItem[sumOfItems];
    }
    

    public bool Add(InventoryItem item)
    {
        if (CurrentCount + 1 > SumOfItems) return false;
        if (CurrentWeight + item.Weight > MaximumWeight) return false;
        if (CurrentVolume + item.Volume > MaximumVolume) return false;

        _items[CurrentCount] = item;
        CurrentCount++;
        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;
        return true;
    }

    public override string ToString()
    {
        string contents = String.Empty;
        for (int i = 0; i < CurrentCount; i++) 
        { 
            contents += _items[i].ToString() + " ";
        }

        return contents;
    }
}

public class InventoryItem
{
    public float Weight { get; }
    public float Volume { get; }

    public InventoryItem(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
    
    
}

public class Arrow : InventoryItem
{
    public Arrow() : base(0.1f, 0.05f)
    { }

    public override string ToString() => "Arrow";
}

public class Bow : InventoryItem
{
    public Bow() : base(1f, 4f)
    { }
    
    public override string ToString() => "Bow";

}

public class Rope : InventoryItem
{
    public Rope() : base(1f, 1.5f)
    { }
    
    public override string ToString() => "Rope";
}

public class Water : InventoryItem
{
    public Water() : base(2f, 3f)
    { }
    
    public override string ToString() => "Water";
}

public class FoodRations : InventoryItem
{
    public FoodRations() : base(1f, 0.5f)
    { }
    
    public override string ToString() => "Food";
}

public class Sword : InventoryItem
{
    public Sword() : base(5f, 3f)
    { }
    
    public override string ToString() => "Sword";

}