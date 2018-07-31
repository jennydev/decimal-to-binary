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

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		List<int> numbers = new List<int>();
		
		for(int i = 0;i < n; i++ )
		{
			string binaryNumb = Console.ReadLine();
			
			numbers.Add(Convert.ToInt32(binaryNumb, 2));
		}
		
		foreach(var num in numbers )
		{
			Console.WriteLine(num);
		}
	}
}

//Resheni s malko korekcia ot kolegi i spravka v neta