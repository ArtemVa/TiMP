using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using тимп2;

namespace тимп2Test
{
    [TestFixture]
    public class RecAlgTest
    {
        //проверка суммы нечётных чисел
        [Test]
        public void rav()
        {
            RecAlg A = new RecAlg();
            int expected = 16;
            int actual = A.RetSum(7);
            Assert.AreEqual(expected, actual);
        }
        //проверка на минимальный отрицательный массива 
        [Test]
        public void prov()
        {
            RecAlg a = new RecAlg();
            int[] m = { -12, -41, 2, 32 };
            int expected = -41;
            int actual = a.Massiv(m.Min(), m);
            Assert.AreEqual(expected, actual);
        }       
    }
}
