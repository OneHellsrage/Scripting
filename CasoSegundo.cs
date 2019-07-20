using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_2
{
    class CasoSegundo
    {
        static void Main()
        {
            // Variables
            Console.WriteLine("Ingrese el valor t de la hipotenusa: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor a del ángulo formado por la hipotenusa t y el cateto opuesto Z del triángulo: ");
            double aGrados = double.Parse(Console.ReadLine());

            // Operaciones  
            double a = aGrados * (Math.PI / 180);
            double c = (90 - aGrados);
            double Z = t*(Math.Cos(a));
            double Y = Math.Sqrt(t * t - Z * Z);
            

            
            

            // Salida
            Console.WriteLine("El valor del tercer ángulo es: " + c);
            Console.WriteLine("El valor del cateto opuesto Z es: " + Z);
            Console.WriteLine("El valor del cateto adyacente Y es: " + Y);



        }
    }
}
