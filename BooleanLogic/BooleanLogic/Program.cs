using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is you age?");
            string ageResponse = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? True or False");
            string duiResponse = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsResponse = Console.ReadLine();
            int age = Convert.ToInt32(ageResponse);
            bool dui = Convert.ToBoolean(duiResponse);
            int tickets = Convert.ToInt32(ticketsResponse);
            bool ageLimit = age > 15;
            bool ticketLimit = tickets <= 3;
            bool qual = !dui && ageLimit && ticketLimit;
            Console.WriteLine("Qualified?\n" + Convert.ToString(qual));
            Console.ReadLine();
        }
    }
}
