using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTotal
{
        class Program
        {
            static void Main(string[] args)
            {
                PROGRAMA1 P1 = new PROGRAMA1();
                PROGRAMA2 P2 = new PROGRAMA2();
                PROGRAMA3 P3 = new PROGRAMA3();
                PROGRAMA4 P4 = new PROGRAMA4();
                PROGRAMA5 P5 = new PROGRAMA5();
                PROGRAMA6 P6 = new PROGRAMA6();
                PROGRAMA7 P7 = new PROGRAMA7();
                PROGRAMA8 P8 = new PROGRAMA8();
                PROGRAMA9 P9 = new PROGRAMA9();
                PROGRAMA10 P10 = new PROGRAMA10();
                int NT = 0;
                string DatAT = "";
                do
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                    ╔═══════════════════════════════════════╗ ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("                    ║");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     ██   ██ █▀▀▀▀█ ██   █ █     █ ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    ║");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("                    ║");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     █ █ █ █ █      █ █  █ █     █ ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    ║");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("                    ║");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     █  █  █ █■■■█  █  █ █ █     █ ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    ║");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("                    ║");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     █     █ █      █   ██ █     █ ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    ║");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("                    ║");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("     █     █ █▄▄▄▄█ █    █  █████  ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    ║");
                    Console.WriteLine("                    ╚═══════════════════════════════════════╝ ");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                   SELECIONE LA OPCION QUE DECIDA VISUALIZAR.");
                    Console.WriteLine();
                    Console.Write("       1. PROGRAMA1.\t\t");
                    Console.Write("2. PROGRAMA2.\t\t"); ;
                    Console.Write("3. PROGRAMA3.\t\t");
                    Console.WriteLine("");
                    Console.Write("\n       4. PROGRAMA4.\t\t");
                    Console.Write("5. PROGRAMA5.\t\t");
                    Console.Write("6. PROGRAMA6.\t\t");
                    Console.WriteLine("");
                    Console.Write("\n       7. PROGRAMA7.\t\t");
                    Console.Write("8. PROGRAMA8.\t\t");
                    Console.Write("9. PROGRAMA9.\t\t");
                    Console.WriteLine("");
                    Console.Write("\n       10. PROGRAMA10.\t\t");
                    Console.WriteLine("11.Salir.\t\t");
                    Console.WriteLine();
                    DatAT = Console.ReadLine();
                    NT = Convert.ToInt32(DatAT);
                    Console.WriteLine();
                    if (NT > 0 && NT <= 11)
                    {
                        if (NT == 1)
                        {
                            P1.PROYECT1();
                        }
                        else
                        {
                        }
                        if (NT == 2)
                        {
                            P2.PROYECT2();
                        }
                        else
                        {
                        }
                        if (NT == 3)
                        {
                            P3.PROYECT3();
                        }
                        else
                        {
                        }
                        if (NT == 4)
                        {
                            P4.PROYECT4();
                        }
                        else
                        {
                        }
                        if (NT == 5)
                        {
                            P5.PROYECT5();
                        }
                        else
                        {
                        }
                        if (NT == 6)
                        {
                            P6.PROYECT6();
                        }
                        else
                        {
                        }
                        if (NT == 7)
                        {
                            P7.PROYECT7();
                        }
                        else
                        {
                        }
                        if (NT == 8)
                        {
                            P8.PROYECT8();
                        }
                        else
                        {
                        }
                        if (NT == 9)
                        {
                            P9.PROYECT9();
                        }
                        else
                        {
                        }
                        if (NT == 10)
                        {
                            P10.PROYECT10();
                        }
                        else
                        {
                        }
                        if (NT == 11)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("                           XXXXXXXXXXXXXXXXXXXXXXXXXXX");
                            Console.WriteLine("                           XX  PROGRAMA FINALIZADO. XX");
                            Console.WriteLine("                           XXXXXXXXXXXXXXXXXXXXXXXXXXX");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("");
                            Console.WriteLine("                                1101010100101010");
                            Console.WriteLine("                                1100110001101011");
                            Console.WriteLine("                                1010  1010  1010");
                            Console.WriteLine("                                0101  0101  0101");
                            Console.WriteLine("                                101010    101010");
                            Console.WriteLine("                                0101        0101");
                            Console.WriteLine("                                1010        1010");
                            Console.WriteLine("                                0101  0101  0101");
                            Console.WriteLine("                                1010101010101010");
                            Console.WriteLine("\n");
                            Console.WriteLine("________________________");
                            Console.WriteLine("");
                            Console.WriteLine("Creador. Brando Mero¨3B¨");
                            Console.WriteLine("      ¡VzBrandonZ!");
                            Console.WriteLine("________________________");
                            Console.ReadKey();
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                     █▀▀▀▀▀█ █▀▀▀▀█ █▀▀▀▀█  █████   █▀▀▀▀█ ");
                        Console.WriteLine("                     █       █    █ █    █ █     █  █    █ ");
                        Console.WriteLine("                     █■■■■█  █████  █████  █     █  █████  ");
                        Console.WriteLine("                     █       █   █  █    █ █     █  █    █ ");
                        Console.WriteLine("                     █▄▄▄▄▄█ █    █ █     █ █████   █     █");
                        Console.WriteLine("");
                        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                        Console.WriteLine("XX ¡El PROGRAMA REGISTRO UN DATO ERRONEO! XX");
                        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||");
                        Console.WriteLine("||    PRESIONE (INTRO)-->>PARA REGRESAR    ||");
                        Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||");
                        Console.ReadKey();

                    }
                } while (NT != 11);
                Console.ReadKey();
            }
        }
        class PROGRAMA1
        {
            public void PROYECT1()
            {
                int Cantidad = 0, Aternos = 0, Z = 0;
                int[] X = new int[Cantidad];
                string Data = "", Data2 = "";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("                ╔══════════════════════════════════════════════════╗ ");
                Console.WriteLine("                ║ ¿Cuantos numeros desea registrar en el programa? ║ ");
                Console.WriteLine("                ╚══════════════════════════════════════════════════╝ ");
                Console.WriteLine();
                Data = Console.ReadLine();
                Cantidad = Convert.ToInt32(Data);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                for (int ca = 1; ca <= Cantidad; ca++)
                {
                    Console.WriteLine("Ingrese el numero {0}", ca);
                    Data2 = Console.ReadLine();
                    Aternos = Convert.ToInt32(Data2);
                    if (Aternos > Z)
                    {
                        Z = Aternos;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("El numero mayor es el: {0}", Z);
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("/////////////////////////////////////////");
                Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
                Console.WriteLine("/////////////////////////////////////////");
                Console.ReadKey();
            }
        }
        class PROGRAMA2
        {
            public void PROYECT2()
            {
                int Num1 = 0;
                string Data1 = "";
                Console.Clear();
                Console.WriteLine("                ╔═══════════════════════════════════════════╗");
                Console.WriteLine("                ║ registre el tamaño del cuadro a presentar ║");
                Console.WriteLine("                ╚═══════════════════════════════════════════╝");
                Data1 = Console.ReadLine();
                Num1 = Convert.ToInt32(Data1);
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (Num1 >= 0 && Num1 <= 50)
                {
                    for (int C = 0; C < Num1; C++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("   ");
                    for (int C = 0; C < Num1 - 2; C++)
                    {
                        Console.Write("* ");
                        for (int Z = 0; Z < Num1 - 2; Z++)
                        {
                            Console.Write("  ");
                        }
                        Console.WriteLine("*");
                    }
                    for (int X = 0; X < Num1; X++)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("/////////////////////////////////////////");
                Console.WriteLine("//   PRESIONE (INTRO)-->>PARA  SALIR.  //");
                Console.WriteLine("/////////////////////////////////////////");
                Console.ReadKey();
            }
        }
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
        class PROGRAMA5
        {
            public void PROYECT5()
            {
                int Cantidad = 0;
                string Data1 = "";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("           ╔═════════════════════════════════════════════════════════╗ ");
                Console.WriteLine("           ║ Ingrese el tamaño de la piramide que se va a presentar. ║ ");
                Console.WriteLine("           ╚═════════════════════════════════════════════════════════╝ ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Data1 = Console.ReadLine();
                Cantidad = Convert.ToInt32(Data1);
                int Num2 = 0;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                for (int C = 0; C <= Cantidad; C++)
                {               //0<=4
                    for (int B = 0; B <= Cantidad - C; B++)
                    {               //0<= 4-2
                        Console.Write(" ");
                    }
                    for (int Z = 1; Z <= 2 * C - 1; Z++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("/////////////////////////////////////////");
                Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
                Console.WriteLine("/////////////////////////////////////////");
                Console.ReadKey();
            }
        }
        class PROGRAMA6
        {
            public void PROYECT6()
            {
                int Numero, Contador = 1;
                string Data1 = "";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("           ╔═════════════════════════════════════════════════════════╗ ");
                Console.WriteLine("           ║    Ingrese el tamaño del rombo que se va a presentar.   ║ ");
                Console.WriteLine("           ╚═════════════════════════════════════════════════════════╝ ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Data1 = Console.ReadLine();
                Numero = Convert.ToInt32(Data1);
                Contador = Numero - 1;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                for (int k = 1; k <= Numero; k++)
                {
                    for (int i = 1; i <= Contador; i++)
                        Console.Write(" ");
                    Contador--;
                    for (int i = 1; i <= 2 * k - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                Contador = 1;
                for (int k = 1; k <= Numero - 1; k++)
                {
                    for (int i = 1; i <= Contador; i++)
                        Console.Write(" ");
                    Contador++;
                    for (int i = 1; i <= 2 * (Numero - k) - 1; i++)
                        Console.Write("*");
                    Console.WriteLine("");
                }
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("/////////////////////////////////////////");
                Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
                Console.WriteLine("/////////////////////////////////////////");
                Console.ReadLine();
            }
        }
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
                if (NumberE > 0)
                {
                    Console.WriteLine("   Columna1\t\tColumna2\t\tColumna3");
                    Console.WriteLine("    1 en 1 \t         2 en 2 \t         3 en 3");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Console.WriteLine("  █                                                    █");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    for (int C = 1; C <= NumberE; C++)
                    {
                        Console.WriteLine("  █{0,5}\t        {1,5}\t\t        {2,5}  █", C, Z, X);
                        Z = Z + 2;
                        X = X + 3;

                    }
                    Console.WriteLine("  █                                                    █");
                    Console.WriteLine("  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                }
                else
                {
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
        class PROGRAMA9
        {
            public void PROYECT9()
            {
                Console.Clear();
                int T1 = 0, T2 = 0, S = 0, F = 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                ╔═══════════════════════════════════════════╗");
                Console.WriteLine("                ║   Las tabla de multiplicar del 1 al 15    ║");
                Console.WriteLine("                ╚═══════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (int C = 1; C <= 12; C++)
                {
                    for (int Z = 1; Z <= 6; Z++)
                    {
                        if (Z >= 1 && Z <= 5)
                        {
                            Console.Write("{0}X{1}={2}\t\t", Z, C, Z * C);
                        }
                        else
                        {
                            Console.WriteLine();
                        }

                    }
                }
                Console.WriteLine();
                for (int C = 1; C <= 12; C++)
                {
                    Console.WriteLine("");
                    for (int Z = 6; Z <= 10; Z++)
                    {
                        Console.Write("{0,2}X{1,1}={2,3}\t", Z, C, Z * C);
                    }

                }
                Console.WriteLine();
                for (int C = 1; C <= 12; C++)
                {
                    Console.WriteLine("");
                    for (int Z = 11; Z <= 15; Z++)
                    {
                        Console.Write(" {0}X{1}={2}\t", Z, C, Z * C);
                    }

                }
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("/////////////////////////////////////////");
                Console.WriteLine("//   PRESIONE (ENTER)-->>PARA  SALIR.  //");
                Console.WriteLine("/////////////////////////////////////////");
                Console.ReadKey();
            }
        }
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

