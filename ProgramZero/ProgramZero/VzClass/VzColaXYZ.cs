using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZero.VzClass
{
    class VzColaXYZ
    {
        public void VZColaXYZ()
        {
            VzCola Cola = new VzCola();
            
            bool Ban = true;
            do
            {
                int valor = Menu();
                switch (valor)
                {
                    case 1: Cola.insertarNodo(); Console.ReadKey(); break;
                    case 2: Cola.DesplegarCola(); Console.ReadKey(); break;
                    case 3: Ban = false;
                        Console.WriteLine("Finalizo Cola");
                        Console.ReadKey(); break;

                    default:
                        Console.WriteLine("Esta opción no existe.");
                        break;
                }
            } while (Ban);
            Console.ReadKey();
        }
        int Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine("█                           MENU                                 █");
            Console.WriteLine("██████████████████████████████████████████████████████████████████");
            Console.WriteLine("█ 1) Ingresar                                                    █");
            Console.WriteLine("█ 2) Recorrer                                                    █");
            Console.WriteLine("█ 3) Salir                                                       █");
            Console.WriteLine("██████████████████████████████████████████████████████████████████");
            int opcion = Int32.Parse(Console.ReadLine());
            Console.Clear();
            return opcion;
            Console.ReadKey();

        }
        
           
       
    }
}
