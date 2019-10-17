using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA7
    {
        public void PROYECT7()
        {
            int Contador = 0, k = 101;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("█         Columna1              █           Columna2             █");
            Console.WriteLine("██████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.White;
            for (int C = 1; C <= 100; C++)
            {
                k--;

                Console.WriteLine("█    ◄{0,8}       ►          █      ◄{1,8}       ►         █", C, k);
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
