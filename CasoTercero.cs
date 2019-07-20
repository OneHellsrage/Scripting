using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_3
{
    class CasoTercero
    {
        static void Main()
        {
            // Variables
            Console.WriteLine("Ingrese el valor del cateto opuesto Z: ");
            int Z = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del ángulo formado por la hipotenusa t y el cateto adyacente Y: ");
            double cGrados = double.Parse(Console.ReadLine());

            //Operaciones
            double a = (90 - cGrados);
            double c = cGrados * (Math.PI / 180);
            double t = (Z) / (Math.Sin(c));
            double Y = Math.Sqrt(t * t - Z * Z);


            //Salida
            Console.WriteLine("El valor del tercer ángulo es: " + a);
            Console.WriteLine("El valor de la hipotenusa t es: " + t);
            Console.WriteLine("El valor del cateto adyacente Y es: " + Y);



        }
    }
}
