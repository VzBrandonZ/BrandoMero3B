using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA6
    {
        public void PROYECT6()
        {
            int Numero, Contador = 1;
            string Data1 = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("           ╔═════════════════════════════════════════════════════════╗ ");
            Console.WriteLine("           ║    Ingrese el tamaño del rombo que se va a presentar.   ║ ");
            Console.WriteLine("           ╚═════════════════════════════════════════════════════════╝ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Data1 = Console.ReadLine();
            Numero = Convert.ToInt32(Data1);
            Contador = Numero - 1;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int k = 1; k <= Numero; k++)
            {
                for (int i = 1; i <= Contador; i++)
                    Console.Write(" ");
                Contador--;
                for (int i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Contador = 1;
            for (int k = 1; k <= Numero - 1; k++)
            {
                for (int i = 1; i <= Contador; i++)
                    Console.Write(" ");
                Contador++;
                for (int i = 1; i <= 2 * (Numero - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("/////////////////////////////////////////");
            Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
            Console.WriteLine("/////////////////////////////////////////");
            Console.ReadLine();
        }
    }
}
