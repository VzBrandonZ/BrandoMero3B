using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA1
    {
        public void PROYECT1()
        {
            int Cantidad = 0, Aternos = 0, Z = 0;
            int[] X = new int[Cantidad];
            string Data = "", Data2 = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                ╔══════════════════════════════════════════════════╗ ");
            Console.WriteLine("                ║ ¿Cuantos numeros desea registrar en el programa? ║ ");
            Console.WriteLine("                ╚══════════════════════════════════════════════════╝ ");
            Console.WriteLine();
            Data = Console.ReadLine();
            Cantidad = Convert.ToInt32(Data);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int ca = 1; ca <= Cantidad; ca++)
            {
                Console.WriteLine("Ingrese el numero {0}", ca);
                Data2 = Console.ReadLine();
                Aternos = Convert.ToInt32(Data2);
                if (Aternos > Z)
                {
                    Z = Aternos;
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("El numero mayor es el: {0}", Z);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("/////////////////////////////////////////");
            Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
            Console.WriteLine("/////////////////////////////////////////");
            Console.ReadKey();
        }
    }
}
