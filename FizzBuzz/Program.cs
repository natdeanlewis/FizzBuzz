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
            Console.WriteLine("Enable Fizzes? [y/n]");
            bool fizzOn = Console.ReadLine().ToBool();
            Console.WriteLine("Enable Buzzes? [y/n]");
            bool buzzOn = Console.ReadLine().ToBool();
            Console.WriteLine("Enable Bangs? [y/n]");
            bool bangOn = Console.ReadLine().ToBool();
            Console.WriteLine("Enable Bongs? [y/n]");
            bool bongOn = Console.ReadLine().ToBool();
            Console.WriteLine("Enable Fezzes? [y/n]");
            bool fezzOn = Console.ReadLine().ToBool();
            Console.WriteLine("Enable reversals? [y/n]");
            bool reverseOn = Console.ReadLine().ToBool();
            Console.WriteLine("Ugh fine.");
            for (int i = 1; i <= max; i++)
            {
                List<string> parts = new List<string>();
                
                if (fizzOn)
                {
                    if (i % 3 == 0)
                    {
                        parts.Add("Fizz");
                    }
                }

                if (buzzOn)
                {
                    if (i % 5 == 0)
                    {
                        parts.Add("Buzz");
                    }
                }

                if (bangOn)
                {
                    if (i % 7 == 0)
                    {
                        parts.Add("Bang");
                    }
                }

                if (bongOn)
                {
                    if (i % 11 == 0)
                    {
                        parts.Clear();
                        parts.Add("Bong");
                    }
                }

                if (fezzOn)
                {
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
                }

                if (reverseOn)
                {
                    if (i % 17 == 0)
                    {
                        parts.Reverse();
                    }
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

    static class Extensions
    {
        public static bool ToBool(this string input)
        {
            if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else if (input.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            } 
            else
            {
                throw new Exception("The data is not in the correct format.");
            }
        }
    }
}
