using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday : mm/dd/yyy :");
        DateTime date = DateTime.Parse(Console.ReadLine());
        DateTime dateNow = DateTime.Now;

        if (dateNow.Month < date.Month)
        {
            Console.WriteLine("You are {0} years old !\nAfter ten years will be : {1}",(dateNow.Year - date.Year) - 1,((dateNow.Year - date.Year) - 1) + 10);
        }
        else if (dateNow.Month == date.Month)
        {
            if (dateNow.Day < date.Day)
            {
                Console.WriteLine("You are {0} years old !\nAfter ten years will be : {1}", (dateNow.Year - date.Year) - 1, ((dateNow.Year - date.Year) - 1) + 10);
            }
            else
            {
                Console.WriteLine("You are {0} years old !\nAfter ten years will be : {1}", dateNow.Year - date.Year, (dateNow.Year - date.Year) + 10);
            }
        }
        else
        {
            Console.WriteLine("You are {0} years old !\nAfter ten years will be : {1}", dateNow.Year - date.Year, (dateNow.Year - date.Year) + 10);
        }
            
   }
}

