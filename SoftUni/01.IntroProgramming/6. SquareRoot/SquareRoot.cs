//Create a console application that calculates and prints the square root of the number 12345.
using System;

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Enter number :");
        double number = double.Parse(Console.ReadLine());
        double square = Math.Sqrt(number);
        double squareNumber = Math.Pow(number , number);
        Console.WriteLine("Your number is : {0} and square root is : {1} , and square number is : {2}",number,square,squareNumber);


    }
}

