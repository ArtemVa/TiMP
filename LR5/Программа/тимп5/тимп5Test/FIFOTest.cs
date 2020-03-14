using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using тимп5;

namespace тимп5Test
{
    [TestFixture]
    public class FIFOTest
    {
        //количество элементов в очереди
        [Test]
        public void Count_elTest()
        {
            FIFO a = new FIFO(10);
            a.Enqueue(5.7f);
            a.Enqueue(5f);
            a.Enqueue(3.43f);
            Assert.AreEqual(3, a.Count_elements());
            Assert.IsFalse(a.isEmpty());
        }
        //проверка на первый элемент очереди
        [Test]
        public void PeekTest()
        {
            FIFO b = new FIFO(8);
            float expected = 2.7f;
            b.Enqueue(2.7f);
            Assert.AreEqual(expected, b.Peek());
            Assert.IsFalse(b.isEmpty());
        }
        // количество элементов в очереди после удаления элемента очереди
        [Test]
        public void CountTest()
        {
            FIFO R = new FIFO(14);
            R.Enqueue(54f);
            R.Enqueue(78f);
            R.Enqueue(3.4f);
            R.Enqueue(33f);
            R.Dequeue();
            int expected = 3;
            Assert.AreEqual(expected, R.Count_elements());
        }
    }
}
