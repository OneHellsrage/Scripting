using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_10
{
    class Tarea10
    {
        static void Main()
        {

            Console.WriteLine("Ingrese el número de jugadores: ");
            int J = int.Parse(Console.ReadLine());
            int i = 0, w = 0;
            int[] puntaje = new int[J];

            for (i = 0; i < J; i++)
            {
                Console.WriteLine("Hola, Jugador " + (i  + 1));
                Random Aleatoria = new Random();
                string Continuar = "s";
                int Carta1, total = 0;
                while (total < 21 && Continuar == "s")
                {                    
                    Carta1 = Aleatoria.Next(1, 11);
                    total += Carta1;
                    if (total > 21)
                    {
                        Console.WriteLine("\n carta: " + Carta1);
                        total = 0;
                        Console.WriteLine("Ha perdido");
                        break;
                    }
                    Console.WriteLine("\n carta: " + Carta1);
                    Console.WriteLine("\n Total: " + total);
                    Console.WriteLine("\n ¿Desea tomar otra carta? (s/n): ");
                    Continuar = Console.ReadLine();
                    puntaje[i] = total;
                }
                Console.WriteLine("Total de puntos: " + total);                                              
            }
            int mayor = 0;
            int jugador = 0;
            while (w < J)
            {
                if (puntaje[w] > mayor)
                {
                    mayor = puntaje[w];
                    jugador = w + 1;                  
                }
                w++;
            }
            Console.Write("\n El jugador con el mayor puntaje es el jugador: " + jugador);
            jugador -= 1;
            puntaje[jugador] = 0;
            w = 0;
            mayor = 0;
            while (w < J)
            {
                if (puntaje[w] > mayor)
                {
                    mayor = puntaje[w];
                    jugador = w + 1;
                }
                w++;
            }
            Console.Write("\n El jugador con el segundo mayor puntaje es el jugador : " + jugador);

        }
    }
}
