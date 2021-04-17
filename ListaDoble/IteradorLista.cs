using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorMusica.ListaDoble
{
    class IteradorLista
    {
        public Nodo actual;

        //constructor
        public IteradorLista(ClsListaDoble Id)
        {
            actual = Id.cabeza;
        }
        public Nodo siguiente()
        {
            Nodo a;
            a = actual;
            if (actual != null)
            {
                actual = actual.adelante;
            }
            return a;
        }
    }
}
