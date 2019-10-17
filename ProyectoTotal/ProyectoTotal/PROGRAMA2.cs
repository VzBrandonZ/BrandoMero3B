using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA2
    {
        public void PROYECT2()
        {
            int Num1 = 0;
            string Data1 = "";
            Console.Clear();
            Console.WriteLine("                ╔═══════════════════════════════════════════╗");
            Console.WriteLine("                ║ registre el tamaño del cuadro a presentar ║");
            Console.WriteLine("                ╚═══════════════════════════════════════════╝");
            Data1 = Console.ReadLine();
            Num1 = Convert.ToInt32(Data1);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (Num1 >= 0 && Num1 <= 50)
            {
                for (int C = 0; C < Num1; C++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("   ");
                for (int C = 0; C < Num1 - 2; C++)
                {
                    Console.Write("* ");
                    for (int Z = 0; Z < Num1 - 2; Z++)
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine("*");
                }
                for (int X = 0; X < Num1; X++)
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("/////////////////////////////////////////");
            Console.WriteLine("//   PRESIONE (INTRO)-->>PARA  SALIR.  //");
            Console.WriteLine("/////////////////////////////////////////");
            Console.ReadKey();
        }
    }
}
