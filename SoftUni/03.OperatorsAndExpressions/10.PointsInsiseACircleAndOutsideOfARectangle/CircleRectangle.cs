/* Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). */
using System;

class CircleRectangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter point X :");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter point Y :");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter radius :");
        double radius = double.Parse(Console.ReadLine());
        bool isInCircle = true;
        double pointCentre = Math.Sqrt(x * x + y * y);
        if (pointCentre <= radius * radius)
        {
            Console.WriteLine(isInCircle);
        }
        else
        {
            Console.WriteLine(isInCircle = false);
        }
        double top = 1;
        double left = -1;
        double width = 6;
        double height = 2;
        double xMin = left;
        double xMax = left + width;
        double yMin = top - height;
        double yMax = top;

        // X Out Of Range
        bool isXOutRangleRectangle = ((x < xMin) || (x > xMax));

        // Y Out Of Range
        bool isYOutRangleRectangle = ((y < yMin) || (y > yMax));

        // Point outside of a rectangle
        bool isOutsideRectangle = isXOutRangleRectangle || isYOutRangleRectangle;

        if (isInCircle && isOutsideRectangle)
        {
            Console.WriteLine("Yes.");
        }
        else
        {
            Console.WriteLine("No.");
        }
    }
}

