using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_3
{
    class T2C3
    {
        static void Main()
        {
            // Variables
            Console.WriteLine("Ingrese el valor identificado como W: ");
            double W = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor identificado como d: ");
            double dG = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor identificado como X: ");
            double X = double.Parse(Console.ReadLine());

            // Operaciones
            double d = dG * (Math.PI / 180);
            double T = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(W, 2) - 2 * X * W * Math.Cos(d));
            double c = Math.Asin(W * Math.Sin(d) / T);
            double cG = c * (180 / Math.PI);
            double aG = 180 - 90 - cG;
            double a = aG * (Math.PI / 180);
            double Z = T * Math.Sin(c);
            double Y = Z * Math.Sin(a) / Math.Sin(c);


            // Salida
            Console.WriteLine("Y: " + Y);
        }
    }
}
