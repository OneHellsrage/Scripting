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
            // Tipos de datos.

            short VarShort = 0;
            int VarEntera = 0;
            Int16 VarEnt16 = 0;
            string texto1, texto3;
            String texto2;

            double VarDoble = 130.37236872136782136129783678127386129836789123791027309812730912738902130;
            float Varfloat = 0.0f;

            char VarChar = 'D';

            // Conversiones. CAST:

            // 1. Char a Numérico.

            VarShort = (short)VarChar;
            Console.WriteLine("Equivalente de la " + VarChar + " es " + VarShort);

            // 2. double a short.

            VarShort = (short)VarDoble;
            Console.WriteLine("Equivalente del doble es " + VarDoble + " \n y en short es " + VarShort);

            // 3. Convertir string a numerico.

            VarEnt16 = Int16.Parse("146");
            Varfloat = float.Parse("445.67");
            VarEntera = int.Parse("431354");

            // condicionales.

            if(VarEntera == 100)
            {
                //Verdadero
                Console.WriteLine("Es verdadero");
            }
            else
            {
                //Falso
                Console.WriteLine("Es falso");
            }

            //       

            Console.WriteLine("Ingrese color 1: ");
            texto1 = Console.ReadLine().ToLower();
            Console.WriteLine("Ingrese color 2: ");
            texto2 = Console.ReadLine().ToLower();
            

            if (texto1.Equals("roja") && texto2.Equals("azul") || texto1.Equals("azul") && texto2.Equals("roja"))
            {
                Console.WriteLine("Premio mayor");
            }
            else if (texto1.Equals("azul") && texto2.Equals("azul"))
            {
                Console.WriteLine("Gana premio menor");
            }
            else
            {
                Console.WriteLine("Deamalas jobo");
            }

            //

            Console.WriteLine("Seleccione su opción de almuerzo entre el menú 1, 2, 3 ó 4");
            VarShort = short.Parse(Console.ReadLine());

            switch (VarShort)
            {
                case 1: Console.WriteLine("Mondongo");
                    break;
                case 2: Console.WriteLine("Changua");
                    break;
                case 3:Console.WriteLine("Tamal");
                    break;
                case 4:Console.WriteLine("Awita con salsa de tomate");
                    break;
                default:
                    Console.WriteLine("no come");
                    break;
            }

            //Ciclos.

            VarEntera = 0;
            while(VarEntera < 100) //Se cumple siempre que la condición sea verdadera.
            {
                Console.Write((VarEntera += 2) + "-");
            }

            do
            {
                Console.WriteLine("Entré al do While");
            } while (VarEntera < 100);

            Console.WriteLine("*******");

            for (short i = 0; i<= 100; i += 2)
            {               
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
        
        // Zona de subrutinas.

    }
}
