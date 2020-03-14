using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace тимп4
{
    class Program
    {
        // Сортировка подсчётом
        public static int[] CountingSort(int[] m)
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
            return m;
        }

        //быстрая сортировка QuickSort
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
        static void Main(string[] args)
        {

            
            // сортировка расчёской 
            Console.WriteLine("Сортировка подсчётом");
            Console.WriteLine("Введите размерность массива");
            Console.WriteLine("Введите размерность массива(1000, 10000, 100000,1000000)");
            //размерность массива
            int razmer = Convert.ToInt32(Console.ReadLine());
            Random x = new Random();
            Stopwatch stopWatch = new Stopwatch();
            //время инициализации массива
            stopWatch.Start();
            // массив из случайных чисел
            int[] counting = new int[razmer];
            for (int i =0;i<counting.Length;i++)
            {
                counting[i] = x.Next(-400, 400);
            }
            stopWatch.Stop();
            //конец
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Время иницализации масиива" + elapsedTime);

            Console.WriteLine("Исходный массив");
            Console.WriteLine(string.Join(",", counting));
            Stopwatch STOPwatch = new Stopwatch();
            STOPwatch.Start();
            //замер времени
            CountingSort(counting);
            Console.WriteLine("Массив после сортировки подсчётом");
            Console.WriteLine(string.Join(",", counting));
            STOPwatch.Stop();
            //окончание
            TimeSpan TS1 = stopWatch.Elapsed;
            string ElapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", TS1.Hours, TS1.Minutes, TS1.Seconds, TS1.Milliseconds / 10);
            Console.WriteLine("Время сортировки подсчётом из " + razmer + " элементов " + ElapsedTime);

            Console.WriteLine("Быстрая сортирвка");
            Console.WriteLine("Введите размерность массива");
            Console.WriteLine("Введите размерность массива(1000, 10000, 100000,1000000)");
            //размерность массива
            int razmer1 = Convert.ToInt32(Console.ReadLine());
            Random v = new Random();
            Stopwatch stopwatch = new Stopwatch();
            // время инициализации массива  

            stopwatch.Start();
            //массив из рандомных чисел
            int[] quicksort = new int[razmer1];
            for (int i = 0; i < quicksort.Length; i++)
            {
                quicksort[i] = v.Next(-10000, 10000);
            }
            stopwatch.Stop();
            // конец 
            TimeSpan Ts = stopwatch.Elapsed;
            string elapsedtime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", Ts.Hours, Ts.Minutes, Ts.Seconds, Ts.Milliseconds / 10);
            Console.WriteLine("Время иницализации масиива" + elapsedtime);

            Console.WriteLine("Исходный массив");
            Console.WriteLine(string.Join(",", quicksort));
            Stopwatch stopWatch1 = new Stopwatch();
            // Замер времени 

            stopWatch.Start();

            Console.WriteLine("Массив после быстрой сортировки");
            QuickSort(quicksort, 0, quicksort.Length - 1);
            Console.WriteLine(string.Join(",", quicksort));
            stopWatch.Stop();
            // окончание 
            TimeSpan ts1 = stopWatch.Elapsed;
            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10);
            Console.WriteLine("Время быстрой сортировки из " + razmer1 + " элементов " + elapsedTime1);

        }
    }
}

