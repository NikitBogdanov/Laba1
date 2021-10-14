using System;

namespace Lab1_02
{
    class Program
    {
        static void Main(string[] args)
        {
            const double e = 2.7182818284590451;
            Console.WriteLine("Введите х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a + x * x) != 0 && b != 0 && x - Math.Sqrt(Math.Abs(x - b)) != 0) 
            { double f = Convert.ToDouble(Math.Log(a + x * x) + Math.Pow(Math.Sin(x / b), 2));
                Console.WriteLine("f = " + f); 
              double z = Convert.ToDouble((Math.Pow(e , -c * x)) * ((x+(Math.Sqrt(x+a)) / (x-(Math.Sqrt(Math.Abs(x - b)))))));
                Console.WriteLine("z = " + z);
                Console.ReadKey();
            } 
             
            else
            { 
                Console.WriteLine("Введены значения не удовлетворяющие ОДЗ");

            }
            
        }
         
    
        
    }
}
