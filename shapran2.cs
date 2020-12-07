using System;

namespace shapran_exemple_2
{
    class dates
    {
        DateTime date = new DateTime(2020, 12, 31);
        public void res()
        {
            Console.WriteLine("Введите число от 1 до 365");
            int i = int.Parse(Console.ReadLine());
                 Console.WriteLine(date.AddDays(i).ToString("D"));
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            dates some = new dates();
            some.res();
        }
    }
}
