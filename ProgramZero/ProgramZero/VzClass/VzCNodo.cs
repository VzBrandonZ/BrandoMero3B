using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZero.VzClass
{
    class VzCNodo
    {
        private int data;
        private VzCNodo siguiente = null;
        public int _DatA_
        {
            get => data; 
            set => data = value; 
        }
        internal VzCNodo Siguiente
        {
            get => siguiente;
            set => siguiente = value;
        }
        public override string ToString()
        {
            return string.Format("[{0}]",data);
        }

    }
}
