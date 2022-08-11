using System;
using System.Collections.Generic;


namespace ListsAndArrays
{
    class Program
    {
        static void Main()
        {
            string[] weekDay = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] dayName = new string[] { "Miserable", "Taco", "Hump", "Thirsty", "Friendly", "Super", "Sweet" };
            int[] month = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] stringMonth = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            List<string> book = new List<string>();
            book.Add("Spring");book.Add("Summer");book.Add("Fall");book.Add("Winter");

            Console.WriteLine("Pick a number, 0 to 6, for the days of the week.");
            int dex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It's " + dayName[dex] + " " + weekDay[dex] + "!\n\nPick a number, 0 to 11, for the months of the year.");
            int index = Convert.ToInt32(Console.ReadLine());
            bool numOutRange = 0 > index ^ index > 11;

            do
            {
                if (numOutRange)
                {
                    Console.WriteLine("The number you chose is outside the index");
                    index = Convert.ToInt32(Console.ReadLine());
                    numOutRange = 0 > index ^ index > 11;
                }
            }
            while (numOutRange);

            Console.WriteLine("There are " + month[index] + " days in " + stringMonth[index] + ".\n\nPick a number, 0 to 3, for the seasons.");
            int page = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(book[page]);
            Console.ReadLine();

        }
    }
}
