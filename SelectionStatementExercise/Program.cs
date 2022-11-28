using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:
            //Create an if-statement that if the guessed number is below the initial value, print out “too low”.
            //Create an else -if statement that if the number is higher than the initial value, print out “too high”.
            //Create an else statement that prints out some type of congratulations for guessing the correct number e.g. “You guessed it!!!”.

            var r = new Random();
            var favNum = r.Next(1, 10);

            Console.WriteLine("Enter a number from 1-10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput <= favNum) 
                {
                Console.WriteLine("too low");
                }
            else if (userInput >= favNum)
                {
                Console.WriteLine("too high");
                }
            else
            {
                Console.WriteLine("Congratulations you guessed it!");
            }

        }
    }
}
