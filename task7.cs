using System;

namespace SchoolBox.task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string myString;
            Console.WriteLine("Enter the pass");
            myString = Console.ReadLine();
            if (myString.Length < 5)
                Console.WriteLine("5");
            else if ((myString.Length >= 5) && (myString.Length <= 10))
                Console.WriteLine("10");
            else if (myString.Length > 10)
                Console.WriteLine(11);
            Console.ReadLine();          
        }
    }
}
