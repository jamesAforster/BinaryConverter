using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        Stopwatch watch = new Stopwatch();
        watch.Start();
        List<int> values = GetArray(number);
        watch.Stop();
        Console.WriteLine("That took: " + watch.ElapsedTicks);

        string b = "";

        for (int i = 0; i < values.Count; i++)
        {
            StringBuilder sb = new StringBuilder(b);

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

        while (currentInt <= max && currentInt > 0)
        {
            list.Add(currentInt);
            currentInt *= 2;
        }

        list.Reverse();

        return list;
    }
}
