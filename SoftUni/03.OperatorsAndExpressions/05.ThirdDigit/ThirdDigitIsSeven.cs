/*Write an expression that checks for given integer if its third digit from right-to-left is 7 */
using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.WriteLine("Enter a number :");
        int number = int.Parse(Console.ReadLine());
        number = number / 100;

        if (number % 10 == 7)
        {
            Console.WriteLine("The third digit is 7 !");
        }
        else
        {
            Console.WriteLine("The third digit is not 7!");
        }
        
    }
}

