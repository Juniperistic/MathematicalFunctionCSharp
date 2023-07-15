using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;   // this will hold the first number      
            int number2,
                number3;
            int sum;
            double product;

            string line;  // used for readline 

            Console.Write("Please enter a whole number (1/3): ");

            // Get First Number
            line = Console.ReadLine();

            // Convert from a string to an int
            number1 = Convert.ToInt32(line);

            Console.Write("Please enter a whole number (2/3): ");

            // Get Second Number
            line = Console.ReadLine();

            // Convert from a string to an int
            number2 = Convert.ToInt32(line);

            Console.Write("Please enter a whole number (3/3): ");

            // Get Third Number
            line = Console.ReadLine();

            // Convert from a string to an int
            number3 = Convert.ToInt32(line);

            sum = number1 + number2 - number3;

            product = sum * number1;

            Console.WriteLine("The answer of: {0}, {1}, and {2} is: {3}", number1, number2, number3, product);

        }
    }
}