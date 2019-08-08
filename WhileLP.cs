using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ingrese el número de datos: ");
            int datos = int.Parse(Console.ReadLine());
            double total = 0;
            int contador = 0;
            int maximo = 0;
            int minimo = 200;
            string nombreminimo = "";
            string nombremaximo = "";

            while (contador < datos)
            {
                Console.Write("Nombre y edad: ");
                string nombre = Console.ReadLine();
                int edad = int.Parse(Console.ReadLine());
                if (edad >= maximo)
                {
                    maximo = edad;
                    nombremaximo = nombre;
                }
                if (edad <= minimo)
                {
                    minimo = edad;
                    nombreminimo = nombre;
                }
                total += edad;
                contador += 1;

                
            }

            double promedio = total / contador;
            Console.WriteLine("primedio: " + promedio);
            Console.WriteLine("Mayor edad: " + maximo);
            Console.WriteLine("menor edad: " + minimo);
            Console.WriteLine("nombre del mayor: " + nombremaximo);
            Console.WriteLine("nombre del menor: " + nombreminimo);


        }
    }
}
