using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Repaso2
{
    class Program
    {
        static void Main()
        {
            try
            {
                string Linea;
                string[] arreglo;
                StreamReader LeerArchivo = new StreamReader("C:\\Users\\B09S107est\\Documents\\Autos.txt");
                Linea = LeerArchivo.ReadLine();

                while(Linea != null)
                {
                    arreglo = Linea.Split('|');                  
                    Console.WriteLine("El carro con placa " + arreglo[0] + "Tiene " + arreglo[4] + " KMs");
                    Linea = LeerArchivo.ReadLine();
                }

                short[] Marcadores = new short[] {65,98,64,47};
                short total = 0;
                for (int i = 0; i <= 3; i++) Console.WriteLine("El marcador en el juego " + (i + 1) + "fue " + Marcadores[i]);
                for (short i = 0; i <= 3; i++) total += Marcadores[i];
                Console.WriteLine("El total marcado fue " + total);

                //Matrices

                string[] Vector2 = new string[100];
                char[,,] Espacio1 = new char[20, 10, 2];

                long[,] Matrizlong = new long[50, 40];
                Random NAleatorio = new Random();
                //Llenamos la matriz Long con aleatorios por filas.
                for (short i = 0; i < 50; i++)
                {
                    for (short j = 0; j < 40; j++)
                    {
                        Matrizlong[i,j] = NAleatorio.Next(1, 6);
                    }
                }
                for (short i = 0; i < 50; i++)
                {
                    for (short j = 0; j < 40; j++)
                    {
                        Console.Write(Matrizlong[i, j] + " - ");
                    }
                    Console.WriteLine();
                }

                //Listas.

                List<string> Lista_juegos = new List<string>();
                string Linea1;
                StreamReader LeerArchivo1 = new StreamReader("C:\\Users\\B09S107est\\Documents\\juegos.txt");
                Linea1 = LeerArchivo1.ReadLine();

                while (Linea1 != null)
                {
                    Lista_juegos.Add(Linea1);
                    Linea1 = LeerArchivo1.ReadLine();
                }
                Console.WriteLine("------Lista de juegos------");
                //Uso del -foreach-
                ImprimirLista(Lista_juegos);

                Console.WriteLine("------Lista de juegos ordenados------");
                Lista_juegos.Sort();
                ImprimirLista(Lista_juegos);



            }
            catch(Exception Error)
            {
                Console.WriteLine("Se presentó una excepción: " + Error);
                Console.ReadKey();
            }
        }

        public static void ImprimirLista(List<string> Lista_a_imprimir)
        {
            try
            {
                foreach (string elemento in Lista_a_imprimir)
                {
                    Console.WriteLine(elemento);
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("Se presentó una excepción: " + error);
                Console.ReadKey();
            }
        }
    }
}
