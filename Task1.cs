using System;
//1. зчитати з екрану стрічку і вивести на екран її довжину
namespace SchoolBox.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your text");
            string firstName = Console.ReadLine();
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.ReadLine();
        }
    }
}
