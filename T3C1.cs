using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_1
{
    class T3C1
    {
        static void Main()
        {
            // Variables
            Console.WriteLine("Por favor ingrese el valor de su salario actual: ");
            int Salario = int.Parse(Console.ReadLine());
            int Minimo = 828116;
            // Condiciones
            if (Salario < 2 * Minimo)
            {
                Console.WriteLine("La tarifa correspondiente es la que pertenece a la categoría A");
            }
            else if (2 * Minimo <= Salario && Salario < 4 * Minimo)
            {
                Console.WriteLine("La tarifa correspondiente es la que pertenece a la categoría B");
            }else
            {
                Console.WriteLine("La tarifa correspondiente es la que pertenece a la categoría C");
            }
        } 
    }
}
