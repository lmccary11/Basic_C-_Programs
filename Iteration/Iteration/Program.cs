using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] baseArray = new string[] { "Sweet as", "Two peas and", "Bonnie and",
                "Like taking cand from", "You're only as good as", "Two in the hand is worth", "What I am speaks so loudly," };
            string[] combinedArray = new string[7];
            for (int i = 0; i < baseArray.Length; i++)
            {
                Console.WriteLine("Finish the phrase: \n\n" + baseArray[i] + "...");
                string answer = Console.ReadLine();
                combinedArray[i] = baseArray[i] + " " + answer;
            }
            Console.WriteLine("\n\nThanks for playing.\n\nThe phrases:\n");

            foreach (string phrase in combinedArray)    //OR    for (int i = 0; i < baseArray.Length; i++)
            {                                           //      {
                Console.WriteLine(phrase);              //      Console.WriteLine(combinedArray[i]);
            }                                           //      }
            Console.ReadLine();                         //      Console.ReadLine();                       

            //for (int i = 0; i < i + 10; i++), caused infinite loop.
            //{
            //    Console.WriteLine("Infinite Loop" + i);
            //}
            //Console.ReadLine();

            for (int i = 0; i < 10; i++)    //Changed 'i + 10' to '10'.
            {
                Console.WriteLine("Definite Loop" + i);
            }
            Console.ReadLine();

            //Iteration stop at less than 20.
            for (int i = 1; i < 20; i++) 
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //Iteration stop at less or equal to than 20.
            for (int i = 1; i <= 20; i++) 
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            List<string> uniqueItem = new List<string>();
            uniqueItem.Add("Alpha"); uniqueItem.Add("Beta"); uniqueItem.Add("Gamma");
            uniqueItem.Add("Delta"); uniqueItem.Add("Epsilon"); uniqueItem.Add("Zeta");
            uniqueItem.Add("eta"); uniqueItem.Add("Theta"); uniqueItem.Add("Iota");
            uniqueItem.Add("Kappa"); uniqueItem.Add("Lambda"); uniqueItem.Add("Mu");
            uniqueItem.Add("Nu"); uniqueItem.Add("Xi"); uniqueItem.Add("Omicron");
            uniqueItem.Add("Pi"); uniqueItem.Add("Rho"); uniqueItem.Add("Sigma");
            uniqueItem.Add("Tau"); uniqueItem.Add("Upsilon"); uniqueItem.Add("Phi");
            uniqueItem.Add("Chi"); uniqueItem.Add("Psi"); uniqueItem.Add("Omega");

            Console.WriteLine("Whats your favorite Greek Letter?");
            string letter = Console.ReadLine();
            for (int i = 0; i < 24; i++)
            {
                int indexUniqueItem = i;
                if (letter == uniqueItem[i])
                {
                    Console.WriteLine(indexUniqueItem + "   " + uniqueItem[i]);
                    Console.WriteLine(uniqueItem[i] + " has an index of " + indexUniqueItem + " in the uniqueItem List.");
                    Console.ReadLine();
                    break;
                }
                else 
                {
                    Console.WriteLine(indexUniqueItem + "   " + uniqueItem[i]);
                    if (i == 23)
                    {
                        Console.WriteLine(letter + " is not a letter in the Greek Alphabet.");
                        Console.ReadLine();
                        break;
                    }
                    continue;
                }
                                    
            }
            List<string> days = new List<string>();
            days.Add("Monday"); days.Add("Wednesday"); days.Add("Friday"); days.Add("Wednesday");
            days.Add("Monday"); days.Add("Wednesday"); days.Add("Tuesday"); days.Add("Sunday");
            days.Add("Tuesday"); days.Add("Wednesday"); days.Add("Friday"); days.Add("Friday");
            Console.WriteLine("It rained 12 times in the last 40 days. 4 occurrences belong to the same day. What day experienced rainfall the most last month?");
            string dayGuess = Console.ReadLine();
            for (int i = 0; i < 12; i++)
            {
                int dayIndex = i;
                if (dayGuess == days[i])
                {
                    Console.WriteLine(dayIndex + "   " + days[i]);
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    if (i == 11)
                    {
                        Console.WriteLine("It didn't rain on Thursday or Saturday in the last 40 days");
                        Console.ReadLine();
                        
                    }      

                }

            }
            List<string> dayVault = new List<string>();

            foreach (string weekday in days)
            {
                if (dayVault.Contains(weekday))
                {
                    Console.WriteLine(weekday + " | This item is a duplicate.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(weekday + " | This item is unique.");
                    dayVault.Add(weekday);
                    Console.ReadLine();
                }
            }






        }
    }
}
