using System;


namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \nPlease enter the package weight.");
            string weightEntry = Console.ReadLine();
            Console.WriteLine("Please enter the package width.");
            string widthEntry = Console.ReadLine();
            Console.WriteLine("Please enter the package height.");
            string heightEntry = Console.ReadLine();
            Console.WriteLine("Please enter the package length.");
            string lengthEntry = Console.ReadLine();
            int weight = Convert.ToInt32(weightEntry);
            int width = Convert.ToInt32(widthEntry);
            int height = Convert.ToInt32(heightEntry);
            int length = Convert.ToInt32(lengthEntry);
            bool tooBig = weight > 50 || height > 50 || length > 50;
            Console.WriteLine("Your estimated total for shipping this package is $" + total)
        }
    }
}
