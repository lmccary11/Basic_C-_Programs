using System;


namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \nPlease enter the package weight.");
            string weightEntry = Console.ReadLine();
            int weight = Convert.ToInt32(weightEntry);
            bool tooHeavy = weight > 50;
            if (tooHeavy)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width.");
                string widthEntry = Console.ReadLine();
                Console.WriteLine("Please enter the package height.");
                string heightEntry = Console.ReadLine();
                Console.WriteLine("Please enter the package length.");
                string lengthEntry = Console.ReadLine();
                int width = Convert.ToInt32(widthEntry);
                int height = Convert.ToInt32(heightEntry);
                int length = Convert.ToInt32(lengthEntry);
                bool tooBig = width + height + length > 50;
                int totalCalc = (width * height * length * weight) / 100;
                string total = Convert.ToString(totalCalc);
                if (tooBig)
                {
                    Console.WriteLine("Package too Big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("Your estimated total for shipping this package is $" + total + ".00\nThanks");
                    Console.ReadLine();
                }
            }
        }
    }
}