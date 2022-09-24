namespace Arrays;

public class ReplicatorDTo
{
    public static void RunProgram()
    {
        var values = new int[5];

        for (int i = 0; i <values.Length; i++)
        {
            Console.Write("Enter value: ");
            int val = int.Parse(Console.ReadLine()??throw new  ArgumentNullException());
            values[i] = val;
        }


        var values2 = new int[5];
        Array.Copy(values, values2, values.Length);

        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine($"arrayOne: {values[i]} \t arrayTwo: {values2[i]}");
        }

    }
}