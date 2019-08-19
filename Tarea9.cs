using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_9
{
    class Tarea9
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado, total = 0, contador = 0, vidas = 3;
            string arrojar = "s";

            while (arrojar == "s")
            {
                Console.WriteLine("¿Desea arrojar el dado? (s/n): ");
                arrojar = Console.ReadLine();
                dado = aleatorio.Next(1, 7);
                Console.Write("\n dado: " + dado);
                total += dado;
                Console.Write("\n total: " + total);
                Console.Write("\n vidas: " + vidas);

                if (arrojar == "s")
                {
                    contador += 1;
                    if (contador % 2 == 0) vidas -= 1;
                }
                
                if (arrojar == "s" && contador % 3 == 0)
                {                   
                    int dado2 = aleatorio.Next(1, 7);
                    Console.Write("\n dado2: " + dado2);
                    total += dado2;
                    Console.Write("\n total: " + total);
                    Console.Write("\n vidas: " + vidas);
                    if (dado == dado2) vidas += 1;                   
                }
                if (vidas == 0)
                {
                    Console.WriteLine("se han acabado tus vidas");
                    break;
                }
            }
            Console.WriteLine("Su total de puntos es: " + total);
        }  
    }
}
