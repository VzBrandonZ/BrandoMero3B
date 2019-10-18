using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA8
    {
        public void PROYECT8()
        {
            int NumberE = 0, Z = 2, X = 3;
            string Data1 = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Registre un numero entero:");
            Data1 = Console.ReadLine();
            NumberE = Convert.ToInt32(Data1);
            Console.WriteLine("   Columna1\t\tColumna2\t\tColumna3");
            Console.WriteLine("    1 en 1 \t         2 en 2 \t         3 en 3");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine("  █                                                    █");
            if (NumberE > 0)
            {
                for (int i = 1; i <= NumberE; i++)
                {
                    Console.Write("      " + i);
                    if (i <= NumberE / 2)
                    {
                        Console.Write("\t\t\t    " + (i + i));

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    if (i <= NumberE / 3)
                    {
                        Console.WriteLine("\t\t\t   " + (i + i + i));

                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine("  █                                                    █");
                Console.WriteLine("  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usted registro un digito erróneo.");
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

