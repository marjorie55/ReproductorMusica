using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorMusica.ListaDoble
{
    class Nodo
    {
        public string dato;
        public Nodo adelante;
        public Nodo atras;
        internal Clases.Nodo enlace;

        public string getDatos()
        {
            return dato;
        }
        //constructor
        public Nodo(string entrada)
        {
            dato = entrada;
            adelante = atras = null;
        }
    }
}
