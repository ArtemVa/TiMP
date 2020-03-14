using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тимп2
{
    class Program
    {
        static void Main()
        {
            RecAlg recAlg = new RecAlg();
            int[] m = new int[10];
            Random a = new Random();
            for (int i = 0; i < 5; ++i)
                m[i] = a.Next(-256, 256);

            for (int i = 0; i < 5; ++i)
                Console.WriteLine(m[i]);

            int min = recAlg.Massiv(m.Min(), m);
            if (min >= 0) Console.WriteLine("Массив состоит из положительных элементов");
            else Console.WriteLine("Минимальный отрицательный элемент массива" + min);
        }
    }
}
