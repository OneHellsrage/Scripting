using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_1
{
    class CasoPrimero
    {
        static void Main()
        {
            // Variables
            Console.WriteLine("ingrese el valor del cateto adyacente Y del triángulo RECTÁNGULO: ");
            double Y = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del cateto opuesto Z del triángulo RECTÁNGULO: ");
            double Z = double.Parse(Console.ReadLine());           

            // Operaciones
            double H = Math.Sqrt(Y * Y + Z * Z);
            double a = Math.Asin(Y / H);
            double ag = a * (180 / Math.PI);
            double cg = (90 - ag);

            // Salida
            Console.WriteLine("El valor de la Hipotenusa del triángulo es: " + H);
            Console.WriteLine("El valor del ángulo a es: " + ag);
            Console.WriteLine("El valor del ángulo c es: " + cg);

        }
    }
}
