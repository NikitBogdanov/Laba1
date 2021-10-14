using System;

namespace Lab1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число: ");
            double z = Convert.ToInt32(Console.ReadLine());
            double z1 = Convert.ToInt32(((z / 10) - (int)(z / 10))*10);
            double z2 = Convert.ToDouble(((z / 100) - (int)(z / 100)) * 10);
            double z3 = Convert.ToDouble(((z / 1000) - (int)(z / 1000)) * 10);
            string reversed = Convert.ToString($"{z1}{(int)z2}{(int)z3}");
            Console.WriteLine("Ответ: " + reversed) ;
            Console.ReadKey();
        }
    }
}
