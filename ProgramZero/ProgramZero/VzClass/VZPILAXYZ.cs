using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZero.VzClass
{
    class VZPILAXYZ
    {
        public void VzPilaXYZ()
        {
            VzPila vzPila = new VzPila();
            bool ban = true;
            do
            {
                int valor = Menu();
                switch (valor)
                {
                    case 1:
                        Console.WriteLine("Ingrese un numero");
                        vzPila.PushInsertar(Int32.Parse(Console.ReadLine())); Console.ReadKey(); break;
                    case 2:
                        Console.WriteLine("Se elimino el dato [{0}]",vzPila.PopEliminar()); Console.ReadKey(); break;
                    case 3:
                        Console.WriteLine( "Cima=[{0}]",vzPila.PeekMostrarCima()); Console.ReadKey(); break;
                    case 4:  vzPila.Transversa(); Console.ReadKey(); break;
                    case 5: ban = false;
                        Console.WriteLine("Finalizo Pila."); Console.ReadKey(); break;
                    default:
                        Console.WriteLine("Escoja la opción correcta");
                        Console.ReadKey();
                        break;
                }
            } while (ban);
        }
        int Menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();

            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine("█                           MENU                                 █");
            Console.WriteLine("██████████████████████████████████████████████████████████████████");
            Console.WriteLine("█ 1) Apilar                                                      █");
            Console.WriteLine("█ 2) Desapilar                                                   █");
            Console.WriteLine("█ 3) Mirar cima                                                  █");
            Console.WriteLine("█ 4) Mostrar Pila                                                █");
            Console.WriteLine("█ 5) Salir                                                       █");
            Console.WriteLine("██████████████████████████████████████████████████████████████████");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
