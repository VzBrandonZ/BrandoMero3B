using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA3
    {
        public void PROYECT3()
        {
            int Cantidades = 0;
            double Precio = 0, Multiplicación = 0, Suma = 0, IVA = 0, TOTAL = 0;
            string Data = "", Data2 = "";
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("           ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                ███████████████████FACTURA██████████████████████");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.Write("                        ingrese la cantidad de productos.");
                Data = Console.ReadLine();
                Cantidades = Convert.ToInt32(Data);
                if (Cantidades != 0)
                {
                    Console.Write("                         Ingrese el valor del producto.");
                    Data2 = Console.ReadLine();
                    Precio = Convert.ToDouble(Data2);
                    Multiplicación = Cantidades * Precio;

                    Suma = Suma + Multiplicación;
                }
                else
                {
                    Console.WriteLine("                        Finalizó, espere el total a pagar.");
                }
            } while (Cantidades != 0);

            Console.WriteLine("                                 Total a pagar: {0}", Suma);
            Console.WriteLine("                    XXXXXXXXXX¡Gracias por su compra!XXXXXXXX");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                ████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("           ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("/////////////////////////////////////////");
            Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
            Console.WriteLine("/////////////////////////////////////////");
            Console.ReadKey();
        }
    }
}
