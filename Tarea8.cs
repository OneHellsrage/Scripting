using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_7
{
    class Tarea8
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int total = 0, contador = 0, contador2 = 0, vidas = 3;
            string arrojar = "s";
            

            while (arrojar == "s")           
            {
                Console.WriteLine("¿Desea arrojar el dado? (s/n): ");
                arrojar = Console.ReadLine();
                int dado = aleatorio.Next(1, 7);
                Console.Write("\n dado: " + dado);
                total += dado;
                Console.Write("\n total: " + total);
                Console.Write("\n vidas: " + vidas);
                if (dado == 1)
                {
                    contador += 1;
                    if (contador % 2 == 0 && vidas > 0)
                    {
                        vidas -= 1;
                        total -= 10;
                    }
                }
                if (vidas == 0)
                {
                    Console.WriteLine("has perdido");
                    break;
                }
                if (dado == 6) contador2 += 1;
                if (dado != 6 && contador2 > 0) contador2 -= 1;
                if (contador2 == 2) vidas += 1;
                if (vidas > 3) vidas = 3;

            }

            Console.WriteLine("su total de puntos es: " + total);
        }
    }
}
