using System;
//4. Зчитати стрічку з екрану, виести її назад у аппер кейсі
namespace SchoolBox.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your word");
            string myStr = Console.ReadLine();
            string upper = myStr.ToUpper();
            Console.WriteLine(upper);
            Console.ReadLine();
        }
    }
}
