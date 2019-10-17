using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA8
    {
        public void PROYECT8()
        {
            int NumberE = 0, Z = 2, X = 3;
            string Data1 = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Registre un numero entero:");
            Data1 = Console.ReadLine();
            NumberE = Convert.ToInt32(Data1);
            if (NumberE > 0)
            {
                Console.WriteLine("   Columna1\t\tColumna2\t\tColumna3");
                Console.WriteLine("    1 en 1 \t         2 en 2 \t         3 en 3");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                Console.WriteLine("  █                                                    █");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int C = 1; C <= NumberE; C++)
                {
                    Console.WriteLine("  █{0,5}\t        {1,5}\t\t        {2,5}  █", C, Z, X);
                    Z = Z + 2;
                    X = X + 3;

                }
                Console.WriteLine("  █                                                    █");
                Console.WriteLine("  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usted registro un digito erróneo.");
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("/////////////////////////////////////////");
            Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
            Console.WriteLine("/////////////////////////////////////////");
            Console.ReadKey();
        }
    }
}
