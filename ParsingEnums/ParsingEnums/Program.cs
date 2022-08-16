using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum weekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string dayEntry = Console.ReadLine();
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine((weekDays)i);
                    Console.ReadLine();

                    string wkdays = Convert.ToString((weekDays)i);
                    if (dayEntry == wkdays)
                    {
                        weekDays weekdays = (weekDays)Enum.Parse(typeof(weekDays), dayEntry);
                        Console.WriteLine(weekdays);
                        Console.ReadLine();
                        break;
                    }
                    else if (i == 6)
                    {
                        throw new Exception("Not a day of the week.");
                    }
                    else { }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.", ex.Message);
                Console.ReadLine();
            }


        }
    }
}
