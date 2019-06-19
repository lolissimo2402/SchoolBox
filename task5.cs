using System;
//. Зчитати число з екрану, використовуючи цикли(for/ foreach/while/do-while) вивести числа від одного до заданого
namespace SchoolBox.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My number");
            string myStr = Console.ReadLine();
            int num = int.Parse(myStr);
            for (int a = 1; a < num; a++)
                Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
