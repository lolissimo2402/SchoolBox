using System;
//7. Зчитати стрічку з екрану, якщо ввели B - вивести BMW, якщо M - Mersedess, W - Wolzvagen інакше вивести unknown car(використовуй switch -case)
namespace SchoolBox.task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type of cars: B=BMW, M=Mercedess, W=Wolcwagen");
            Console.WriteLine("Please enter your selection: ");
            string myString = Console.ReadLine();
            switch (myString)
            {
                case "B":
                    Console.WriteLine("BMW");
                    break;
                case "M":
                    Console.WriteLine("Mercedess");
                    break;
                case "W":
                    Console.WriteLine("Wolcvagen");
                    break;
                default:
                    Console.WriteLine("unknown car");
                    break;
            }
            Console.WriteLine("Thank You");
        }
    }
}
