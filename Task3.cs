using System;
//3. Зчитати два числа з екрану, вивести на екран їх суму, різницю, добуток. Використовувати string.Format() для виведення даних
namespace SchoolBox.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select firstNumberConverted");
            string firstNumber = Console.ReadLine();
            int firstNumberConverted = int.Parse(firstNumber);
           
            Console.WriteLine("Select secondNumberConverted");
            string secondNumber = Console.ReadLine();
           
            int secondNumberConverted = int.Parse(secondNumber);
            string formattedSum = string.Format("{0}+{1}={2}", firstNumber, secondNumber, firstNumber + secondNumber);
            string formattedDifference = string.Format("{0}-{1}={2}", firstNumber, secondNumber, firstNumber - secondNumber);
            string formattedProduct = string.Format("{0}*{1}={2}", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine(formattedSum);
            Console.WriteLine(formattedDifference);
            Console.WriteLine(formattedProduct);
           
            Console.ReadLine();
        }
    }
}
