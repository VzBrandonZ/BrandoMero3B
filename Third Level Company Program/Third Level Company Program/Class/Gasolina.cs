using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Level_Company_Program.Class
{
    public class Gasolina
    {
        private String tipo;

        public String Tipo
        {
            get
            {
                return tipo;
            }
            set
            {

                    tipo = value;
                                    
            }
        }
        private float cantidad;

        public float Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
        private float precio;
        public  float Precio
        {
            get
            {
                if (tipo == "Super")
                {
                    return 2.00f;
                }
                if (tipo =="Extra")
                {
                    return 1.50f;
                }
                return precio;
            }

        }

        public Gasolina(string tipo, float cantidad, Client client)
        {
            Tipo = tipo;
            Cantidad = cantidad;
            Client = client;
        }

        private Client client;
        public Client Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
            }
        }
        private float subtotal;

        public float Subtotal
        {
            get { return subtotal=cantidad*Precio; }
        }

        private float iva;

        public float Iva
        {
            get { return iva=subtotal*0.12f; }
        }
        private float total;

        public float Total
        {
            get { return total=subtotal+Iva; }
        }




    }
}
