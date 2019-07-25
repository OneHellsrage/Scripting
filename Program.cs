using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Variables
            Console.WriteLine("Ingrese el valor identificado como Z: ");
            double Z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor identificado como Y: ");
            double Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor identificado como b: ");
            double bG = double.Parse(Console.ReadLine());

            // Ecuaciones
            double T = Math.Sqrt(Z * Z + Y * Y);
            double b = bG * (Math.PI / 180);
            double c = Math.Asin(Z / T);
            double cG = c * (180 / Math.PI);
            double eG = 180 - cG;
            double dG = 180 - bG - eG;
            double d = dG * (Math.PI / 180);
            double X = ((T * (Math.Sin(b)) / Math.Sin(d)));


            // Salida

            Console.WriteLine(" X = " + X);
        }
    }
}
