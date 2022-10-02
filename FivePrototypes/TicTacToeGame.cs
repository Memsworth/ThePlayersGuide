using System.Threading.Channels;

namespace FivePrototypes;

public class TicTacToeGame
{
    public void Run()
    {
        TicTacToeBoard gameBoard = new TicTacToeBoard();
        TicTacToeGameRender gameRender = new TicTacToeGameRender();
        TicTacToeWinCondition condition = new TicTacToeWinCondition();
        var playerOne = new TicTacToePlayer(GetPlayerInfo(), TicTacToeCell.X);
        var playerTwo = new TicTacToePlayer(GetPlayerInfo(), TicTacToeCell.O);
        int round = 0;

        while (round < 9)
        {
            gameRender.RenderGame(gameBoard);
            gameBoard.Set(playerOne.GetLocation(),playerOne.PlayerSymbol);
            if (condition.WinCondition(gameBoard, playerOne))
            {
                gameRender.RenderGame(gameBoard);
                Console.WriteLine($"{playerOne.PlayerName} with his symbol {playerOne.PlayerSymbol} WON!");
                return;;
            }
            
            gameRender.RenderGame(gameBoard);
            gameBoard.Set(playerTwo.GetLocation(),playerTwo.PlayerSymbol);
            if (condition.WinCondition(gameBoard, playerTwo))
            { 
                gameRender.RenderGame(gameBoard);
                Console.WriteLine($"{playerTwo.PlayerName} with his symbol {playerTwo.PlayerSymbol} WON!");
                return;
            }

            round++;
        }

        gameRender.RenderGame(gameBoard);
        Console.WriteLine("Draw");
    }

    private static string GetPlayerInfo()
    {
        Console.WriteLine("Enter name: ");
        string nameInput = Console.ReadLine() ?? throw new ArgumentNullException();
        return nameInput;
    }
}


public class TicTacToeWinCondition
{
    public bool WinCondition(TicTacToeBoard board, TicTacToePlayer player)
    {
        if (board.GameBoard[0, 0] == player.PlayerSymbol && board.GameBoard[0, 1] == player.PlayerSymbol &&
            board.GameBoard[0, 2] == player.PlayerSymbol) return true;
        if (board.GameBoard[1, 0] == player.PlayerSymbol && board.GameBoard[1, 1] == player.PlayerSymbol &&
            board.GameBoard[1, 2] == player.PlayerSymbol) return true;
        if (board.GameBoard[2, 0] == player.PlayerSymbol && board.GameBoard[2, 1] == player.PlayerSymbol &&
            board.GameBoard[2, 2] == player.PlayerSymbol) return true;

        
        if (board.GameBoard[0, 0] == player.PlayerSymbol && board.GameBoard[1, 0] == player.PlayerSymbol &&
            board.GameBoard[2, 0] == player.PlayerSymbol) return true;
        if (board.GameBoard[0, 1] == player.PlayerSymbol && board.GameBoard[1, 1] == player.PlayerSymbol &&
            board.GameBoard[2, 1] == player.PlayerSymbol) return true;
        if (board.GameBoard[0, 2] == player.PlayerSymbol && board.GameBoard[1, 2] == player.PlayerSymbol &&
            board.GameBoard[2, 2] == player.PlayerSymbol) return true;

        if (board.GameBoard[0, 0] == player.PlayerSymbol && board.GameBoard[1, 1] == player.PlayerSymbol &&
            board.GameBoard[2, 2] == player.PlayerSymbol) return true;
        if (board.GameBoard[0, 2] == player.PlayerSymbol && board.GameBoard[1, 1] == player.PlayerSymbol &&
            board.GameBoard[2, 0] == player.PlayerSymbol) return true;

        return false;
    }
}

public class TicTacToePlayer
{
    public string PlayerName { get; }
    
    private TicTacToeCell _playerSymbol;
    public TicTacToeCell PlayerSymbol
    {
        get => _playerSymbol;
        private set
        {
            if (value != TicTacToeCell.Empty)
            {
                _playerSymbol = value;
            }
        }
    }

    public BoardLocation GetLocation()
    {
        return Console.ReadLine() switch
        {
            "1" => new BoardLocation(0,0),
            "2" => new BoardLocation(0,1),
            "3" => new BoardLocation(0,2),
            "4" => new BoardLocation(1,0),
            "5" => new BoardLocation(1,1),
            "6" => new BoardLocation(1,2),
            "7" => new BoardLocation(2,0),
            "8" => new BoardLocation(2,1),
            "9" => new BoardLocation(2,2),
            _ => throw new ArgumentException()
        };
    }
    public TicTacToePlayer(string playerName, TicTacToeCell playerSymbol)
    {
        PlayerName = playerName;
        PlayerSymbol = playerSymbol;
    }
}


public class TicTacToeGameRender
{
    public void RenderGame(TicTacToeBoard board)
    {
        char[,] gameBoard = new char[3,3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                gameBoard[i,j] = GetCharType(board.GameBoard[i,j]);
            }
        }
        
        DisplayBoard(gameBoard);
    }

    private static void DisplayBoard(char[,] gameBoard)
    {
        Console.WriteLine();
        Console.WriteLine("\tTic Tac Toe\n");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {gameBoard[0, 0]}  |  {gameBoard[0, 1]}  |  {gameBoard[0, 2]} ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($" {gameBoard[1, 0]}   |  {gameBoard[1, 1]}  |  {gameBoard[1, 2]} ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($" {gameBoard[2, 0]}   |  {gameBoard[2, 1]}  |  {gameBoard[2, 2]} ");
        Console.WriteLine("     |     |     \n");
    }

    private char GetCharType(TicTacToeCell cell)
    {
        return cell switch
        {
            TicTacToeCell.Empty => ' ',
            TicTacToeCell.O => 'O',
            TicTacToeCell.X => 'X'
        };
    }
}
public class TicTacToeBoard
{
    public TicTacToeCell[,] GameBoard { get; private set; }

    public void Set(BoardLocation location, TicTacToeCell cell)
    {
        if (GameBoard[location.Row, location.Column] == TicTacToeCell.Empty && cell != TicTacToeCell.Empty)
        {
            GameBoard[location.Row, location.Column] = cell;
        }
        else
        {
            Console.WriteLine($"Not Allowed");
        }
    }
    public TicTacToeBoard()
    {
        GameBoard = new TicTacToeCell[3, 3];
    }
}

public class BoardLocation
{
    public int Row { get; }
    public int Column { get; }

    public BoardLocation(int row, int column)
    {
        Row = row;
        Column = column;
    }
}
public enum TicTacToeCell
{
    Empty, O, X
}