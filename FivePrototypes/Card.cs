namespace FivePrototypes;

public class Card
{
    public CardColors CardColor { get; }
    public CardRanks CardRank { get; }

    public Card(CardColors cardColor, CardRanks cardRank)
    {
        CardColor = cardColor;
        CardRank = cardRank;
    }

    public override string ToString() => $"The {CardColor} of {CardRank}";
}

public enum CardColors
{
    Red, Green, Blue, Yellow
};

public enum CardRanks
{
    One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand
};