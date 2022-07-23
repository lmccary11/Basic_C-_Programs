using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report \n\nWhat is your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ". What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need any help? True or False?");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hours);
            Console.WriteLine("Thanks you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}
