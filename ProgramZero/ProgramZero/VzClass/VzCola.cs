using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZero.VzClass
{
    class VzCola
    {
        private VzCNodo Primero = new VzCNodo();
        private VzCNodo Ultimo = new VzCNodo();
        public VzCola() {
            Primero = null;
            Ultimo = null;
        }
        public void insertarNodo()
        {
            VzCNodo NuevoNodo = new VzCNodo();
            Console.WriteLine("Ingrese dato");
            NuevoNodo._DatA_ = int.Parse(Console.ReadLine());
            if(Primero==null)
            {
                Primero = NuevoNodo;
                Primero.Siguiente = NuevoNodo;
                Ultimo = NuevoNodo;
            }
            else
            {
                Ultimo.Siguiente = NuevoNodo;
                NuevoNodo.Siguiente = null;
                Ultimo = NuevoNodo;
            }
            Console.WriteLine("\nNodo ingresado\n");
        }
        public void DesplegarCola()
        {
            VzCNodo Actual = new VzCNodo();
            Actual = Primero;
            if (Primero!=null)
            {
                while (Actual!=null)
                {
                    Console.WriteLine("[" + Actual._DatA_ + "]");
                    Actual = Actual.Siguiente;
                }  
            }
            else
            {
                Console.WriteLine("La cola esta vacia");
            }
        }
    }
}
