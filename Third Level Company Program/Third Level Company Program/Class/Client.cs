using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Level_Company_Program.Class
{
    public class Client
    {
        private String nombre;

        public Client(string nombre, string cedula, string direccion, List<Gasolina> gasolina)
        {
            Nombre = nombre;
            Cedula = cedula;
            Direccion = direccion;
            Gasolina = gasolina;
        }

        public String Nombre
        {
            get { return nombre.ToUpper(); }
            set
            {
                if (value.Split(' ').Length == 4||value.Split(' ').Length==5)
                {
                    nombre = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Error:Debe ser nombre completo.");
                }

                
            }
           
        }
        private String cedula;

        public String Cedula
        {
            get {

                return cedula;
                }
            set {
                if (value.Length==10||value.Length==8)
                {
                    cedula = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new  Exception ("Erro:cedula invalida.");
                }
                }
        }
        private String direccion;

        public String Direccion
        {
            get { return direccion.ToUpper(); }
            set { direccion = value; }
        }
        private List<Gasolina> gasolina;

        public List<Gasolina> Gasolina
        {
            get { return gasolina; }
            set { gasolina = value; }
        }


    }
}
