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
            book.ShowStats();
        }
    }
}
