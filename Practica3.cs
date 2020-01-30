using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Practica3
    {
        static void Main(string[] args)
        {
            try
            {
                string opcion;

                Int16[,] matriz1 = new Int16[4, 5];
                List<int> listapp = new List<int>();

                Random Num = new Random();
                for (short i = 0; i < 4; i++)
                {
                    for(short j = 0; j < 5; j++)
                    {
                        matriz1[i, j] = (Int16)Num.Next(1, 10);
                    }
                }
                Console.WriteLine("El resultado es " + sumaMatriz(matriz1));
                listapp = sumfilsumcol(matriz1, 4, 5);
                if (listapp.Count == 0) Console.WriteLine("La lista está vacía");
                else
                {
                    foreach(Int16 elemento in listapp)
                    {
                        Console.WriteLine(elemento);
                    }
                }
                /*do
                {

                    opcion = menu();

                    switch (opcion.Substring(0))
                    {

                        case "1":
                            op1();
                            break;
                        case "2":
                            op2();
                            break;
                        case "3":
                            op3();
                            break;
                        case "S":
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        default:
                            Console.WriteLine("Opción Inválida");
                            break;
                    }

                }

                while (!opcion.Equals("S"));
                */
            }

            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ocurrió Error en " + error);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

            }

            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fin de Ejecución");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }
        }

        public static int sumaMatriz(Int16[,] matriz)
        {
            int resultado = 0;
            for (short i = 0; i < 4; i++)
            {
                for (short j = 0; j < 5; j++)
                {
                    resultado += matriz[i, j];
                }
            }

            return resultado;

        }

        public static List<int> sumfilsumcol(Int16[,] matriz, short nrfil, short nrcol)
        {
            List<int> ListaResultados = new List<int>();
            int sumafil = 0, sumacol = 0;
            try
            {
                for(short i = 0; i < nrfil; i++)
                {
                    for(short j = 0; j < nrcol; j++)
                    {
                        sumafil += matriz[i, j];
                    }
                }
                for (short i = 0; i < nrcol; i++)
                {
                    for (short j = 0; j < nrfil; j++)
                    {
                        sumacol += matriz[j, i];
                    }
                }

                ListaResultados.Add(sumafil);
                ListaResultados.Add(sumacol);
            }
            catch(Exception error)
            {
                Console.WriteLine("Ocurrió un error en la subrutina sumfilsumcol " + error);
            }
            return ListaResultados;
        }
        public static string menu()
        {
            string opcion;

            Console.WriteLine("****** Digite su opción ******");
            Console.WriteLine("1. Opcion 1");
            Console.WriteLine("2. Opcion 2");
            Console.WriteLine("3. Opcion 3");
            Console.WriteLine("S. Salir");

            opcion = Console.ReadLine();

            return opcion;

        }
        public static void op1()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public static void op2()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void op3()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        
    }
}
