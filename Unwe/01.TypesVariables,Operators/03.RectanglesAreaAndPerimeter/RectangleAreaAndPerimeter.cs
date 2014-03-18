using System;

class RectangleAreaAndPerimeter
{
    static void Main()
    {
        Console.WriteLine("Enter width for Rectangle :");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height for Rectangle :");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Press :\n1 - for Area\n2 - for Perimeter");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            double area = width * height;
            Console.WriteLine("The area of Rectangle with width {0} and height {1} is {2}",width,height,area);
        }
        else if (choice == 2)
        {
            double perimeter = 2 * (width + height);
            Console.WriteLine("The perimeter of Rectangle with width {0} and height {1} is {2}",width,height,perimeter);
        }
    }
}

