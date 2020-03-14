using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using тимп4;

namespace тимп4Test
{
    [TestFixture]
    public class sortTest
    {
        [Test]
        public static void QS()
        {
            Random b = new Random();
            int[] mas = new int[10];
            for (int i =0;i<mas.Length;i++)
            {
                mas[i] = b.Next(-450, 450);
            }
            int l, r;
            l = 0;
            r = mas.Length - 1;
            sort.QuickSort(mas,l,r);
            bool sor = true;
            for (int i = 0; i < mas.Length-1;i++)
            {
                if (mas[i] > mas[i + 1])
                    sor = false;
            }
            Assert.IsTrue(sor);
        }
        [Test]
        public static void CS()
        {
            Random a = new Random();
            int[] coun = new int[10];
            for(int i =0; i<coun.Length;i++)
            {
                coun[i] = a.Next(-41, 90);
            }
            sort.CountingSort(coun);
            bool s = true;
            for (int i = 0; i < coun.Length-1; i++)
            {
                if (coun[i] > coun[i + 1])
                    s = false;
            }
            Assert.IsTrue(s);
        }
    }
}
