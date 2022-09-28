namespace FivePrototypes;

public class PuzzleTest
{
    public static void RunProgram()
    {
        
    }
}




public class Board
{
    public int Row { get; }
    public int Column { get; }
    public int[,] _Board { get; private set; }
    
    public Board(int row, int column)
    {
        _Board = new int[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                _Board[i, j] = i * 4 + j + 1;
            }
        }
    }

}