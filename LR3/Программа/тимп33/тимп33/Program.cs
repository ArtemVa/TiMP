using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace тимп33
{
    class Program
    {
        //демонстрационный пример, позволяющий измерить время
        //сортировки случайным образом заполненного массива размером
        //1000, 10 000, 100 000 элементов.
        //сортировка выбором
        public static int[] Selection(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[min] > mas[j])
                    { min = j; }
                }
                int tmp = mas[i];
                mas[i] = mas[min];
                mas[min] = tmp;
            }
            return mas;
        }
        // сортировка пузырьком
        public static int[] Bubble(int[] mas)
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
            return mas;
        }

        // сортировка расчёской
        public static int[] CombSort(int[] mas)
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
            return mas;
        }
        static void Main(string[] args)
        {
            //сортировка выбором
            Console.WriteLine("Сортировка выбором");
            int[] bvb = { 1, 0, 7, 3, 7, 5 };
            Console.WriteLine(String.Join(" ",Selection(bvb)));
            Console.WriteLine("Введите размерность массива(1000, 10000, 100000)");          
                int n = Convert.ToInt32(Console.ReadLine());
                Stopwatch stopwatch = new Stopwatch();
                // время инициализации массива  

                stopwatch.Start();
                Random random = new Random();
                int[] r = new int[n];

                for (int i = 0; i < r.Length; i++)
                {
                    r[i] = random.Next(-1000, 1000);

                }
                stopwatch.Stop();
                // окончание 
                TimeSpan Ts = stopwatch.Elapsed;
                string elapsedtime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Ts.Hours, Ts.Minutes, Ts.Seconds, Ts.Milliseconds / 10);
                Console.WriteLine("Время иницализации масиива" + elapsedtime);
                //Сортировка выбором
                Console.WriteLine("Сортировка выбором");
                Console.WriteLine("Исходный массив");
                Console.WriteLine(string.Join(",", (r)));
                Console.WriteLine("Массив после сортировки выбором:");

                Stopwatch stopWatch = new Stopwatch();
                // Замер времени 

                stopWatch.Start();
                Console.WriteLine(string.Join(",", Selection(r)));
                stopWatch.Stop();
                // окончание 
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                Console.WriteLine("Время сортировки выбором " + n + " элементов " + elapsedTime);
            
            //Сортировка пузырьком 

            Console.WriteLine("Сортировка пузырькём");
            Console.WriteLine("Введите размерность массива(1000, 10000, 100000)");
            int w = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopwatch1 = new Stopwatch();
            // время инициализации массива  

            stopwatch.Start();
            int[] r1 = new int[w];

            for (int i = 0; i < r1.Length; i++)
            {
                r1[i] = random.Next(-1000, 1000);

            }
            stopwatch.Stop();
            // окончание 
            TimeSpan Ts1 = stopwatch.Elapsed;
            string elapsedtime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", Ts1.Hours, Ts1.Minutes, Ts1.Seconds, Ts1.Milliseconds / 10);
            Console.WriteLine("Время иницализации масиива" + elapsedtime1);
            Console.WriteLine("Исходный массив");
           
            Console.WriteLine(string.Join(",", (r1)));

            Console.WriteLine("Массив после сортировки выбором:");
            Stopwatch stopWatch1 = new Stopwatch();
            // Замер времени
            stopWatch.Start();
            Console.WriteLine(string.Join(",", Bubble(r1)));
            stopWatch.Stop();  
            // окончание
            TimeSpan ts1 = stopWatch.Elapsed;
            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10);
            Console.WriteLine("Время сортировки пузырьком " + elapsedTime1);
            //Сортировка расчёской 

            Console.WriteLine("Сортировка расчёской");
            Console.WriteLine("Введите размерность массива(1000, 10000, 100000)");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] r2 = new int[k];
            Stopwatch stopwatch2 = new Stopwatch();
            // время инициализации массива  

            stopwatch.Start();
            for (int i = 0; i < r2.Length; i++)
            {
                r2[i] = random.Next(-1000, 1000);

            }
            stopwatch.Stop();
            // окончание 
            TimeSpan Ts2 = stopwatch.Elapsed;
            string elapsedtime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", Ts2.Hours, Ts2.Minutes, Ts2.Seconds, Ts2.Milliseconds / 10);
            Console.WriteLine("Время иницализации масиива" + elapsedtime2);
            Console.WriteLine("Исходный массив");
            Console.WriteLine(string.Join(",", r2));
            Console.WriteLine("Массив после сортировки расчёской:");
            Stopwatch stopWatch2 = new Stopwatch();
            // Замер времени

            stopWatch.Start();
            Console.WriteLine(string.Join(",", CombSort(r2)));
            stopWatch.Stop();   
            // окончание 
            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10);
            Console.WriteLine("Время сортировки расчёской "  + elapsedTime2);
        }
    }
}
