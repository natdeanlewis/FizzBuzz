using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Xml;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rounds of FizzBuzz are we playing today?");
            int max = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ugh fine.");
            for (int i = 1; i <= max; i++)
            {
                List<string> parts = new List<string>();
                
                if (i % 3 == 0)
                {
                    parts.Add("Fizz");
                }
                if (i % 5 == 0)
                {
                    parts.Add("Buzz");
                }
                if (i % 7 == 0)
                {
                    parts.Add("Bang");
                }
                if (i % 11 == 0)
                {
                    parts.Clear();
                    parts.Add("Bong");
                }
                if (i % 13 == 0)
                {
                    int index = parts.FindIndex(a => a[0] == 'B');
                    if (index == -1)
                    {
                        parts.Add("Fezz");
                    } else 
                    {
                        parts.Insert(index, "Fezz");
                    }
                }
                if (i % 17 == 0)
                {
                    parts.Reverse();
                }
                string output = String.Join("", parts.ToArray());
                if (output == "")
                {
                    output = i.ToString();
                }
                Console.WriteLine(output);
            }
        }
    }
}