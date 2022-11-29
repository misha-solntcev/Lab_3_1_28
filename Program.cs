using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 28. Вычислить частичную сумму ряда S=-1/(3*1)+1 / (5 * 2) - 1 / (7 * 3) + 1 / (9 * 4) 
Вычисление прекратить, когда модуль очередного слагаемого станет меньше 0,001.	*/


namespace Lab_3_1_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m = 3;
            double n = 1;
            int k = -1;
            double S = -1 / (m * n);
            double sum = S;
            Console.WriteLine($"S={S}, sum={sum}");

            while (Math.Abs(S) > 0.001)
            {                
                m += 2;
                n++;
                k = - k;
                S = k * (1 / (m * n));
                sum += S;
                Console.WriteLine($"S={S}, sum={sum}");
            }
            Console.ReadKey();
        }
    }
}
