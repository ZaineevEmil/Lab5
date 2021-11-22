using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Расчет среднеарифмитического 7 чисел
            double sum = 0;
            Console.WriteLine("Введите семь чисел");
            double[] array = new double[7];
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
                sum = array[i] + sum;
            }
            Console.WriteLine("Среднеарифмитическое чисел = {0:f3}", sum / 7);
            Console.ReadKey();
        }
    }
}
