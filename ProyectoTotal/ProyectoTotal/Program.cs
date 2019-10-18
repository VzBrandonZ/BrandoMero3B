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
                int NT=0;
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
            switch (NT)
            {
                    case 1: P1.PROYECT1(); break;
                    case 2: P2.PROYECT2(); break;
                    case 3: P3.PROYECT3(); break;
                    case 4: P4.PROYECT4(); break;
                    case 5: P5.PROYECT5(); break;
                    case 6: P6.PROYECT6(); break;
                    case 7: P7.PROYECT7(); break;
                    case 8: P8.PROYECT8(); break;
                    case 9: P9.PROYECT9(); break;
                    case 10:P10.PROYECT10(); break;
            }
                if (NT>11)
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
                } while (NT != 11);
                Console.ReadKey();
            }
        }  
    }