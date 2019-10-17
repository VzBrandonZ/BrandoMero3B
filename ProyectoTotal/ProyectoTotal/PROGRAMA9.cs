using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA9
    {
        public void PROYECT9()
        {
            Console.Clear();
            int T1 = 0, T2 = 0, S = 0, F = 1;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                ╔═══════════════════════════════════════════╗");
            Console.WriteLine("                ║   Las tabla de multiplicar del 1 al 15    ║");
            Console.WriteLine("                ╚═══════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int C = 1; C <= 12; C++)
            {
                for (int Z = 1; Z <= 6; Z++)
                {
                    if (Z >= 1 && Z <= 5)
                    {
                        Console.Write("{0}X{1}={2}\t\t", Z, C, Z * C);
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                }
            }
            Console.WriteLine();
            for (int C = 1; C <= 12; C++)
            {
                Console.WriteLine("");
                for (int Z = 6; Z <= 10; Z++)
                {
                    Console.Write("{0,2}X{1,1}={2,3}\t", Z, C, Z * C);
                }

            }
            Console.WriteLine();
            for (int C = 1; C <= 12; C++)
            {
                Console.WriteLine("");
                for (int Z = 11; Z <= 15; Z++)
                {
                    Console.Write(" {0}X{1}={2}\t", Z, C, Z * C);
                }

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
