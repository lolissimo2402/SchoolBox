using System;
//2. Зчитати стрічку з екрану, створити метод який вертає стрічку без пробілів
namespace SchoolBox.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string firstName = "My Second Task";
            Console.WriteLine(firstName.Replace(" ", ""));
            Console.ReadLine();
        }
    }
}
