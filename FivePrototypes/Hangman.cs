namespace FivePrototypes;



public class HangmanGame
{
    public string WordToGuess { get; private set; }
    public bool[] LettersRevealed { get; private set; }
    
    public int RemainingGuess { get; private set; }
    public List<char> WrongGuess { get; private set; }

    public HangmanGame(string wordsToGuess)
    {
        WordToGuess = wordsToGuess;
        LettersRevealed = new bool[wordsToGuess.Length];
        WrongGuess = new List<char>();
    }

    public void Run()
    {
        HangmanRenderer renderer = new HangmanRenderer();
        if (HasWon() && HasLost())
        {
            renderer.Render(this);
        }
    }

    private bool HasLost()
    {
        return false;
    }

    private bool HasWon()
    {
        throw new NotImplementedException();
    }
}



public class WordDictionary
{
    public string GetRandomWord()
    {
        Random random = new Random();

        return random.Next(3) switch
        {
            0 => "taco",
            1=> "cheesecake",
            2=> "burger",
        };
    }
}

public class HangmanRenderer
{
    public void Render(HangmanGame game)
    {
        Console.Write("Word: ");
        for (int i = 0; i < game.LettersRevealed.Length; i++)
        {
            Console.Write(game.LettersRevealed[i] ? $" {game.WordToGuess[i]} " : " _ ");
        }

        Console.Write($" | Remaining: {game.RemainingGuess}  | ");
            
    }
}