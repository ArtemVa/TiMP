using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp2;

namespace ConsoleApp2Test
{
    [TestFixture]
    public class AreaTest
    {
        // Проверка попадания точки в область
        [Test]
        public void IsInAreaTest_PointInArea()
        {
            Area A = new Area(1);
            bool expected = true;
            bool actual = A.IsInArea(-0.1, -0.2);
            Assert.AreEqual(expected, actual);
        }
        // метод TestPoint, определяющий в какой из
        //областей находится точка с заданными координатами
        //1 - точка принадлежит закрашенной области
        //2 - точка принадлежит незакрашенной области
        //3 - точка лежит за пределами фигуры
        [Test]
        public void TestPointInArea()
        {
            
            Area A = new Area(1);
            int expected = 1;
            int actual = A.Figure_Area(1, 1);
            Assert.AreEqual(expected, actual);
        }
        // Проверка выбрасывания исключения
        // при некорректном значении радиуса
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsInAreaTest_NegativeRadiusThrowsException()
        {
            Area A = new Area(1);
            A.R = -1;
        }
        // Проверка попадания точек на границе
        // при помощи TestCase
        [Test]
        [TestCase(1, 0.9, 0.5, true)]
        [TestCase(1, 0.5, 0, true)]
        [TestCase(1, 1.5, 0.01, true)] 
        public void IsInAreaTest_PointsOnCurves_InArea
        (double R, double x, double y, bool expected)
        {
            Area A = new Area(R);
            bool actual = A.IsInArea(x, y);
            Assert.AreEqual(expected, actual);
        }
        // Проверка попадания точек на границе
        // при помощи TestCaseSource
        // Работа через массив массивов тестовых данных
        [Test]
        [TestCaseSource("PointsNearCurvesCases")]
        public void IsInAreaTest_PointsNearCurves_NotInArea(double R, double x, double y, bool expected)
        {
            Area A = new Area(R);
            bool actual = A.IsInArea(x, y);
            Assert.AreEqual(expected, actual);
        }
        static object[] PointsNearCurvesCases = {
new object[] { 1, -0.2, 1, false },
new object[] { 1, 0.01, 1, false },
new object[] { 1, 0.5, 1, false },
};
    }
}
