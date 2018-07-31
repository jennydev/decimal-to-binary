public class Converter
{
    public static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        string result = Binary(input);
        Console.WriteLine(result);
    }

    private static string Binary(int number)
    {
        string result = "";
        while (number > 0)
        {
            result = (number % 2) + result;
            number /= 2;
        }
        return result.Length == 0 ? "0" : result;
    }
}