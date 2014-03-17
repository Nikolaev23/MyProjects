//A marketing company wants to keep record of its employees.
using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Enter your first name :");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name :");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter your age :");
        int age = int.Parse(Console.ReadLine());
        while (age <= 0 || age > 100)
        {
            Console.WriteLine("Enter Correct age :");
            age = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter your gender : Press m for Male and f for Female");
        string gender = Console.ReadLine();
        long idNumber = 8306112507;
        int employeeNumber = 27562323;

        Console.WriteLine();
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Employee data :");
        Console.WriteLine(new string('-',20));
        Console.WriteLine();
        Console.WriteLine("First name : {0}\nLast name : {1}\nAge : {2}",firstName,lastName,age);
        if (gender == "m")
        {
            Console.WriteLine("Gender : Male");
        }
        else if (gender == "f")
        {
            Console.WriteLine("Gender : Female");
        }
        else
        {
            Console.WriteLine("Error");
        }
        Console.WriteLine("ID number : {0}\nEmployee number : {1}",idNumber,employeeNumber);
    }
}

