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
            

            /*try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing by two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }//
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }*/
        }
    }
}
