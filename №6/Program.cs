using System;

namespace Lab1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырёхзначное число: ");
            double z = Convert.ToInt32(Console.ReadLine());
            double y1 = (double)(z / 10);
            int x2 = Convert.ToInt32((y1 - (int)y1)*10);
            double y11 = Convert.ToDouble(z / 100);
            int x22 = Convert.ToInt32((y11 - (int)y11)*10);
            double y111 = Convert.ToDouble(z / 1000);
            int x222 = Convert.ToInt32((y111 - (int)y111) * 10);
            double y1111 = Convert.ToDouble(z / 10000);
            int x2222 = Convert.ToInt32((y1111 - (int)y1111) * 10);
            int proiz = Convert.ToInt32(x2 * x22 * x222 * x2222);
            Console.WriteLine("Ответ: " + proiz);
            Console.ReadKey();
        }
    }
}
