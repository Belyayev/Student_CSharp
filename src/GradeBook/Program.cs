using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
        var book = new Book("Mike's book");
        book.AddGrade(1.1);
        book.AddGrade(2.2);
        book.AddGrade(3.3);

        var stats = book.GetStatistics();

        Console.WriteLine($"The lowest grade is {stats.Low}");
        Console.WriteLine($"The highest grade is {stats.High}");
        Console.WriteLine($"The average grade is {stats.Average}");
        }
    }
}
