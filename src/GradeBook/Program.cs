using System;

namespace GradeBook
{
    class Program
    {
        
        static void Main(string[] args)
        {
        var x = 33.3;
        var y = 55;

        if(args.Length > 0)
        {
            Console.WriteLine("Hello " + args[0] + "!");
            Console.WriteLine(x + y);

        }
        else
        {
            Console.WriteLine("Hi, there!");
        }
        }
    }
}
