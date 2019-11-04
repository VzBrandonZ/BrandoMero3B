using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZero.VzClass
{
    class VzPila
    {
        private VzCNodo Cabeza;
        private VzCNodo Buscador;
        public VzPila()
        {
            Cabeza = new VzCNodo();
            Cabeza.Siguiente = null;
        }


        public void PushInsertar()
        {
            VzCNodo NuedoNodo = new VzCNodo();
            Console.WriteLine("Ingrese un dato a la pila");
            NuedoNodo._DatA_ = int.Parse(Console.ReadLine());
            Console.WriteLine("Dato registrado");
            NuedoNodo.Siguiente = Cabeza.Siguiente;
            Cabeza.Siguiente = NuedoNodo;
        }
        public int PopEliminar()
        {
            int valor = 0;
            if (Cabeza.Siguiente!=null)
            {
                Buscador = Cabeza.Siguiente;
                valor = Buscador._DatA_;
                Cabeza.Siguiente = Buscador.Siguiente;
                Buscador.Siguiente = Cabeza;
            }
            return valor;
        }
        public int PeekMostrarCima()
        {
            int valor = 0;
            if (Cabeza.Siguiente!=null)
            {
                Buscador = Cabeza.Siguiente;
                valor = Buscador._DatA_;
            }
            
            return valor;
        }
            public void Transversa()
        {
            Buscador = Cabeza;
            while (Buscador.Siguiente!=null)
            {

                Buscador = Buscador.Siguiente;
                int DaTA = Buscador._DatA_;
                Console.WriteLine("[{0}]", DaTA);
            }
        }
        
    }
    
}
