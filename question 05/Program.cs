using System;

namespace question05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int number;
            if (Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Multiplication table of " + number + ":");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(number + " x " + i + " = " + (number * i));
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}