
using System;
//. Зчитати число з екрану, використовуючи цикли(for/ foreach/while/do-while) вивести числа від одного до заданого
namespace SchoolBox.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My number 1");
            string firstString = Console.ReadLine();
            int firstNum = int.Parse(firstString);

            for (int a = 1; a < firstNum; a++)
                Console.WriteLine(a);


            Console.WriteLine("My number 2");
            string secondString = Console.ReadLine();
            int secondNum = int.Parse(secondString);

            int[] mussive = new int[secondNum];
            for (int i = 0; i < mussive.Length; i++)
            {
                mussive[i] = i + 1;
            }

            foreach (int i in mussive)
            {
                Console.Write("{0}  ", i);
            }
            int n = 0;

            Console.WriteLine("Enter number 3");
            string threeString = Console.ReadLine();
            int threeNum = int.Parse(threeString);

            while (n < threeNum)
            {
                n++;
                Console.WriteLine("{0}", n);
            }

            Console.WriteLine("Enter nuber 4");
            string fourString = Console.ReadLine();
            int fourNum = int.Parse(fourString);

            int m = 0;

            do
            {
                m++;
                Console.WriteLine("Numbers{0}", m);

            }

            while (m < fourNum);
            Console.WriteLine("Okay");

            Console.ReadKey();
        }
    }
    
}
