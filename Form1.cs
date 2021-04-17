using System;
using ReproductorMusica.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReproductorMusica.ListaDoble;
using ReproductorMusica.listacircularejemplo;

namespace ReproductorMusica
{
    public partial class Form1 : Form
    {
        OpenFileDialog BoxbuscarArchivo = new OpenFileDialog();
        ListaOrdenada addpath1 = new ListaOrdenada();
        ClsListaDoble addpath = new ClsListaDoble();
        ListaCircular addpath3 = new ListaCircular();

        bool Play = false;
        NodoC nuevo;
        //string[] rutaArMP3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            BoxbuscarArchivo.Multiselect = true;// selecciona varios archivps al mismo tiempo

            if (BoxbuscarArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               // rutaArMP3 = BoxbuscarArchivo.SafeFileNames;
                
               for (int i = 0; i < BoxbuscarArchivo.FileNames.Length; i++)
               {
                    addpath.insertarCabezaLista(BoxbuscarArchivo.FileNames[i]);//lista doble
                    addpath3.insertar(BoxbuscarArchivo.FileNames[i]);//agregar con lista circular
                    listCanciones.Items.Add(BoxbuscarArchivo.SafeFileNames[i]);
               }

                /*archivosMP3 = BoxbuscarArchivo.SafeFileNames;
                rutaArMP3 = BoxbuscarArchivo.FileNames;*/
                
                /*foreach (var archivoMP3 in archivosMP3)//para leer cada uno de los archivos mp3 que adjuntamos
                {
                    listCanciones.Items.Add(archivoMP3);
                }*/

                Reproductor.URL = BoxbuscarArchivo.FileNames[0];
                listCanciones.SelectedIndex = 0;
                int pausa;
                pausa = 0;
            }
        }

        private void listCanciones_SelectedValueChanged(object sender, EventArgs e)
        {
           if (listCanciones.SelectedIndex != -1)
           {
                Reproductor.URL = BoxbuscarArchivo.FileNames[listCanciones.SelectedIndex];
                int LC = listCanciones.SelectedIndex;
                nuevo = new NodoC(BoxbuscarArchivo.FileNames[LC]);//para que me tome a cancion selecionada y vuelva a la primera
                //es para cuando el usuario selecciona la cancion de la lista
           }
                
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.play();
           
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.pause();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
        }

        private void btnSiguienteDrch_Click(object sender, EventArgs e)
        {//siguiente cancion
            
            if (listCanciones.SelectedIndex < listCanciones.Items.Count - 1)
            {
                listCanciones.SelectedIndex = listCanciones.SelectedIndex + 1;
            }
            else
            {
                ParaRepetir();
            }
        }

        private void btnQuitar_Click_1(object sender, EventArgs e)
        {
            string delete = BoxbuscarArchivo.FileName;
            int delete2 = listCanciones.SelectedIndex;//toma la posicion que se va a elimnar 


            if (listCanciones.SelectedIndex != -1)
            {
                addpath.eliminar(delete);//lista doble
                addpath3.eliminar(delete);//lista circular
                listCanciones.Items.RemoveAt(delete2);//elimina lo que esta en la posicion
                Reproductor.Ctlcontrols.stop();
            }
            int pausa;
            pausa = 0;

        }

        private void btnSiguienteIz_Click(object sender, EventArgs e)
        {
            //regresar a la cancion anterior
            if (listCanciones.SelectedIndex > 0)
            {
                listCanciones.SelectedIndex = listCanciones.SelectedIndex - 1;
            }else
            {
                MessageBox.Show("Llegaste al final de las canciones");
            }
            
        }
        //metodo nuevo
        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int aletorio2 = aleatorio.Next(listCanciones.Items.Count - 1);
            Reproductor.URL = BoxbuscarArchivo.FileNames[aletorio2];
            listCanciones.SelectedIndex = aletorio2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ParaRepetir();
        }
        
        //metodo nuevo
        public void ParaRepetir()
        {

            if (nuevo != null)
            {
                nuevo = addpath3.lc.enlace; // para ir al siguiente nodo 

                while (nuevo == addpath3.lc.enlace)
                {
                    if (listCanciones.SelectedIndex < listCanciones.Items.Count - 1)
                    {
                        listCanciones.SelectedIndex += 1;
                        nuevo = nuevo.enlace;
                    }
                    else
                    {

                        Reproductor.URL = BoxbuscarArchivo.FileNames[0];
                        listCanciones.SelectedIndex = 0;
                        nuevo = nuevo.enlace;
                    }

                    nuevo = nuevo.enlace;
                }
            }
            else
            {
                MessageBox.Show("\t La lista circular se encuentra vacía!!");
            }
        }


    }
}
