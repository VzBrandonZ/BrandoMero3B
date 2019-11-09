using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_Level_Company_Program.Class;
namespace Third_Level_Company_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool X = true;
            Client client = new Client("Brandon rafael Mero cepeda", "1728821081", "Leonidas Proaño", new List<Gasolina>());

            try
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese sus nombres");
                client.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su numero de Cedúla de identidad.");
                client.Cedula = Console.ReadLine();
                Console.WriteLine("Ingrese su dirección.");
                client.Direccion = Console.ReadLine();
                do
                {
                    Gasolina gasolina = new Gasolina("super",0,client);
                    Menumarca();
                    Console.WriteLine("-------------------------Datos del Cliente-------------------------\n" +
                                      "Nombre:" + client.Nombre +
                                      "\nCedúla de indentidad:" + client.Cedula +
                                      "\nDirección:" + client.Direccion+
                                      "\n-------------------------------------------------------------------");
                    Console.WriteLine();
                    gasolina.Client = client;
                    client.Gasolina.Add(gasolina);
                    int c = 100065020;
                    foreach (Gasolina item in client.Gasolina)
                    {
                        c += 1;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("╔════════════════════════════════════════════════╗");
                        Console.WriteLine("║                    FACTURA                     ║");
                        Console.WriteLine("╠════════════════════════════════════════════════╣");
                        Console.WriteLine("║           █     █ █  █ █ ▀▀█▀▀ █▀▀▀            ║");
                        Console.WriteLine("║            █ █ █  ████ █   █   █■■             ║");
                        Console.WriteLine("║             █ █   █  █ █   █   █▄▄▄            ║");
                        Console.WriteLine("╠════════════════════════════════════════════════╣");
                        Console.WriteLine("║ N.º de Factura:{0}                       ║", c);
                        Console.WriteLine("╠════════════════════════════════════════════════╣");
                        Console.WriteLine("  Cliente:  {0}                                  ", client.Nombre);
                        Console.WriteLine("  C.I:      {0}                                  ", client.Cedula);
                        Console.WriteLine("  Dirección:{0}                                  ", client.Direccion);
                        Console.WriteLine("                                                 ");
                        Console.WriteLine("  Tipo de gasolina:   {0}                        ", item.Tipo);
                        Console.WriteLine("  Cantidad de galones:{0}                        ", item.Cantidad);
                        Console.WriteLine("  Precio:             {0}                        ", item.Precio);
                        Console.WriteLine("                                                 ");
                        Console.WriteLine("                                                 ");
                        Console.WriteLine("                                SUBTOTAL:${0}    ", item.Subtotal);
                        Console.WriteLine("                                IVA:     ${0}    ", item.Iva);
                        Console.WriteLine("                                TOTAL:   ${0}    ", item.Total);
                        Console.WriteLine("╠════════════════════════════════════════════════╣");
                        Console.WriteLine("\n");
                    }
                    
                    X=Opcion();
                    Console.Clear();
                
                

            Console.ReadKey();

            void Menumarca()
            {
                bool Ban=true;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("¿Qué marca de gasolina desea comprar?\n" +
                                          "[Super]            [Extra]");
                            String marca = Console.ReadLine();
                            if (marca=="Super"|| marca =="super"|| marca =="SUPER")
                            {
                                gasolina.Tipo = "Super"; Ban = false;
                            }
                            else
                            {
                                if (marca == "Extra" || marca == "extra" || marca == "EXTRA")
                                {
                                    gasolina.Tipo = "Extra"; Ban = false;
                                }
                                else
                                {
                                    Console.WriteLine("Esta opcion no existe.");
                                    Console.ReadLine();
                                }
                            }               
                } while (Ban);
                Console.WriteLine("Ingrese la cantidad de galones que va a comprar.");
                gasolina.Cantidad = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.ReadLine();
            }
                } while (X);
                Console.WriteLine("¡Gracias por su compra!");
                Console.ReadLine();
            }
            catch (Exception Z)
            {

                Console.WriteLine(Z.Message); ;
            }

            bool Opcion()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                bool ban, Ban2=false;
                do
                {
                    Console.WriteLine("¿Desea hacer otra compra?");
                    Console.WriteLine("  [Si]          [No]");
                    String opcion = Console.ReadLine();
                    if (opcion == "SI" || opcion == "Si" || opcion == "si")
                    {
                        Ban2 = true; ban = false;
                    }
                    else
                    {
                        if (opcion == "NO" || opcion == "No" || opcion == "no")
                        {
                            Ban2 = false; ban = false;
                        }
                        else
                        {
                            Console.WriteLine("esta opcion no existe."); ban = true;
                        }
                    }
                } while (ban);
                return Ban2;
            }
        }
     }
}
