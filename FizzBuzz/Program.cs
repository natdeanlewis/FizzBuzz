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
            for (int i = 1; i < 301; i++)
            {
                List<string> parts = new List<string>();
                
                if (i % 3 == 0)
                {
                    parts.Add("Fizz");
                }
                if (i % 13 == 0)
                {
                    parts.Add("Fezz");
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
                    parts.RemoveAll(x => x != "Fezz");
                    parts.Add("Bong");
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