using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            double sum = 0;
            double sred = 0;


            for (int i = 0; i < 7; i++)
            {
                array [i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            sred = sum / 7;
            Console.WriteLine("Среднее арифметическое всех чисел массива {0}", sred);
            Console.ReadKey();
        }
    }
}
