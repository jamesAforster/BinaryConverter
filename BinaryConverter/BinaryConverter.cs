using System.Diagnostics;

using System.Text;

public static class BinaryConverter
{
    public static void Run()
    {
        Console.Write("Please give me a number to turn into binary: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int result))
        {
            Console.WriteLine("It must be an integer.");
            Run();
        }
        
        Stopwatch watch = new Stopwatch();
        watch.Start();
        string value = GetBinaryValue(result);
        watch.Stop();
        Console.WriteLine(watch.Elapsed);   

        Console.WriteLine("Oi fuck nugget: " + value);

        Run();
    }

    private static string GetBinaryValue(int number)
    {
        List<int> values = GetArray(number);

        char[] array = new char[values.Count];

        for (int i = 0; i < values.Count; i++)
        {
            if (number >= values[i])
            {
                number -= values[i];
                array[i] = '0';
            }
            else
            {
                array[i] = '1';
            }
        }

        return array.ToString();
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

    private static List<int> GetArrayLinq(int max)
    {
        return Enumerable
            .Range(0, int.MaxValue)
            .Select(x => (int)Math.Pow(2, x))
            .TakeWhile(x => x <= max)
            .Reverse()
            .ToList();
    }
}
