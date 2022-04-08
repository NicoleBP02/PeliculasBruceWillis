
namespace PeliculasBruceWillis
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
            this.dataGridViewDetallePeliculas = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNombrePersonaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonAgregarPelicula = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grupoEditarPelicula = new System.Windows.Forms.GroupBox();
            this.btnActualizarPelicula = new System.Windows.Forms.Button();
            this.txtDirectorEditar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaEditar = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombrePersonajeEditar = new System.Windows.Forms.TextBox();
            this.txtTituloEditar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.botonBuscarPelicula = new System.Windows.Forms.Button();
            this.txtIdPeliculasEditar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBorrarPelicula = new System.Windows.Forms.Button();
            this.txtIdPeliculaBorrar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePeliculas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grupoEditarPelicula.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDetallePeliculas
            // 
            this.dataGridViewDetallePeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetallePeliculas.Location = new System.Drawing.Point(362, 99);
            this.dataGridViewDetallePeliculas.Name = "dataGridViewDetallePeliculas";
            this.dataGridViewDetallePeliculas.Size = new System.Drawing.Size(408, 189);
            this.dataGridViewDetallePeliculas.TabIndex = 0;
            this.dataGridViewDetallePeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(27, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(293, 324);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNombrePersonaje);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.botonAgregarPelicula);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpFecha);
            this.tabPage1.Controls.Add(this.txtDirector);
            this.tabPage1.Controls.Add(this.txtTitulo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(285, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Pelicula";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNombrePersonaje
            // 
            this.txtNombrePersonaje.Location = new System.Drawing.Point(15, 114);
            this.txtNombrePersonaje.Name = "txtNombrePersonaje";
            this.txtNombrePersonaje.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePersonaje.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre del Personaje";
            // 
            // botonAgregarPelicula
            // 
            this.botonAgregarPelicula.Location = new System.Drawing.Point(179, 251);
            this.botonAgregarPelicula.Name = "botonAgregarPelicula";
            this.botonAgregarPelicula.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarPelicula.TabIndex = 8;
            this.botonAgregarPelicula.Text = "Agregar";
            this.botonAgregarPelicula.UseVisualStyleBackColor = true;
            this.botonAgregarPelicula.Click += new System.EventHandler(this.botonAgregarPelicula_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de estreno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(15, 174);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(108, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(15, 223);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(100, 20);
            this.txtDirector.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(15, 62);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grupoEditarPelicula);
            this.tabPage2.Controls.Add(this.botonBuscarPelicula);
            this.tabPage2.Controls.Add(this.txtIdPeliculasEditar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(285, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Pelicula";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grupoEditarPelicula
            // 
            this.grupoEditarPelicula.Controls.Add(this.btnActualizarPelicula);
            this.grupoEditarPelicula.Controls.Add(this.txtDirectorEditar);
            this.grupoEditarPelicula.Controls.Add(this.label9);
            this.grupoEditarPelicula.Controls.Add(this.dtpFechaEditar);
            this.grupoEditarPelicula.Controls.Add(this.label8);
            this.grupoEditarPelicula.Controls.Add(this.label7);
            this.grupoEditarPelicula.Controls.Add(this.txtNombrePersonajeEditar);
            this.grupoEditarPelicula.Controls.Add(this.txtTituloEditar);
            this.grupoEditarPelicula.Controls.Add(this.label6);
            this.grupoEditarPelicula.Location = new System.Drawing.Point(23, 63);
            this.grupoEditarPelicula.Name = "grupoEditarPelicula";
            this.grupoEditarPelicula.Size = new System.Drawing.Size(233, 229);
            this.grupoEditarPelicula.TabIndex = 3;
            this.grupoEditarPelicula.TabStop = false;
            this.grupoEditarPelicula.Text = "Editar Pelicula";
            this.grupoEditarPelicula.Visible = false;
            // 
            // btnActualizarPelicula
            // 
            this.btnActualizarPelicula.Location = new System.Drawing.Point(151, 188);
            this.btnActualizarPelicula.Name = "btnActualizarPelicula";
            this.btnActualizarPelicula.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarPelicula.TabIndex = 9;
            this.btnActualizarPelicula.Text = "Actualizar";
            this.btnActualizarPelicula.UseVisualStyleBackColor = true;
            this.btnActualizarPelicula.Click += new System.EventHandler(this.btnActualizarPelicula_Click);
            // 
            // txtDirectorEditar
            // 
            this.txtDirectorEditar.Location = new System.Drawing.Point(29, 154);
            this.txtDirectorEditar.Name = "txtDirectorEditar";
            this.txtDirectorEditar.Size = new System.Drawing.Size(100, 20);
            this.txtDirectorEditar.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Director";
            // 
            // dtpFechaEditar
            // 
            this.dtpFechaEditar.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaEditar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEditar.Location = new System.Drawing.Point(26, 110);
            this.dtpFechaEditar.Name = "dtpFechaEditar";
            this.dtpFechaEditar.Size = new System.Drawing.Size(115, 20);
            this.dtpFechaEditar.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Fecha de estreno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nombre del Personaje";
            // 
            // txtNombrePersonajeEditar
            // 
            this.txtNombrePersonajeEditar.Location = new System.Drawing.Point(26, 71);
            this.txtNombrePersonajeEditar.Name = "txtNombrePersonajeEditar";
            this.txtNombrePersonajeEditar.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePersonajeEditar.TabIndex = 3;
            // 
            // txtTituloEditar
            // 
            this.txtTituloEditar.Location = new System.Drawing.Point(26, 32);
            this.txtTituloEditar.Name = "txtTituloEditar";
            this.txtTituloEditar.Size = new System.Drawing.Size(100, 20);
            this.txtTituloEditar.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Titulo";
            // 
            // botonBuscarPelicula
            // 
            this.botonBuscarPelicula.Location = new System.Drawing.Point(181, 19);
            this.botonBuscarPelicula.Name = "botonBuscarPelicula";
            this.botonBuscarPelicula.Size = new System.Drawing.Size(75, 23);
            this.botonBuscarPelicula.TabIndex = 2;
            this.botonBuscarPelicula.Text = "Buscar";
            this.botonBuscarPelicula.UseVisualStyleBackColor = true;
            this.botonBuscarPelicula.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdPeliculasEditar
            // 
            this.txtIdPeliculasEditar.Location = new System.Drawing.Point(91, 22);
            this.txtIdPeliculasEditar.Name = "txtIdPeliculasEditar";
            this.txtIdPeliculasEditar.Size = new System.Drawing.Size(73, 20);
            this.txtIdPeliculasEditar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Pelicula";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBorrarPelicula);
            this.tabPage3.Controls.Add(this.txtIdPeliculaBorrar);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(285, 298);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Borrar Pelicula";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBorrarPelicula
            // 
            this.btnBorrarPelicula.Location = new System.Drawing.Point(179, 90);
            this.btnBorrarPelicula.Name = "btnBorrarPelicula";
            this.btnBorrarPelicula.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarPelicula.TabIndex = 2;
            this.btnBorrarPelicula.Text = "Borrar";
            this.btnBorrarPelicula.UseVisualStyleBackColor = true;
            this.btnBorrarPelicula.Click += new System.EventHandler(this.btnBorrarPelicula_Click);
            // 
            // txtIdPeliculaBorrar
            // 
            this.txtIdPeliculaBorrar.Location = new System.Drawing.Point(122, 42);
            this.txtIdPeliculaBorrar.Name = "txtIdPeliculaBorrar";
            this.txtIdPeliculaBorrar.Size = new System.Drawing.Size(100, 20);
            this.txtIdPeliculaBorrar.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Id Pelicula";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(412, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(293, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Peliculas de Bruce Willis";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(498, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "1980 - 2022";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PeliculasBruceWillis.Properties.Resources.bruce_willis_die_hard;
            this.pictureBox1.Location = new System.Drawing.Point(384, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewDetallePeliculas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePeliculas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grupoEditarPelicula.ResumeLayout(false);
            this.grupoEditarPelicula.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDetallePeliculas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonAgregarPelicula;
        private System.Windows.Forms.Button botonBuscarPelicula;
        private System.Windows.Forms.TextBox txtIdPeliculasEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePersonaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grupoEditarPelicula;
        private System.Windows.Forms.DateTimePicker dtpFechaEditar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombrePersonajeEditar;
        private System.Windows.Forms.TextBox txtTituloEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDirectorEditar;
        private System.Windows.Forms.Button btnActualizarPelicula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdPeliculaBorrar;
        private System.Windows.Forms.Button btnBorrarPelicula;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

