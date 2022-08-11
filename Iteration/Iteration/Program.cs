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
            foreach (string phrase in combinedArray)
            {
                Console.WriteLine(phrase);
            }
            Console.ReadLine();

            //for (int i = 0; i < baseArray.Length; i++)
            //{
                //Console.WriteLine(combinedArray[i]);
            //}
            //Console.ReadLine();
        }
    }
}
