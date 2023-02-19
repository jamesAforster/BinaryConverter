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

    public static string GetBinaryValue(int number)
    {
        int[] values = { 128, 64, 32, 16, 8, 4, 2, 1 }; // 256 possible values

        string b = "00000000";


        for (int i = 0; i < b.Length; i++)
        {
            if (number >= values[i])
            {
                number -= values[i];
                StringBuilder sb = new StringBuilder(b);
                sb[i] = '1';
                b = sb.ToString();

                if (number == 0)
                {
                    return sb.ToString();
                }
            }
        }

        return b.ToString();
    }
}
