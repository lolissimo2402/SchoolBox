using System;
//3. Зчитати два числа з екрану, вивести на екран їх суму, різницю, добуток. Використовувати string.Format() для виведення даних
namespace SchoolBox.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1 = 10, num2 = 2;
            string formatString1 = string.Format("{0}+{1}={2}", num1, num2, num1 + num2);
            string formatString2 = string.Format("{0}/{1}={2}", num1, num2, num1 / num2);
            string formatString3 = string.Format("{0}*{1}={2}", num1, num2, num1 * num2);
            Console.WriteLine(formatString1);
            Console.WriteLine(formatString2);
            Console.WriteLine(formatString3);
            Console.ReadLine();

        }
    }
}
