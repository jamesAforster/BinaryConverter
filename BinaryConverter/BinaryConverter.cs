using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class BinaryConverter
{
    public static void Run()
    {
        Console.Write("Give me a number to turn into binary then you fucking idiot: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int result))
        {
            Console.WriteLine("It must be an integer you twat.");
            Run();
        }

        string value = GetBinaryValue(result);

        Console.WriteLine("Oi fuck nugget: " + value);

        Run();
    }

    private static string GetBinaryValue(int number)
    {
        List<int> values = GetArray(number);

        string b = "";

        for (int i = 0; i <= values.Count; i++)
        {
            StringBuilder sb = new StringBuilder(b);

            if (i == values.Count)
            {
                return sb.ToString();
            }

            if (number >= values[i])
            {
                number -= values[i];
                sb.Append('1');
                b = sb.ToString();
            }
            else
            {
                sb.Append('0');
                b = sb.ToString();
            }
        }

        return b.ToString();
    }

    private static List<int> GetArray(int max)
    {
        List<int> list = new List<int>();

        int currentInt = 1;

        while(currentInt <= max)
        {
            if (currentInt < 0) // To guard against Int.MaxValue wraparound
            {
                return list;
            }

            list.Add(currentInt);
            currentInt *= 2;
        }

        list.Reverse();

        return list;
    }
   
}
