using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_4
{
    class T2C4
    {
        static void Main()
        {
            // Variables
            Console.WriteLine("Ingrese el valor identificado como W: ");
            double W = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor identificado como T: ");
            double T = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor identificado como c: ");
            double cG = double.Parse(Console.ReadLine());

            // Operaciones
            double eG = 180 - cG;
            double e = eG * (Math.PI / 180);
            double d = Math.Asin(T * Math.Sin(e) / W);
            double dg = d * (180 / Math.PI);
            double bG = 180 - eG - dg;
            double b = bG * (Math.PI / 180);
            double X = W * (Math.Sin(b)) / Math.Sin(e);

            // Salida

            Console.WriteLine("X: " + X);

        }
    }
}
