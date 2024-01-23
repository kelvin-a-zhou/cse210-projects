using System;

class Program
{
    static void DisplayMessage()
        {
         Console.WriteLine("Welcome to the Program!");
        }

       static string PromptUserName()
       {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
       }

       static int PromptUserNumber()
       {
        Console.Write("Please enter your User number ");
        int number = int.Parse(Console.ReadLine());
        return number;
       }

        static int squareNumber(int number)
        {            
            int square = number * number;
            return square;
        }

       static void displayResults( string name, int square) 
       {
        
        Console.WriteLine(($"{name} , the square of your number is : {square}"));


       }


    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = squareNumber(number);
        
        
        displayResults(name, square);
        
        // displayResults(PromptUserName(), squareNumber(PromptUserNumber()));
 



    }
}