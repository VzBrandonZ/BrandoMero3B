using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA5
    {
        public void PROYECT5()
        {
            int Cantidad = 0;
            string Data1 = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("           ╔═════════════════════════════════════════════════════════╗ ");
            Console.WriteLine("           ║ Ingrese el tamaño de la piramide que se va a presentar. ║ ");
            Console.WriteLine("           ╚═════════════════════════════════════════════════════════╝ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Data1 = Console.ReadLine();
            Cantidad = Convert.ToInt32(Data1);
            int Num2 = 0;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int C = 0; C <= Cantidad; C++)
            {               //0<=4
                for (int B = 0; B <= Cantidad - C; B++)
                {               //0<= 4-2
                    Console.Write(" ");
                }
                for (int Z = 1; Z <= 2 * C - 1; Z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
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
