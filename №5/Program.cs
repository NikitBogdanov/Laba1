using System;

namespace Lab1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первого катета: ");
            double kat1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второго катета: ");
            double kat2 = double.Parse(Console.ReadLine());
            if (kat1 < 0 && kat2 < 0)
            {
                Console.WriteLine("Ошибка: Длина не может быть отрицательной: ");
                Console.ReadKey();
            }
            else
            {
                double S = ((kat1 * kat2) / 2);
                double gip = Math.Sqrt(Math.Pow(kat1, 2) + Math.Pow(kat2, 2));
                double P = kat1 + kat2 + gip;
                Console.WriteLine("Площадь равна: " + S);
                Console.WriteLine("Периметр равен: " + P);
                Console.ReadKey();
            }
        }
    }
}
