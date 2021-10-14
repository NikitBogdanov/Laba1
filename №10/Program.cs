using System;

namespace Lab1_01
{


    class Country
    {


        public string name = "Австралия";
        public string capital = "Канберра";
        public int people = 23678543;
        public string power = "Ф";
        public void Print()
        {
            Console.WriteLine("| " + name + "   |" + capital + " |" + people + " " + "  |" + power);
        }
    }

    class Country2
    {


        public string name = "Австрия";
        public string capital = "Вена";
        public int people = 8420010;
        public string power = "Ф";
        public void Print()
        {
            Console.WriteLine("| " + name + "     |" + capital + "     |" + people + "    |" + power);
        }

        class Country3
        {


            public string name = "Италия";
            public string capital = "Рим";
            public int people = 61482020;
            public string power = "УГ";
            public void Print()
            {
                Console.WriteLine("| " + name + "      |" + capital + "      |" + people + "   |" + power);
            }

            class MainClass
            {
                public static void Main(string[] args)
                {
                    Console.WriteLine("География");
                    Console.WriteLine("| Государство | Столица | Население | Устройство | ");
                    Country A = new Country();
                    A.Print();
                    Country2 B = new Country2();
                    B.Print();
                    Country3 C = new Country3();
                    C.Print();
                    Console.WriteLine("Ф - федерация УГ - унитарное государство");
                    Console.ReadKey();
                }





            }

        }
    }
}

