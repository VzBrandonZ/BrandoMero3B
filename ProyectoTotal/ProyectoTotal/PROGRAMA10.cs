using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
    class PROGRAMA10
    {
        public void PROYECT10()
        {

            int Operador = 0;
            string Data1 = "";
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                     █████████████████████████████████████");
                Console.WriteLine("                     ██                                 ██");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("                     ██");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t\t     MENÚ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("               ██");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("                     ██");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("1)\t     Salir");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("              ██");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("                     ██");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("2)\t   Sumatoria");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("            ██");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("                     ██");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("3)\t Factorización");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("          ██");
                Console.WriteLine("                     ██                                 ██");
                Console.WriteLine("                     █████████████████████████████████████");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("¡SELECIONE UNA OPCIÓN!");
                Console.WriteLine();
                Data1 = Console.ReadLine();
                Operador = Convert.ToInt32(Data1);
                Console.Clear();
                if (Operador == 1 || Operador == 2 || Operador == 3)
                {

                    if (Operador == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n");
                        Console.WriteLine("//////////////////////////////");
                        Console.WriteLine("//   Finalizó el programa.  //");
                        Console.WriteLine("//////////////////////////////");
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("/////////////////////////////////////////");
                        Console.WriteLine("//   PRESIONE (INTRO)-->>PARA  SALIR.  //");
                        Console.WriteLine("/////////////////////////////////////////");
                        Console.ReadKey();
                    }
                    else
                    {
                        if (Operador == 2)
                        {
                            int Number1 = 0, S = 0, X = 1;
                            string Data2 = "";
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine();
                            Console.WriteLine("Ingrese un digito para la operación.");
                            Data2 = Console.ReadLine();
                            Number1 = Convert.ToInt32(Data2);
                            Console.WriteLine();
                            for (int Z = 0; Z <= Number1 - 1; Z++)
                            {
                                Console.Write("{0,8}\t", X);
                                S = S + X;
                                X = X + 1;

                            }
                            Console.WriteLine();
                            Console.WriteLine("La Sumatoria es:{0,10:N0}", S);
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("/////////////////////////////////////////");
                            Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
                            Console.WriteLine("/////////////////////////////////////////");
                            Console.ReadKey();
                        }
                        else
                        {

                        }
                        if (Operador == 3)
                        {
                            int Number2 = 0, I = 2;
                            double Number3 = 1;
                            string Data3 = "";
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Ingrese un digito para la operación.");
                            Data3 = Console.ReadLine();
                            Number2 = Convert.ToInt32(Data3);
                            while (I <= Number2)
                            {
                                Number3 *= I;
                                I++;

                            }
                            Console.WriteLine("La Factorizacion da:\n{0:N0}", Number3);
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("/////////////////////////////////////////");
                            Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
                            Console.WriteLine("/////////////////////////////////////////");
                            Console.ReadKey();
                        }
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡NO EXISTE ESA OPCION!");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("////////////////////////////////////////////");
                    Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  REGRESAR.  //");
                    Console.WriteLine("////////////////////////////////////////////");
                    Console.ReadKey();
                }

            } while (Operador != 1);
            Console.ReadKey();
        }
    }
}
