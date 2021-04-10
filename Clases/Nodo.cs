using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorMusica.Clases
{
    public class Nodo
    {
        public string dato;
        public Nodo enlace;
        //constructor
        public Nodo(string x)
        {
            dato = x;
            enlace = null;//primer nodo creado, no tiene sucesor   
        }
        public Nodo(string x, Nodo n)
        {
            dato = x;
            enlace = n;
        }
        //devuelve valor
        public string getDato()
        {
            return dato;
        }
        public Nodo getEnlace()
        {
            return enlace;
        }
        //asignarle valor
        public void setEnlace(Nodo enlace)
        {
            this.enlace = enlace;
        }
    }
}
