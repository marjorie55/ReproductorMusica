using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorMusica.ListaDoble
{
    
    class ClsListaDoble
    {
        public Nodo cabeza;//es el nodo que se llama primero
        private int size;
        public ClsListaDoble()
        {
            cabeza = null;

        }

        public ClsListaDoble insertarCabezaLista(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = cabeza;
            if (cabeza != null)
            {
                cabeza.atras = nuevo;
            }
            cabeza = nuevo;
            return null;
        }

        public ClsListaDoble insertaDespues(Nodo anterior, string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = anterior.adelante;
            if (anterior.adelante != null)
            {
                anterior.adelante.atras = null;
            }
            anterior.adelante = nuevo;
            nuevo.atras = anterior;
            return this;
        }

        public void eliminar(string entrada)
        {
            //cuando los nodos no se repiten
            Nodo actual;
            bool encontrado = false;
            actual = cabeza;

            //bucle de busquedad, para buscar el
            //valor que necesitamos eliminar
            while ((actual != null) && (!encontrado))
            {
                encontrado = actual.dato == entrada;//evalua si el dato del recorrido es el que estaos buscando
                if (!encontrado)
                {
                    actual = actual.adelante;//cabeza hacia la cola

                }
            }
            //enlace de nodo anterior con el siguiente
            if (actual != null)
            {
                //distinguir entre nodo cabeza del resto de la lista
                if (actual == cabeza)
                {
                    cabeza = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;

                    }
                }
                else if (actual.adelante != null)
                {//no es el ultimo nodo
                    actual.atras.adelante = actual.adelante;
                    actual.adelante.atras = actual.atras;
                }
                else//ultimo nodo
                {
                    actual.atras.adelante = null;
                }
                actual = null;
            }

        }//end metodo

        public void transV()
        {
            Nodo p = cabeza;
            string LD;


            while (p != null)
            {
                LD = p.dato;
                p = p.adelante;
                this.size = this.size + 1;//aaqui obtenemos el tamaño de la Lista
            }
        }

        public String[] vizualizarL()
        {
            transV();
            string[] datos = new string[this.size];
            Nodo p;
            p = cabeza;
            int contador = 0;

            while (p != null)
            {
                string LC;
                LC = p.dato;
                datos[contador] = LC;
                p = p.adelante;
                contador++;
            }
            return datos;
        }

    }
}

