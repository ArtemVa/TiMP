using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тимп33
{
    
    public class Sortirovka
    {
        //сортировка выбором
        public static void Selection(int[] mas)
        {
            for (int i = 0; i<mas.Length; i++)
            {
                int min = i;
                for (int j = i+1; j<mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                        min = j;
                }
           
                mas[i] = mas[min];
               
            }
        }
        // сортировка пузырьком
        public static void Bubble (int[] mas)
        {
            int p;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = 0; j < mas.Length - i - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        p = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = p;
                    }
                }
            }
        }

        // сортировка расчёской
        public static void CombSort(int[] mas)
        {
            double gap = mas.Length;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < mas.Length)
                {
                    int igap = i + (int)gap;
                    if (mas[i] > mas[igap])
                    {
                        int swap = mas[i];
                        mas[i] = mas[igap];
                        mas[igap] = swap;
                        swaps = true;
                    }
                    i++;
                }
            }
           
        }
    }
}
