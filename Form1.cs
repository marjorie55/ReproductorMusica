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

namespace ReproductorMusica
{
    public partial class Form1 : Form
    {
        OpenFileDialog BoxbuscarArchivo = new OpenFileDialog();
        ListaOrdenada addpath = new ListaOrdenada();

        bool Play = false;
       // string[] rutaArMP3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            BoxbuscarArchivo.Multiselect = true;// selecciona varios archivps al mismo tiempo

            if (BoxbuscarArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               for (int i = 0; i < BoxbuscarArchivo.FileNames.Length; i++)
               {
                    addpath.insertaOrden(BoxbuscarArchivo.FileNames[i]);
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
        }

        private void btnQuitar_Click_1(object sender, EventArgs e)
        {
            int delete = listCanciones.SelectedIndex;

            if (listCanciones.SelectedIndex != -1)
            {
                addpath.eliminar(delete);
                listCanciones.Items.RemoveAt(delete);
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
            }


        }

    }
}
