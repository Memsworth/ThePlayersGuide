namespace Methods;
public static class Countdown
{
    public static void RunProgram()
    {
        DoCountDown(10);
    }

    private static void DoCountDown(int number)
    {
        if (number == 0)
        {
            Console.WriteLine("BOOM");
        }
        else
        {
            Console.WriteLine(number); 
            DoCountDown(number - 1);
        }
    }
}