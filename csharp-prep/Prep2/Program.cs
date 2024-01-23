using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage?");
        string userInput = Console.ReadLine();
        int userGrade = int.Parse(userInput);
        string letter = "";
        

        if( userGrade >= 90)
        {
            letter = "A";
        }
        else if( userGrade >= 80)
        {
            letter = "B";
        }
        else if( userGrade >= 70)
        {
            letter = "C";
        }
        else if( userGrade >= 60)
        {
            letter = "D";
        }
        else if( userGrade < 60)
        {
            letter = "F";
        }

       


        //Check if user passed
         if( userGrade  >= 70)
        {
            Console.WriteLine($"Your grade letter is: {letter} ");
            Console.WriteLine("Congratulations you passed!");
        }
        else 
        {
            Console.WriteLine($"Your grade letter is: {letter} ");
            Console.WriteLine("Unfortunately you didn't make it. Please try again next time!");
        }


       

        
     }
}