using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public class Area
    {
        private double r;
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value < 0)
                    throw new
                    ArgumentOutOfRangeException("Должно быть больше или равно нулю");
                r = value;
            }
        }
        public Area(double R)
        {
            this.R = R;
        }
        public bool IsInArea(double x, double y)
        {
            if ((x <= 0) && (y <= 0) && (x >= -R) && (y >= -R) && ((x+R) *(x+R) + (y+R) * (y+R) >= R) || ((x >= 0) && (y >= 0) && (y <= R) && (x <= 2 * R) && ((x - R) * (x - R) + y * y < R)))
                return true;
            return false;
                     
        }
        public int Figure_Area(double x, double y)
        {
            if ((x <= 0) && (y <= 0) && (x >= -R) && (y >= -R) && ((x + R)* (x+R) + (y+R) * (y+R) >= R) || ((x >= 0) && (y >= 0) && (y <= R) && (x <= 2 * R) && ((x - R) * (x - R) + y * y <= R)))
                return 1;// Принадлежит закрашенной области

            else if (((x < 0) && (y < 0) && (x >= -2) && (y >= -2) && ((x + R) * (x + R) + y  * y  <= R)) || ((x > 0) && (y < 0) && ((x - R) * (x - R) - y * y < R)))
            {
                return 2;//Принадлежит незакрашенной области
            }
            else
            {
                return 3;// Лежит за пределами фигуры
            }
        }
    }
}

