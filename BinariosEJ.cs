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
            Console.WriteLine("Ingrese el primer valor: ");
            int B1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            int B2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercero valor: ");
            int B3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto valor: ");
            int B4 = int.Parse(Console.ReadLine());

            // Operaciones

            double Valortotal = (B1 * Math.Pow(2, 3)) + (B2 * Math.Pow(2, 2) + (B3 * Math.Pow(2, 1)) + (B4 * Math.Pow(2, 0)));

            // Salida

            Console.WriteLine("El valor numérico de los números especificados es: " + Valortotal);


        }
    }
}
