/*Write an expression that calculates rectangle’s perimeter and area by given width and height. */
using System;

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("Enter width for Rectangle :");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height for Rectangle :");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter :\n1 - For Area\n2 - for Perimeter");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            double area = width * height;
            Console.WriteLine("The area with width : {0} and height : {1} is {2}",width,height,area);
        }
        else if (choice == 2)
        {
            double perimeter = 2 * (width + height);
            Console.WriteLine("The perimeter with width : {0} and height : {1} is {2}",width,height,perimeter);
        }
        else
        {
            Console.WriteLine("Wrong choice !");
        }
    }
}

