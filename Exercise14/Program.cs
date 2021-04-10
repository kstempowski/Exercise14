using System;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 14");
            bool repeat = true;
            while (repeat)
            {
                //Prompt the user for input
                Console.WriteLine("Please enter a number greater than 0");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                //The square if i will be produced until i equals the number input by the user
                for (int i = 1; number >= i; i++)
                {
                    int square = i * i;
                    Console.WriteLine(square);
                }
                //prompt the user for additional input
                Console.WriteLine("Enter another number? y/n");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    //An answer if "y" will repeat the program
                    repeat = true;
                }
                else
                {
                    //Any answer other than "y" will terminate the program
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }
            }
        }
    }
}
