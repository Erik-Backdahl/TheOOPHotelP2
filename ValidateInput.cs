public class ValidateInput
{
    public static int ValidateInt()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                return userNumber;
            }
            else
            {
                Console.WriteLine("Du måste skriva in en giltig siffra");
            }
        }
    }
    public static string ValidateString()
    {
        while (true)
        {
            string? userString = Console.ReadLine();
            if (!string.IsNullOrEmpty(userString) && !string.IsNullOrWhiteSpace(userString))
            {
                return userString;
            }
            else
            {
                Console.WriteLine("Du måste skriva in en giltig string");
            }

        }
    }
    public static DateTime ValidateDateTime()
    {
        while (true)
        {
            if (DateTime.TryParse(Console.ReadLine(), out DateTime time))
            {
                return time;
            }
            else
            {
                Console.WriteLine("du måste skriva tiden i ett valid format (yyyy-mm-dd)");
            }
        }
        
    }
}