using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
        var book = new Book("Mike's book");
        book.AddGrade(88.1);
        book.AddGrade(3.4);
        book.AddGrade(43.41);
        book.ShowStatistics();
        }
    }
}
