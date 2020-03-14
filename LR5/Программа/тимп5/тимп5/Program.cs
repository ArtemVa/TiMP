using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace тимп5
{


    class Program
    {
        public class FIFO
        {
            public float[] mas;//массив
            public int size;//количество элементов в очереди
            public int head=-1;
            public int tail=-1;
            public int length;
            public FIFO(int length)
            {
                mas = new float[length];
                size = Count_elements();
                this.length = length;
            }
            //проверка на пустоту
            public bool isEmpty()
            {
                return size == 0;
            }

            //Вставка элемента в очередь
            public void Enqueue(float newelement)
            {
                if ((tail == length) || (head == length)) throw new InvalidOperationException("Переполнение очереди");
                else tail++;
                size++;
                mas[tail] = newelement;

            }
            //Извлечение элемента из очереди
            public float Dequeue()
            {
                if (isEmpty()) throw new InvalidOperationException("Очередь опустошенна");

                else head++;
                size--;
                float T = mas[head];
                mas[head] =0;
                return T;
            }

            //Прочтение первого элемента без его выборки из очереди
            public float Peek()
            {
                return mas[head + 1];
            }
            // определение количества элементов очереди
            public int Count_elements()
            {
                return tail - head;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(40 / 3);
            FIFO n = new FIFO(5);
            //Вставка элементов в очередь
            n.Enqueue(23);
            n.Enqueue(90);
            n.Enqueue(13);
            n.Enqueue(96);          
            n.Enqueue(2);
            //Извлечение элемента из очереди 
            n.Dequeue().ToString();
            //очередь 
            Console.Write(string.Join("  ", n.mas));
            //количесиво элементов в очереди
            Console.WriteLine("Количество элементов очереди " + n.Count_elements());
            //первый элемент очереди
            Console.WriteLine("Первый элемент "+ n.Peek());
        }
    }
}
