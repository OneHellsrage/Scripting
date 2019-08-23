using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] CoordsX = {0,2,3,7};
            int[] CoordsY = { 0,1,5,6 };

            double m1, m2, m3;
            m1 = (CoordsY[1] - CoordsY[0]) / (CoordsX[1] - CoordsX[0]);
            m2 = (CoordsY[2] - CoordsY[1]) / (CoordsX[2] - CoordsX[1]);
            m3 = (CoordsY[3] - CoordsY[2]) / (CoordsX[3] - CoordsX[2]);
            double b1, b2, b3;
            b1 = CoordsY[1] + m1 * CoordsX[1];
            b2 = CoordsY[1] + m2 * CoordsX[1];
            b3 = CoordsY[2] + m3 * CoordsX[2];
            double d1, d2, d3, Dmayor = 0;
            d1 = Math.Sqrt(Math.Pow((CoordsX[1] - CoordsX[0]), 2) + (Math.Pow((CoordsY[1] - CoordsY[0]), 2)));
            d2 = Math.Sqrt(Math.Pow((CoordsX[2] - CoordsX[1]), 2) + (Math.Pow((CoordsY[2] - CoordsY[1]), 2)));
            d3 = Math.Sqrt(Math.Pow((CoordsX[3] - CoordsX[2]), 2) + (Math.Pow((CoordsY[3] - CoordsY[2]), 2)));

           
            if (m1 != m2 && m2 != m3) Console.Write("Los puntos no pertenecen a la misma recta ");
            else if (b1 != b2 && b2 != b3) Console.Write("Los puntos no pertenecen a la misma recta ");
            else Console.Write("Los puntos pertenecen a la misma recta ");

            if (d1 > Dmayor && d2 < d1 && d3 < d1) Dmayor = d1;
            else if (d2 > Dmayor && d1 < d2 && d3 < d2) Dmayor = d2;
            else
            {
                Dmayor = d3;
            }
            Console.Write("\n la mayor distancia es: " + Dmayor);

        
        }
    }
}
