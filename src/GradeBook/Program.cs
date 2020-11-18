using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Nolan's Grade Book");
            book.AddGrade(78.2);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStats();

            Console.WriteLine($" The highest grade is {stats.High:N1}\n The average grade is {stats.Average:N1}\n The lowest grade is {stats.Low:N1}");
        }
    }
}
