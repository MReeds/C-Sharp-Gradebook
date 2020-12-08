using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Nolan's Grade Book");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit.");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }




            var stats = book.GetStats();

            Console.WriteLine($"For the book named {book.Name}" +
                $"The highest grade is {stats.High:N1}\n " +
                $"The average grade is {stats.Average:N1}\n " +
                $"The lowest grade is {stats.Low:N1}\n " +
                $"The letter grade is {stats.Letter}");
        }
    }
}
