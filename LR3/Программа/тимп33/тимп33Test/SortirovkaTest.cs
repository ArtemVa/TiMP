using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using тимп33;

namespace тимп33Test
{
    // Тесты
    [TestFixture]
    public class SortirovkaTest
    {
        // Сортировка выбором 
        [Test]
        public static void SortSelTest()
        {
            Random R = new Random();
            int[] mas = new int[58];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = R.Next(-256, 256);
            }
            Sortirovka.Selection(mas);
            bool sort = true;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (mas[i] > mas[i + 1])
                    sort = false;
            }
            Assert.IsTrue(sort);

        }
        // Сортировка пузырьком
        [Test]
        public static void BubbleTest()
        {
            Random R = new Random();
            int[] mas1 = new int[20];
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = R.Next(-256, 256);
            }
            Sortirovka.Bubble(mas1);
            bool sor = true;
            for (int i = 0; i < mas1.Length - 1; i++)
            {
                if (mas1[i] > mas1[i + 1])
                    sor = false;
            }
            Assert.IsTrue(sor);
        }
        // Сортировка расчёской 
        [Test]
        public static void CombTest()
        {
            Random R = new Random();
            int[] mas2 = new int[43];
            for (int i = 0; i < mas2.Length; i++)
            {
                mas2[i] = R.Next(-256, 256);
            }
            Sortirovka.CombSort(mas2);
            bool sorte = true;
            for (int i = 0; i < mas2.Length-1; i++)
            {
                if (mas2[i] > mas2[i + 1])
                    sorte = false;
            }
            Assert.IsTrue(sorte);
        }
    }
}
