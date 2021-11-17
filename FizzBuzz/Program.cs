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
            for (int i = 1; i <= 300; i++)
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