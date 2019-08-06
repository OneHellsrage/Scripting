using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
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
            

            // Operaciones           
            double TodosLosVotos = a + b + VotosAnulados + VotosBlanco;

            // Condiciones

            bool A = TodosLosVotos > Poblacion;
            bool B = Math.Abs(a - b) < ((0.1) * TodosLosVotos);
            bool C = TodosLosVotos < (0.3) * Poblacion;

            if ((A || B) && C) {

                Console.WriteLine("Las elecciones deben ser repetidas");
            }else if (a > b)
            {
                Console.WriteLine("Los ganadores de las elecciones son el partido 1");
            }else if (a == b)
            {
                Console.WriteLine("las elecciones deben ser repetidas");
            }else
            {
                Console.WriteLine("Los ganadores de las elecciones son el partido 2");
            }
        }
    }
}
