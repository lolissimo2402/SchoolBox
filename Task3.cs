using System;
//3. Зчитати два числа з екрану, вивести на екран їх суму, різницю, добуток. Використовувати string.Format() для виведення даних
namespace SchoolBox.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Num1");
            string myStr1 = Console.ReadLine();
            int num1 = int.Parse(myStr1);
            Console.WriteLine("Select Num2");
            string myStr2 = Console.ReadLine();
            int num2 = int.Parse(myStr2);
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
