using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тимп4
{

    public class sort
    {
        //быстрая сортировка
        public static void QuickSort(int[] mas, int left, int right)
        {

            int i = left;
            int j = right;
            int x = mas[(left + right) / 2]; //Опорный элемент

            while (i <= j)
            {
                //разделение на 2 подмассива
                while (mas[i] < x) i++;
                while (mas[j] > x) j--;
                //Если i<=j:
                if (i <= j)
                {
                    //меняем элементы местами
                    int swap = mas[i];
                    mas[i] = mas[j];
                    mas[j] = swap;
                    i++;
                    j--;
                }
            }

            //Рекурсия
            if (left < j) QuickSort(mas, left, j);
            if (i < right) QuickSort(mas, i, right);
        }

        // Сортировка подсчётом
        public static void CountingSort(int[] m)
        {
            //находим минимальный и максимальный элемент массива
            int min = m[0];
            int max = m[0];
            for (int i = 1; i < m.Length; i++)
            {
                if (m[i] < min) min = m[i];
                else if (m[i] > max) max = m[i];
            }
            //создаём вспомогательный массив С, состоящий из нулей
            int[] count = new int[max - min + 1];
            int z = 0;

            for (int i = 0; i < count.Length; i++)
                count[i] = 0;

            for (int i = 0; i < m.Length; i++)
                count[m[i] - min]++;

            for (int i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    m[z] = i;
                    ++z;
                }
            }
            
        }
    }
}