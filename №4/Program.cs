using System;

namespace Lab1_4
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую переменную a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a != b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("Теперь a = " + a);
                Console.WriteLine("Теперь b = " + b);

            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
    }
}
