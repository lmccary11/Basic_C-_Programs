using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> integers = new List<int>();
                integers.Add(80);
                integers.Add(100);
                integers.Add(140);
                integers.Add(200);
                integers.Add(260);
                Console.WriteLine("Pick a number.");
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(integers[i] / number);
                }
                Console.ReadLine();

            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            finally
            {
                Console.WriteLine("Tried and caught.");
                Console.ReadLine();
            }
            
        }
    }
}
