/* Trapezoid area */
using System;

class Trapezoid
{
    static void Main()
    {
        Console.WriteLine("Enter side A :");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B :");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height H :");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;

        Console.WriteLine("The area of trapezoid with sides A : {0} , B : {1} and height H : {2} is {3}",a,b,h,area);
    }
}

