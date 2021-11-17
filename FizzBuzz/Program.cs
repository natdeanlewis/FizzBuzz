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
            for (int i = 1; i < 201; i++)
            {
                var output = "";
                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                if (i % 13 == 0)
                {
                    output += "Fezz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }
                if (i % 7 == 0)
                {
                    output += "Bang";
                }
                if (i % 11 == 0)
                {
                    output = "Bong";
                    if (i % 13 == 0)
                    {
                        output = "Fezz" + output;
                    }
                }
                if (output == "")
                {
                    output = i.ToString();
                }
                Console.WriteLine(output);
            }
                

                
/*            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else if (i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
*/
        }
    }
}