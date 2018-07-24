public class Converter
{
    public static void Main(string args)
    {
        int input = int.Parse(Console.ReadLine());
        string result = Binery(input);
        Console.WriteLine(result);
    }

    private static string Binery(int number)
    {
        string reuslt = "";
        while (number > 0)
        {
            binary.Append(number % 2);
            number /= 2;
        }
        return result;
    }
}