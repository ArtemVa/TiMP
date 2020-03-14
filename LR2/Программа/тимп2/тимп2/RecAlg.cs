using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тимп2
{
    public class RecAlg
    {
        //Сумма целых чисел от 1 до N
        public int RetSum(int N)
        {
            if (N == 1)
                return 1;

            if (N % 2 == 1)

                return N + RetSum(N - 1);

            else
                return RetSum(N - 1);


        }
        //Минимальный отрицательный элемент массива
        public int Massiv(int min, int [] m, int i =0)
        {

            if (i >= m.Length)
                return min;
            if (m[i] < 0)
            {

                if (m[i] < min) min = m[i];         
                return Massiv(min, m, i+1);
            }
            else if (m[i] >= 0 && i < m.Length - 1) { return Massiv(min, m, i + 1); }
            else return min;

        } 
    }
}
