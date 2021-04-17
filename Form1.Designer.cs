
namespace ReproductorMusica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPausa = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listCanciones = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSiguienteIz = new System.Windows.Forms.PictureBox();
            this.btnSiguienteDrch = new System.Windows.Forms.PictureBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAleatorio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguienteIz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguienteDrch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAleatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(12, 46);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(369, 66);
            this.Reproductor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Paper Flowers", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reproductor de Música";
            // 
            // btnPausa
            // 
            this.btnPausa.Image = ((System.Drawing.Image)(resources.GetObject("btnPausa.Image")));
            this.btnPausa.Location = new System.Drawing.Point(140, 122);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(38, 37);
            this.btnPausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPausa.TabIndex = 2;
            this.btnPausa.TabStop = false;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(184, 123);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(34, 36);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 3;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(225, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // listCanciones
            // 
            this.listCanciones.FormattingEnabled = true;
            this.listCanciones.Location = new System.Drawing.Point(12, 190);
            this.listCanciones.Name = "listCanciones";
            this.listCanciones.Size = new System.Drawing.Size(204, 251);
            this.listCanciones.TabIndex = 5;
            this.listCanciones.SelectedValueChanged += new System.EventHandler(this.listCanciones_SelectedValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(230, 278);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 31);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSiguienteIz
            // 
            this.btnSiguienteIz.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteIz.Image")));
            this.btnSiguienteIz.Location = new System.Drawing.Point(77, 117);
            this.btnSiguienteIz.Name = "btnSiguienteIz";
            this.btnSiguienteIz.Size = new System.Drawing.Size(56, 50);
            this.btnSiguienteIz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSiguienteIz.TabIndex = 7;
            this.btnSiguienteIz.TabStop = false;
            this.btnSiguienteIz.Click += new System.EventHandler(this.btnSiguienteIz_Click);
            // 
            // btnSiguienteDrch
            // 
            this.btnSiguienteDrch.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteDrch.Image")));
            this.btnSiguienteDrch.Location = new System.Drawing.Point(264, 117);
            this.btnSiguienteDrch.Name = "btnSiguienteDrch";
            this.btnSiguienteDrch.Size = new System.Drawing.Size(56, 50);
            this.btnSiguienteDrch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSiguienteDrch.TabIndex = 8;
            this.btnSiguienteDrch.TabStop = false;
            this.btnSiguienteDrch.Click += new System.EventHandler(this.btnSiguienteDrch_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQuitar.Location = new System.Drawing.Point(230, 315);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(151, 34);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnAleatorio.Image")));
            this.btnAleatorio.Location = new System.Drawing.Point(326, 125);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(38, 34);
            this.btnAleatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAleatorio.TabIndex = 14;
            this.btnAleatorio.TabStop = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(393, 458);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnSiguienteDrch);
            this.Controls.Add(this.btnSiguienteIz);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listCanciones);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reproductor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguienteIz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguienteDrch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAleatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnPausa;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listCanciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox btnSiguienteIz;
        private System.Windows.Forms.PictureBox btnSiguienteDrch;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAleatorio;
    }
}

