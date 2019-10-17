using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA4
    {
        public void PROYECT4()
        {

            int Horas = 0, SalarioN = 0, SalarioM = 0, extra = 0;
            string Data1 = "", Data2 = "", Data3 = "SI", Data4 = "Si", Data5 = "si", Data6 = "yes", Data7 = "Yes", Data8 = "YES", Nombre = "";
            string Data10 = "no", Data12 = "NO", Data13 = "No", Data14 = "nO", Data15 = "NOT", Data16 = "Not", Data17 = "DO NOT", Data18 = "Do not";
            Console.Clear();
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("                    ╔══════════════════════════════════════╗");
                Console.WriteLine("                    ║      ¡Calculadora de salarios!       ║");
                Console.WriteLine("                    ╚══════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese su nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el total de horas que trabajó en la semana:");
                Data1 = Console.ReadLine();
                Horas = Convert.ToInt32(Data1);
                if (Horas <= 35)
                {
                    SalarioN = Horas * 15;
                    Console.WriteLine("NOMBRE: {0}", Nombre);
                    Console.WriteLine("HORAS TRABAJADAS {0} Hrs", Horas);
                    Console.WriteLine("SU PAGO TOTAL ES: {0:N0}$", SalarioN);
                    Console.WriteLine("_______________");
                    Console.WriteLine();
                    Console.WriteLine(" EMPRESA WHITE");
                    Console.WriteLine("_______________");
                }
                else
                {
                    extra = (Horas - 35) * 22;
                    SalarioM = ((Horas - 35) * 22 + (35 * 15));
                    Console.WriteLine();
                    Console.WriteLine("NOMBRE: {0}", Nombre);
                    Console.WriteLine("HORAS EXTRAS: {0} Hrs", (Horas - 35));
                    Console.WriteLine("HORAS TRABAJADAS {0} Hrs", Horas);
                    Console.WriteLine("PAGO EXTRA: {0:N0}$", extra);
                    Console.WriteLine("SU PAGO TOTAL ES: {0:N0}$", SalarioM);
                    Console.WriteLine("_______________");
                    Console.WriteLine();
                    Console.WriteLine(" EMPRESA WHITE");
                    Console.WriteLine("_______________");
                }
                Console.WriteLine("¿Desea ingresar otro salario?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[SI]    ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[NO]");
                Console.ForegroundColor = ConsoleColor.White;
                Data2 = Console.ReadLine();
            } while (Data2 == Data3 || Data2 == Data4 || Data2 == Data5 || Data2 == Data6 || Data2 == Data7 || Data2 == Data8);
            if (Data2 == Data10 || Data2 == Data12 || Data2 == Data13 || Data2 == Data14 || Data2 == Data15 || Data2 == Data16 || Data2 == Data17 || Data2 == Data18)
            {
                Console.WriteLine("Finalizó el programa...");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("/////////////////////////////////////////");
                Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
                Console.WriteLine("/////////////////////////////////////////");
            }
            Console.ReadKey();
        }
    }
}
