using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_2
{
    class T3C2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de su salario mensual");
            int Salario = int.Parse(Console.ReadLine());
            int Minimo = 828116;

            if ( Salario < 2*Minimo)
            {
                int A = 3200;
                Console.WriteLine("La Tarifa correspondiente es A, $: " + A);
            } else if (2*Minimo <= Salario && Salario <5*Minimo)
            {
                int B = 12700;
                Console.WriteLine("La Tarifa correspondiente es B, $: " + B);
            }else
            {
                int C = 33500;
                Console.WriteLine("La Tarifa correspondiente es C, $: " + C);
            }
        }
    }
}
