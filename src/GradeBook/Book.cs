using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStats()
        {

            var result = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

                foreach (double number in grades)
                {
                    highestGrade = Math.Max(number, highestGrade);
                    lowestGrade = Math.Min(number, lowestGrade);
                    result += number;
                }

            result /= this.grades.Count;

            Console.WriteLine($" The highest grade is {highestGrade:N1}\n The average grade is {result:N1}\n The lowest grade is {lowestGrade:N1}");
        }

        private List<double> grades;
        private string name;

    }
}