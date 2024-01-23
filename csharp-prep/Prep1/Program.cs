using System;

class Program
{
    static void Main(string[] args)
    {

        string name, surname;
        Console.WriteLine("What is your first name?");
        name = Console.ReadLine();

        Console.WriteLine("What is your first surname?");
        surname = Console.ReadLine();

        Console.WriteLine ("Your name is" + " "+ surname  +", "+ name +" "+ surname );


    }
}