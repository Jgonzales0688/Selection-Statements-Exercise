using System;
using static System.Formats.Asn1.AsnWriter;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Exercise 1
            var r = new Random();
            var favNum = r.Next(1, 100);

            Console.WriteLine("Enter a number from 1-100");
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


            //Exercise 2
            Console.WriteLine("What is your favorite school subject?");
            var favSubj = Console.ReadLine();

            switch (favSubj.ToLower()) 
            {
                case "reading":
                    Console.WriteLine("Reading is a great subject.");
                    break;
                case "writing":
                    Console.WriteLine("Writing is an interesting subject.");
                    break;
                case "english":
                    Console.WriteLine("English is a good subject.");
                    break;
                case "math":
                    Console.WriteLine("Math is a difficult subject.");
                    break;
                case "science":
                    Console.WriteLine("Science is my favorite as well.");
                    break;

                default:
                    Console.WriteLine("Thats not one many people choose, great choice.");
                    break;
            }

          

        }
    }
}
