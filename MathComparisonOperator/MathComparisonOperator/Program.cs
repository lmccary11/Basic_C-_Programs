using System;


namespace MathComparisonOperator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program \nWhat is Person 1's hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("What is Person 1's Hours worked per week?");
            string hoursWorked1 = Console.ReadLine();
            int hourly1 = Convert.ToInt32(hourlyRate1);
            int hours1 = Convert.ToInt32(hoursWorked1);
            int salary1 = hourly1 * hours1 * 52;
            Console.WriteLine("What is Person 2's hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("What is Person 2's Hours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            int hourly2 = Convert.ToInt32(hourlyRate2);
            int hours2 = Convert.ToInt32(hoursWorked2);
            int salary2 = hourly2 * hours2 * 52;
            bool greaterthan = salary1 > salary2;
            string sal1 = Convert.ToString(salary1);
            string sal2 = Convert.ToString(salary2);
            string moreThan = Convert.ToString(greaterthan);
            Console.WriteLine("Annual Salary of Person 1:\n" + sal1 + "\nAnnual Salary of Person 2:\n" + sal2);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + moreThan);
            Console.ReadLine();



        }
    }
}
