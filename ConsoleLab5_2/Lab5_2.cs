using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab5_1
{
    class Lab5_2
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            int t = 1;
            int Sum;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0,2}-й элемент массива - {1}", t++, array[i]);
                Console.WriteLine();
            }
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }
            }
            Console.WriteLine("max - {0}", max);
            Console.WriteLine("min - {0}", min);
            Sum = max + min;
            Console.WriteLine("Сумма - {0}", Sum);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
