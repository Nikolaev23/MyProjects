// Create C# program which print numbers 1 , 101 and 1001.
using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("Choose verion to complete this program : \nEnter 1 for version 1\nEnter 2 for version 2 ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            //version 1
            Console.WriteLine(1);
            Console.WriteLine(101);
            Console.WriteLine(1001);
        }
        else if (choice == 2)
        {
            //version 2 

            Console.WriteLine("Enter number 1 :");
            int numberOne = int.Parse(Console.ReadLine());
            while (numberOne != 1)
            {
                Console.WriteLine("Enter number 1 :");
                numberOne = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter number 101 :");
            int numberTwo = int.Parse(Console.ReadLine());
            while (numberTwo != 101)
            {
                Console.WriteLine("Enter number 101 :");
                numberTwo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter number 1001 :");
            int numberThree = int.Parse(Console.ReadLine());
            while (numberThree != 1001)
            {
                Console.WriteLine("Enter number 1001 :");
                numberThree = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your numbers are : \n{0}\n{1}\n{2}\n", numberOne, numberTwo, numberThree);
        }
        else
        {
            Console.WriteLine("Error");
        }
           
    }
}

