using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Расчет суммы минимального и максимального чисел
            int Max = 0, Min = 50;
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.WriteLine("{0} ", array[i]);
                if (array[i] >= Max)
                {
                    Max = array[i];
                }
                if (array[i] <= Min)
                {
                    Min = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма максимального и минимального чисел равна {0}", Max + Min);
            Console.ReadKey();



        }
    }
}
