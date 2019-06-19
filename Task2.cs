using System;
//2. Зчитати стрічку з екрану, створити метод який вертає стрічку без пробілів
namespace SchoolBox.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your text");
            string myStr = Console.ReadLine();
            Console.WriteLine(myStr.Replace(" ", ""));
            Console.ReadLine();
        }
    }
}
