using System;
using System.Linq;

namespace Exercise37
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";
            int[] numArray = new int[5];

            while (cont == "y")
            {
                Console.WriteLine("Please enter a number:");
                numArray[0] =int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number:");
                numArray[1] = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number:");
                numArray[2] = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number:");
                numArray[3] = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number:");
                numArray[4] = int.Parse(Console.ReadLine());

                int sum = numArray.Sum();
                Console.WriteLine($"{numArray[0]} + {numArray[1]} + {numArray[2]} + {numArray[3]} + {numArray[4]} = {sum}");

                Console.WriteLine("Would you like to continue? (y/n)");
                cont = Console.ReadLine();
            }
            Console.WriteLine("Thank you for using our software. Goodbye");
        }
    }
}
