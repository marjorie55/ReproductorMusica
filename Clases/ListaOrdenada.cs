using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReproductorMusica.Clases
{
    public class ListaOrdenada : Lista
    {
        // public Nodo primero;
        public ListaOrdenada() : base()
        {//constructor

        }

        public ListaOrdenada insertaOrden(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            if (primero == null)
            {
                primero = nuevo;
            }
            else if (entrada.CompareTo(primero.getDato()) < 0)
            {
                nuevo.setEnlace(primero);
            }
            else
            {
                //busquedad del nodo anterior
                //a partir de aquí se hará la insercion
                Nodo anterior, p;
                anterior = p = primero;
                while ((p.getEnlace() != null) && (entrada.CompareTo(p.getDato())) > 0)
                {
                    anterior = p;
                    p = p.getEnlace();
                }
                if (entrada.CompareTo(p.getDato()) > 0)//insertar despues del ultimo nod
                {
                    anterior = p;
                }
                nuevo.setEnlace(anterior.getEnlace());
                anterior.setEnlace(nuevo);
            }
            return this;
        }

        public Nodo buscar(int index)// aquí nos retorna el nodo que estamos buscando
        {

            if (index < 0)
            {
                return null;
            }

            int p = 0;
            Nodo aux = primero;
            while (p != index)
            {
                aux = aux.enlace;
                p++;
            }

            return aux;
        }

        public void eliminar(int entrada)
        {
            Nodo actual, anterior;
            bool encontrado;
            //aquí inicializamos los apuntadores
            Nodo dato = buscar(entrada);
            actual = primero;
            anterior = null;
            encontrado = false;

            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.enlace == dato.enlace);


                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }
            }

            //enlace del nodo anteior con el siguiente
            if (actual != null)
            {
                //ve si es el nodo cabeza inicial
                //es cualquiera otro nodo de la lista
                if (actual == primero)
                {
                    primero = actual.enlace;
                }
                else
                {
                    anterior.enlace = actual.enlace;
                }
            }
        }//end metodo

        //metodos pendientes de la lista ordenada
        //eliminar
        //buscar lista
    }
}














