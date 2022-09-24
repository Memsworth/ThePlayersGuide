namespace Tuples;

public class SimulaSoup
{
    public static void RunProgram()
    {
        var userDish = GetDishFromUser();
        PrintDish(userDish);
    }

    
    private static void PrintDish((SoupType type, MainIngredient mainIngredient, Seasoning seasoning) userDish)
    {
        Console.WriteLine($"{userDish.seasoning} {userDish.mainIngredient} {userDish.type}");
    }

    private static (SoupType, MainIngredient, Seasoning) GetDishFromUser()
    {
        var dishType = GetSoupTypeFromUser();
        var mainIngredient = GetMainIngredientFromUser();
        var seasoning = GetSeasoningFromUser();

        return (dishType, mainIngredient, seasoning);
    }

    private static SoupType GetSoupTypeFromUser()
    {
        Console.WriteLine("Soup, Stew Gumbo");
        string input = Console.ReadLine() ?? throw new ArgumentNullException();
        SoupType soupType = input.ToLower() switch
        {
            "soup" => SoupType.Soup,
            "stew" => SoupType.Stew,
            "gumbo" => SoupType.Gumbo,
            _ => SoupType.Gumbo
        };

        return soupType;
    }
    
    private static MainIngredient GetMainIngredientFromUser()
    {
        Console.WriteLine("Mushrooms, Chicken, Carrots, Potatoes");
        string input = Console.ReadLine() ?? throw new ArgumentNullException();
        MainIngredient ingredient = input.ToLower() switch
        {
            "mushroom" => MainIngredient.Mushrooms,
            "chicken" => MainIngredient.Chicken,
            "carrots" => MainIngredient.Carrots,
            "potatoes" => MainIngredient.Potatoes,
            _ => MainIngredient.Mushrooms
        };

        return ingredient;
    }

    private static Seasoning GetSeasoningFromUser()
    {
        Console.WriteLine("Sweet, Spicy, Salty");
        string input = Console.ReadLine() ?? throw new ArgumentNullException();
        Seasoning seasoning = input.ToLower() switch
        {
            "sweet" => Seasoning.Sweet,
            "salty" => Seasoning.Salty,
            "spicy" => Seasoning.Spicy,
            _ => Seasoning.Spicy
        };

        return seasoning;

    }
    enum SoupType
    {
        Soup, Stew, Gumbo
    }

    enum MainIngredient
    {
        Mushrooms, Chicken, Carrots, Potatoes
    }

    enum Seasoning
    {
        Spicy, Salty, Sweet
    }
}