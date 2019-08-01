using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese la cantidad de votos del partido 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de votos del partido 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de votos en blanco: ");
            int VotosBlanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de votos anulados: ");
            int VotosAnulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Número total de la población de todas las edades: ");
            int Poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de la población que es mayor de edad: ");
            double Porcentaje = double.Parse(Console.ReadLine());

            double VotantesPosibles = (Poblacion * Porcentaje) / 100;
            double TodosLosVotos = a + b + VotosAnulados + VotosBlanco;
            double Abstención = VotantesPosibles - TodosLosVotos;
            int VotosTotales = a + b + VotosBlanco + VotosAnulados;
          


            bool A = VotosAnulados < 0.3 * (a + b);
            bool B = a + b > VotosBlanco;
            bool C = Abstención < VotantesPosibles;
            if (((A || B) && C) && a > b)
            {
                Console.WriteLine("Las votaciones se realizaron de forma exitosa");
                Console.WriteLine("El Partido ganador de las elecciones es el 1");
            }else if (((A || B) && C) && b > a)
            {
                Console.WriteLine("Las votaciones se realizaron de forma exitosa");
                Console.WriteLine("El Partido ganador de las elecciones es el 2");
            }else
            {
                Console.WriteLine("Las elecciones deben repetirse");
            }

            Console.WriteLine("Abstención: " + Abstención);
            Console.WriteLine("Votos totales: " + VotosTotales);
            Console.WriteLine("Población mayor de edad: " + VotantesPosibles);
        }
    }
    }

