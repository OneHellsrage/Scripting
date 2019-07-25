using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class T2C2
    {
        static void Main()
        {
            // Variables.
            Console.WriteLine("Ingrese el valor definido como d: ");
            double dG = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor definido como b: ");
            double bG = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor definido como Y: ");
            double Y = double.Parse(Console.ReadLine());

            // Ecuaciones
            double eG = 180 - dG - bG;
            double cG = 180 - eG;
            double c = cG * (Math.PI / 180);
            double aG = 180 - 90 - cG;
            double a = aG * (Math.PI / 180);
            double Z = (Y * (Math.Sin(c) / (Math.Sin(a))));

            // Salida

            Console.WriteLine("Z: " + Z);
        }
    }
}
