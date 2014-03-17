//Create bank account.
using System;

class BankAccount
{
    static void Main()
    {
        Console.WriteLine("Enter first name :");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter middle name :");
        string middleName = Console.ReadLine();
        Console.WriteLine("Enter last name :");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter your bank name :");
        string bankName = Console.ReadLine();
        Console.WriteLine("Enter your iban (10 numbers and characters)");
        string iban = Console.ReadLine();
        while (iban.Length < 10 || iban.Length > 10)
        {
            Console.WriteLine("Enter correct iban with 10 numbers and characters :");
            iban = Console.ReadLine();
        }
        string firstCard = "3453 3213 7658 4344";
        string secondCard = "9942 4321 2323 5842";
        string thirdCard = "7673 3625 7582 1243";
        decimal money = 45230444m;
        Console.WriteLine();
        Console.WriteLine(new string('-',20));
        Console.WriteLine("Personal information :");
        Console.WriteLine(new string('-', 20));
        Console.WriteLine();
        Console.WriteLine("First name : {0}\nMiddle name : {1}\nLast name : {2}\nBank name : {3}\n IBAN : {4}",firstName,middleName,lastName,bankName,iban);
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Bank Information {0} Bank:",bankName);
        Console.WriteLine(new string('-', 20));
        Console.WriteLine();
        Console.WriteLine("First name : {0}\nBank name : {1}\nIBAN : {2}\nFirst credit card number : {3}\nSecond credit card number : {4}\n Third credit card number : {5}\nMoney = {6} million dollars",firstName,bankName,iban,firstCard,secondCard,thirdCard,money);

    }
}

