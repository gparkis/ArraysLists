using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main()
        {
            string[] names= {"Grant", "Noah", "Max"};
            Console.WriteLine("Please choose an array to see, enter 0, 1, or 2");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(names[userChoice]);

            int[] numbers = {1,2,3,4,5,6,7};
            Console.WriteLine("Please choose an array to see, enter a number between 0 and 6");
            int numberchoice = Convert.ToInt32(Console.ReadLine());

            if (numberchoice >= numbers.Length || numberchoice < 0)
            {
                Console.WriteLine("Selected number is outside array, must not be larger then " + (numbers.Length - 1) + " or smaller than 0");
            }
            else
            {
                Console.WriteLine(numbers[numberchoice]);
            }

            List<string> names2 = new List<string> { "Grant", "Noah", "Max" }; ;
            names2.Add("Jessie");
            Console.WriteLine("Select number from 0 to 3");
            int listChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(names2[listChoice]);

            Console.Read();
        }
    }
}
