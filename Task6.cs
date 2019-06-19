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
                    Console.WriteLine("Thank You");
                    break;
                case "M":
                    Console.WriteLine("Mercedess");
                    Console.WriteLine("Thank You");
                    break;
                case "W":
                    Console.WriteLine("Wolcvagen");
                    Console.WriteLine("Thank You");
                    break;
                default:
                    Console.WriteLine("unknown car");
                    Console.WriteLine("Thank You");
                    break;
            }
        }        
    }
}
