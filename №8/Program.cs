using System;

namespace Lab1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double y = Convert.ToDouble(3*(Math.Pow(x, 4)) - 5*(Math.Pow(x, 3)) + 2*(Math.Pow(x, 2)) - x + 7);
            Console.WriteLine("Ответ: "+ y);
            

           
            
        }
    }
}
