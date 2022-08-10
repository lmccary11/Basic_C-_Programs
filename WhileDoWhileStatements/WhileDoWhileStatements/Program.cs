using System;


namespace WhileDoWhileStatements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the online portal.\nWhat day would like to visit the park?");
            string day = Console.ReadLine();
            bool open = day == "Monday" ^ day == "Friday" ^ day == "Saturday" ^ day == "Sunday";
            while (!open)
            {
                Console.WriteLine("The park isn't not open on this day. Please pick another day.\nWhat day would like to visit the park?");
                day = Console.ReadLine();
                break;
            }
            Console.WriteLine("There restrictions below 8, 10, and 12 at the park. \nType in 8, 10, or 12 to see the Restrictions.");
            int age = Convert.ToInt32(Console.ReadLine());
            bool range = age == 8 || age == 10 || age == 12;
            do
            {                       
                
                switch (age)
                {
                    case 8:
                        Console.WriteLine("Children Under 8 can only play at booths. \nType in 8, 10, or 12 to see the Restrictions.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("Children Under 10 can't ride rollercoasters. \nType in 8, 10, or 12 to see the Restrictions.");
                        age = Convert.ToInt32(Console.ReadLine()); 
                        break;
                    case 12:
                        Console.WriteLine("Children Under 10 can't ride rollercoasters. \nType in 8, 10, or 12 to see the Restrictions.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        range = false;
                        break;
                }               
                        
            }
            while (open && range);
        }
    }
}
