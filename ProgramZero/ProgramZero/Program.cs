using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramZero.VzClass;
namespace ProgramZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            VZPILAXYZ vZPILAXYZ = new VZPILAXYZ();
            bool ban = true;
            do
            {
                int valor;
                valor = Menu();



                switch (valor)
                {
                    case 1: vZPILAXYZ.VzPilaXYZ(); break;
                    case 2: break;
                    case 3: ban = false; break;
                    default:
                        Console.WriteLine("Escoja la opción correcta");
                        Console.ReadKey();
                        break;
                }
            } while (ban);

            int Menu()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                int opcion;

                Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                Console.WriteLine("█                             MENU                               █");
                Console.WriteLine("██████████████████████████████████████████████████████████████████");
                Console.WriteLine("█ 1) TADPila                                                     █");
                Console.WriteLine("█ 2) TAD Cola                                                    █");
                Console.WriteLine("█ 3) Salir                                                       █");
                Console.WriteLine("██████████████████████████████████████████████████████████████████");
                opcion = int.Parse(Console.ReadLine());
                return opcion;

                Console.ReadKey();
            }

        }
    }
}

