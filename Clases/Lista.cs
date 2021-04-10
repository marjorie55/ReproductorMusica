using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorMusica.Clases
{
    public class Lista
    {
        public Nodo primero;
        public Nodo ultimo;

        //constructor
        public Lista()
        {
            primero = null;
        }


        //funcion que lee los numeros ingresados

        //    private int leerEntero()
        //    {
        //        Console.WriteLine("Ingrese valor, -1 para finalizar");
        //        return;
        //        //return Integer.parseInt(new Scanner(System.in).nextLine());
        //    }

        //    public Lista crearLista()
        //    {
        //        int x;
        //        primero = null;

        //        do
        //        {
        //            x = leerEntero();
        //            if (x != -1)
        //            {
        //                primero = new Nodo(x, primero);
        //            }
        //        } while (x != -1);
        //        return this;
        //    }

        //nuevo metodo
        public Nodo buscarPosicion(int posicion)
        {
            Nodo indice;
            int i;
            if (posicion < 0)
            {
                return null;
            }
            indice = primero;
            for (i = 1; (i < posicion) && (indice != null); i++)
            {//incrementa pero tambien hace la iteracion
                indice = indice.enlace;

            }
            return indice;
        }

        //insertar de ultimo, insercion por cola
        public Lista insertarUltimo(Nodo ultimo, string entrada)
        {
            ultimo.enlace = new Nodo(entrada);//
            ultimo = ultimo.enlace;
            return this;
        }

        public Nodo buscarLista(string destino)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.enlace)
            {
                if (destino == indice.dato)
                {//destino.equals(nombre.dato) para buscar String(nombres)
                    return indice;
                }
            }
            return null;
        }
        public Lista insertarCabeza(Nodo cabeza, string valor)
        {
            cabeza.enlace = new Nodo(valor);
            cabeza = cabeza.enlace;
            return this;
        }


        public void eliminar(string entrada)
        {
            Nodo actual, anterior;//pasa saber quien estaba atras de el
            bool encontrado;
            //inicializa los apuntadores
            actual = primero;
            anterior = null;//null porque no sabes quien es el last
            encontrado = false;//inicializando
                               //busquedad del nodo anterior
            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.dato == entrada);

                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }
            }//while

            //enlace del nodo anterior con el siguiente
            if (actual != null)
            {
                //distinguir si es el nodo inicial o si es 
                //cualquier otro nodo de la lista
                if (actual == primero)
                {
                    primero = actual.enlace;
                }
                else
                {
                    anterior.enlace = actual.enlace;
                }
                actual = null;
            }
        }

        public Lista insertarLista(string testigo, string entrada)
        {
            Nodo nuevo, anterior;
            anterior = buscarLista(testigo);//

            if (anterior != null)
            {
                nuevo = new Nodo(entrada);
                nuevo.enlace = anterior.enlace;
                anterior.enlace = nuevo;
            }
            return this;
        }

        public void visualizar()
        {//hace una iteracion e imprime los valores
            Nodo n;
            int k = 0;
            n = primero;
            while (n != null)
            {
                Console.WriteLine(n.dato + " ");
                n = n.enlace;
                k++;
                Console.WriteLine((k % 15 != 0 ? "" : "\n"));//ternario, sepa que es xd

            }
        }
    }
}
