namespace FivePrototypes;
public class RockPaperScissors
{
    public static void RunProgram()
    {
        while (true)
        {
            Game.StartGame();
        }
    }
}

public static class Game
{
    public static void StartGame()
    {
        Console.Write("Player 1: ");
        Player playerOne = new Player();
        Console.Write("Player 2: ");
        Player playerTwo = new Player();

        int result = GetWinCondition(playerOne, playerTwo);

        switch (result)
        {
            case 0:
                Console.WriteLine("Draw!");
                break;
            case 1:
                Console.WriteLine($"Player 1 WON!!!");
                break;
            case 2:
                Console.WriteLine($"Player 2 WON!!!");
                break;
        }
    }

    private static int GetWinCondition(Player playerOne, Player playerTwo)
    {
        int result = 0;
        switch (playerOne.PlayerHand)
        {
           case Hand.Rock when playerTwo.PlayerHand == Hand.Scissors:
           case Hand.Paper when playerTwo.PlayerHand == Hand.Rock:
           case Hand.Scissors when playerTwo.PlayerHand == Hand.Paper:
               result = 1;
               break;
           
           default:
               result = 2;
               break;
        }
    
        return playerOne.PlayerHand == playerTwo.PlayerHand ? 0 : result;
    }
}

public class Player
{
    public Hand PlayerHand { get; private set; }

    public Player()
    {
        PlayerHand = GetPlayerHand();
    }

    private Hand GetPlayerHand()
    {
        string input = Console.ReadLine() ?? throw new ArgumentNullException();
        Hand playerHand = input switch
        {
            "rock" => Hand.Rock,
            "paper" => Hand.Paper,
            "scissor" => Hand.Scissors,
            _ => throw new ArgumentException()
        };

        return playerHand;
    }
}

public enum Hand
{
    Rock, Paper, Scissors
};