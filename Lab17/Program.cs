using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {//whos idea was this lab
            Console.WriteLine("Let's locate some primes." +
                "\nThis program will find any prime, in order, from the first prime number on.");
            do//directions confusing af and math is scary
            {
                Console.Write("Which prime number are you looking for?");
                int index;
                if (int.TryParse(Console.ReadLine(), out index))
                {
                    Console.WriteLine($"The number {index} prime is {Prime.PrimeIndex(index)}.");
                }
                else
                {
                    Console.WriteLine("That isn't a valid integer!");
                }

                Console.WriteLine("Do you want to find another prime number? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
