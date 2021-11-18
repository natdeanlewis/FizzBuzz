using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("How many rounds of FizzBuzz are we playing today?");
            var max = int.Parse(Console.ReadLine());
            Console.WriteLine("Enable Fizzes? [y/n]");
            var fizzOn = Console.ReadLine().ToBool();
            Console.WriteLine("Enable Buzzes? [y/n]");
            var buzzOn = Console.ReadLine().ToBool();
            Console.WriteLine("Enable Bangs? [y/n]");
            var bangOn = Console.ReadLine().ToBool();
            Console.WriteLine("Enable Bongs? [y/n]");
            var bongOn = Console.ReadLine().ToBool();
            Console.WriteLine("Enable Fezzes? [y/n]");
            var fezzOn = Console.ReadLine().ToBool();
            Console.WriteLine("Enable reversals? [y/n]");
            var reverseOn = Console.ReadLine().ToBool();
            Console.WriteLine("Ugh fine.");
            for (var i = 1; i <= max; i++)
            {
                var parts = new List<string>();

                if (fizzOn)
                    if (i % 3 == 0)
                        parts.Add("Fizz");

                if (buzzOn)
                    if (i % 5 == 0)
                        parts.Add("Buzz");

                if (bangOn)
                    if (i % 7 == 0)
                        parts.Add("Bang");

                if (bongOn)
                    if (i % 11 == 0)
                    {
                        parts.Clear();
                        parts.Add("Bong");
                    }

                if (fezzOn)
                    if (i % 13 == 0)
                    {
                        var index = parts.FindIndex(a => a[0] == 'B');
                        if (index == -1)
                            parts.Add("Fezz");
                        else
                            parts.Insert(index, "Fezz");
                    }

                if (reverseOn)
                    if (i % 17 == 0)
                        parts.Reverse();

                var output = string.Join("", parts.ToArray());
                if (output == "") output = i.ToString();
                Console.WriteLine(output);
            }
        }
    }

    internal static class Extensions
    {
        public static bool ToBool(this string input)
        {
            if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
                return true;
            if (input.Equals("n", StringComparison.OrdinalIgnoreCase))
                return false;
            throw new Exception("The data is not in the correct format.");
        }
    }
}