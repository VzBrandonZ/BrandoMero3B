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
            Console.ForegroundColor = ConsoleColor.Green;
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
                Console.Clear();
                int opcion;

                Console.WriteLine("                           MENU");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine(" 1) Ejercicio Pila");
                Console.WriteLine(" 2) Ejercicio Cola");
                Console.WriteLine(" 3) Salir");
                opcion = int.Parse(Console.ReadLine());
                return opcion;

                Console.ReadKey();
            }

        }
    }
}

