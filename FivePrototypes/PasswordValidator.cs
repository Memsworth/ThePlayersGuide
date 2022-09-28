namespace FivePrototypes;
public static class PasswordTest
{
    public static void RunProgram()
    {
        while (true)
        {
            Console.Write("Enter password:  ");
            string input = Console.ReadLine() ?? throw new ArgumentNullException();

            Console.WriteLine(PasswordValidator.IsValid(input) ? "Password is VALID" : "Password is INVALID");
        }
    }
}

public static class PasswordValidator
{
    public static bool IsValid(string input)
    {
        bool containsUpper = false;
        bool containsLower = false;
        bool containsDigit = false;

        if (input.Length is < 6 or > 13) return false;
        if (input.Contains('T')) return false;
        if (input.Contains('&')) return false;
            
        foreach (char letter in input)
        {
            if (char.IsUpper(letter))
                containsUpper = true;

            else if (char.IsLower(letter))
                containsLower = true;

            else if (char.IsDigit(letter))
                containsDigit = true;
        }

        return containsUpper && containsLower && containsDigit;
    }
}