using System;

class Program
{
    static void Main(string[] args)
    {
        Random number = new Random();
        int magicNumber = number.Next(1, 100);
        
        //Console.WriteLine("What is the magic number?");
        //int magicNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your guess?");
        int guessedNumber = int.Parse(Console.ReadLine());
        

        while (guessedNumber != magicNumber){

            if (guessedNumber > magicNumber)
            {
            Console.WriteLine("LOWER");
            Console.WriteLine("What is your new guess?");
            guessedNumber = int.Parse(Console.ReadLine());

            } else if (guessedNumber < magicNumber)
            {
            Console.WriteLine("HIGHER");
            Console.WriteLine("What is your new guess?");
            guessedNumber = int.Parse(Console.ReadLine());
            }
            
                       
            }
        
        
            Console.WriteLine("You guessed it!");

        

        
    }
}