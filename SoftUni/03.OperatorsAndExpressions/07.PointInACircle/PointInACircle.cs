/* Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). */
using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter point X :");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter point Y :");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter radius :");
        double radius = double.Parse(Console.ReadLine());

        double pointCentre = Math.Sqrt(x * x + y * y);
        if (pointCentre <= radius * radius)
        {
            Console.WriteLine("The points are inside circle!");
        }
        else
        {
            Console.WriteLine("The points aren't inside!");
        }
    }
}

