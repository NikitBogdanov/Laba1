using System;

namespace Lab1_999
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("                        " + "a1x + b1y + с1z = d1");
            Console.WriteLine("Введите коефициенты:    a2x + b2y + с2z = d2");
            Console.WriteLine("                        " + "a3x + b3y + с3z = d3");

            int[,] Ayraw = new int[3, 3];
            Console.WriteLine("a1 = ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b1 = ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c1 = ");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a2 = ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b2 = ");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c2 = ");
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a3 = ");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b3 = ");
            int b3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c3 = ");
            int c3 = Convert.ToInt32(Console.ReadLine());
            for (int Rows = 0; Rows < 3; Rows++)
            {
                for (int Columns = 0; Columns < 3; Columns++)
                {

                }
            }

            int detA = Convert.ToInt32((a1 * b2 * c3) + (c1 * a2 * b3) + (b1 * c2 * a3) - (c1 * b2 * a3) - (a1 * c2 * b3) - (b1 * a2 * c3));
            if (detA != 0)
            {
                int A11 = (b2 * c3) - (c2 * b3);
                int A12 = -(b1 * c3) - (c1 * b3);
                int A13 = (b1 * c2) - (c1 * b2);
                int A21 = -(a2 * c3) - (c2 * a3);
                int A22 = (a1 * c3) - (c1 * a3);
                int A23 = -(a1 * c2) - (c1 * a2);
                int A31 = (a2 * b3) - (b2 * a3);
                int A32 = -(a1 * b3) - (b1 * a3);
                int A33 = (a1 * b2) - (b1 * a2);

                int[,] Aa = new int[3, 3];
                Aa[0, 0] = A11;
                Aa[0, 1] = A12;
                Aa[0, 2] = A13;
                Aa[1, 0] = A21;
                Aa[1, 1] = A22;
                Aa[1, 2] = A23;
                Aa[2, 0] = A31;
                Aa[2, 1] = A32;
                Aa[2, 2] = A33;
                for (int kRows = 0; kRows < 3; kRows++)
                {
                    for (int kColumns = 0; kColumns < 3; kColumns++)
                    {
                        int[,] Byraw = new int[1, 3];
                        Console.WriteLine("d1 = ");
                        Byraw[0, 0] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("d2 = ");
                        Byraw[0, 1] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("d3 = ");
                        Byraw[0, 2] = Convert.ToInt32(Console.ReadLine());
                        for (int iRows = 0; iRows < 1; iRows++)
                        {
                            for (int iColumns = 0; iColumns < 3; iColumns++)
                            {
                                int Ans = Byraw[iRows, iColumns] * Aa[kRows, kColumns];
                                Console.Write("Ответ: " + Ans + " ");
                                
                            }

                        }

                        Environment.Exit(0);
                        Console.ReadKey();
                    }
                }
                
            }
            
            else
            {
                Console.WriteLine("Ошибка: Определитель системы не должен равняться нулю! ");
                Console.WriteLine();
            }
        }

                         
                                        


                            



                        








                    
                


            

















        
    }
}
