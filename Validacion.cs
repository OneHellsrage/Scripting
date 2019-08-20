using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int A, B, SumaC, Respuesta, intentos = 2;

            A = aleatorio.Next(1, 11);
            B = aleatorio.Next(1, 11);
            SumaC = A + B;
            Console.Write("Valor: " + A);
            Console.Write("Valor: " + B);
            Console.Write("ingrese el valor de la suma: ");
            Respuesta = int.Parse(Console.ReadLine());
            if (Respuesta != SumaC) intentos -= 1;
                while (Respuesta != SumaC)
            {
                Console.Write("ERROR. Intentelo de nuevo");              
                A = aleatorio.Next(1, 11);
                B = aleatorio.Next(1, 11);
                SumaC = A + B;
                Console.Write("Valor: " + A);
                Console.Write("Valor: " + B);
                Console.Write("ingrese el valor de la suma: ");
                Respuesta = int.Parse(Console.ReadLine());
                if (Respuesta != SumaC) intentos -= 1;
                if (intentos < 0) break;
                                
            }
            if (intentos < 0) Console.Write("Usted falló en grande");
            else
            {
                Console.Write("#ejecución del programa");
            }

        }
    }
}
