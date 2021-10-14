using System;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время:");
            Console.WriteLine("Часы: "); int h = Convert.ToInt32(Console.ReadLine());
            
            if (h > 12)
            { 
                double h11 = Convert.ToDouble((h-12) * 30);
                Console.WriteLine("Минуты: ");
                int m0 = Convert.ToInt32(Console.ReadLine());
            double m11 = Convert.ToDouble(m0 * 0.5);
                Console.WriteLine("Секунды: ");
                int s0 = Convert.ToInt32(Console.ReadLine());
            double s11 = Convert.ToDouble(s0 * 0.08);

            double f0 = Convert.ToDouble(h11 + m11 + s11);
                Console.WriteLine("Ответ в градусах:" + " " + f0);
                Environment.Exit(0);
            }
            else
            {
                double h1 = Convert.ToDouble(h * 30);
                Console.WriteLine("Минуты: ");
                int m = Convert.ToInt32(Console.ReadLine());
            double m1 = Convert.ToDouble(m * 0.5);
                Console.WriteLine("Секунды: ");
                int s = Convert.ToInt32(Console.ReadLine());
            double s1 = Convert.ToDouble(s * 0.08);
              
            double f = Convert.ToDouble(h1 + m1 + s1);
            Console.WriteLine("Ответ в градусах:" + " " + f);
            }
            

        }
    }
}
