using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter your number: ");
        int myNum = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('-', 30));

        bool primeNum = true;
        for (int divisor = 2; divisor <= Math.Sqrt(myNum); divisor++)
        {
            if (myNum % divisor == 0)
            {
                primeNum = false;
            }
        }
        Console.WriteLine("The number is prime => {0}", primeNum);

    }
}

