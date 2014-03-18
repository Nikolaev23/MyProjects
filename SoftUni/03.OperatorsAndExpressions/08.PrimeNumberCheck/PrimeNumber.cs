/*Write an expression that checks if given positive integer number n (n ≤ 100) is prime */
using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter possitive number :");
        int number = int.Parse(Console.ReadLine());
        int maxDivider = (int)Math.Sqrt(number);
        int divider = 2;
        bool isPrime = true;
        while (number <= 1 || number >= 100)
        {
            Console.WriteLine("Enter correct possitive number");
            number = int.Parse(Console.ReadLine());
        }
        while (isPrime && (divider <= maxDivider))
        {
            if (number % divider == 0)
            {
                isPrime = false;
            }
            divider++;
        }
        Console.WriteLine(isPrime ? "The number {0} is prime." : "The number {0} is not prime.", number);
    }
}

