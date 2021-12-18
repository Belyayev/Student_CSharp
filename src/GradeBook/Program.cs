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
        
        Console.WriteLine("Please, enter a grade. Type q to finish.");
        var finished = false;

        do
        {

        var input = Console.ReadLine();

        if(input.Equals("q"))
        {
            finished = true;
        }
        else
        {
            var grade = double.Parse(input);
            book.AddGrade(grade);
        }

        } while(finished);

        var stats = book.GetStatistics();

        Console.WriteLine($"The lowest grade is {stats.Low}");
        Console.WriteLine($"The highest grade is {stats.High}");
        Console.WriteLine($"The average grade is {stats.Average}");
        Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
