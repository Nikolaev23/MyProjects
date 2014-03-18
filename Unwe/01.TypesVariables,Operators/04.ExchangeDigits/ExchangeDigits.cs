using System;

class ExchangeDigits
{
    static void Main()
    {
        Console.WriteLine("Enter your number (abcd) format :");
        string number = Console.ReadLine();
        while (number.Length < 4 || number.Length > 4)
        {
            Console.WriteLine("Enter correct number (abcd) format :");
            number = Console.ReadLine();
        }
        int sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int currentNumber = int.Parse(number[i].ToString());
            sum += currentNumber;
        }
        Console.WriteLine("The sum of number is {0}",sum);

        for (int i = number.Length - 1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }
        Console.WriteLine();
        int firstDigit = int.Parse(number[0].ToString());
        int secondDigit = int.Parse(number[1].ToString());
        int thirdDigit = int.Parse(number[2].ToString());
        int fourthDigit = int.Parse(number[3].ToString());

        Console.WriteLine("The result is: {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("The result is: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine(new string('-', 30));
    }
}

