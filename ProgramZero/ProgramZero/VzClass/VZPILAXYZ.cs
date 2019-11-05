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
                float valor = Menu();
                switch (valor)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        vzPila.PushInsertar();  break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Se elimino el dato [{0}]",vzPila.PopEliminar()); Console.ReadKey(); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine( "Cima=[{0}]",vzPila.PeekMostrarCima()); break;
                    case 4:vzPila.Transversa(); break;
                    case 5: ban = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Finalizo Pila."); Console.ReadKey(); break;
                    default:
                        Console.WriteLine("Escoja la opción correcta");
                        break;
                }
                Console.ReadKey();
            } while (ban);
        }
        float Menu()
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
            float opcion = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.ReadKey();
            return opcion;
        }
    }
}
