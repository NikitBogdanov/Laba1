using System;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время в секундах: ");
            int sek = Convert.ToInt32(Console.ReadLine());
            double hour = Convert.ToInt32(sek / 3600);
            double min = Convert.ToInt32(sek / 60);
            int ostmin = Convert.ToInt32(min - (hour * 60));
            Console.WriteLine("Часов:" + hour + " " + "Минут:" + ostmin);


        }
    }
}

