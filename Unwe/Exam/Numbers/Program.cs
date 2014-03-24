using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number 1 - 99 !");
        int number = int.Parse(Console.ReadLine());
        while (number > 99 || number < 1)
        {
            Console.WriteLine("Wrong number! Please enter correct number 1 - 99 !");
            number = int.Parse(Console.ReadLine());
        }
        if (number < 20)
        {
            numberZeroToNineteen(number);
        }
        else if (number % 10 == 0)
        {
            numberWithZero(number);
        }
        else
        {
            int numbers = number % 10;
            number /= 10;

            allNumbers(number,numbers);

        }

    }
    static void numberZeroToNineteen(int number)
    {
        switch (number)
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            case 10: Console.WriteLine("Ten"); break;
            case 11: Console.WriteLine("Eleven"); break;
            case 12: Console.WriteLine("Twelve"); break;
            case 13: Console.WriteLine("Thirtheen"); break;
            case 14: Console.WriteLine("Fourteen"); break;
            case 15: Console.WriteLine("Fifteen"); break;
            case 16: Console.WriteLine("Sixteen"); break;
            case 17: Console.WriteLine("Seventeen"); break;
            case 18: Console.WriteLine("Eighteen"); break;
            case 19: Console.WriteLine("Nineteen"); break;
            default:
                break;
        }
        
    }
    static void numberWithZero(int number)
    {
        switch (number)
        {
            case 20: Console.WriteLine("Twenty"); break;
            case 30: Console.WriteLine("Thirty"); break;
            case 40: Console.WriteLine("Fourty"); break;
            case 50: Console.WriteLine("Fifty"); break;
            case 60: Console.WriteLine("Sixty"); break;
            case 70: Console.WriteLine("Seventy"); break;
            case 80: Console.WriteLine("Eighty"); break;
            case 90: Console.WriteLine("Ninety"); break;
            default:
                break;
        }
    }
    static void allNumbers(int number , int numbers)
    {
        switch (number)
        {
            case 2: Console.Write("Twenty-"); break;
            case 3: Console.Write("Thirty-"); break;
            case 4: Console.Write("Fourty-"); break;
            case 5: Console.Write("Fifty-"); break;
            case 6: Console.Write("Sixty-"); break;
            case 7: Console.Write("Seventy-"); break;
            case 8: Console.Write("Eighty-"); break;
            case 9: Console.Write("Ninety-"); break;
            default:
                break;
        }
        numberZeroToNineteen(numbers);
    }
}

