using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass4 = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                mass4[i] = rnd.Next(-50, 50);

                Console.Write("|" + mass4[i] + "|");
            }

            Console.WriteLine();
            Console.WriteLine();
            int kol = 0;
            for (int i = 0; i < 20; i++)
            {

                if (i % 2 == 0 & mass4[i] > 0 && mass4[i] % 2 != 0)
                                                        
                    Console.Write("|" + mass4[i] + "|", kol++);
                              
            }
            
            Console.WriteLine();
            Console.WriteLine("количество  нечетных положительных элементов, стоящих на четных местах {0}", kol);
            Console.ReadKey();
        }

       
            


            
    }        
}
