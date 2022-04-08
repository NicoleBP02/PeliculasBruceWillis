using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliculasBruceWillis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializaVisualizacionDatos();
        }

        private void InicializaVisualizacionDatos()
        {
            InicializaDataGridViewDetallePeliculas();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void InicializaDataGridViewDetallePeliculas()
        {
            dataGridViewDetallePeliculas.DataSource = null;
            dataGridViewDetallePeliculas.DataSource = AccesoDatos.ObtenerDetallePelicula();
        }

        private bool ValidaCamposMinimos()
        {
            bool resultado = false;

            if (txtTitulo.Text != "" ||
                txtDirector.Text != "" ||
                txtNombrePersonaje.Text != "" ||
                dtpFecha.Text != "")
                resultado = true;

            return resultado;
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void botonAgregarPelicula_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no sean nulos
            if (ValidaCamposMinimos())
            {
                try
                {
                    Pelicula unaPelicula = new Pelicula(
                        txtTitulo.Text,                                         //Titulo
                        txtNombrePersonaje.Text,                                //Personaje
                        txtDirector.Text,                                       //Director
                        dtpFecha.Value.ToString("dd/MM/yyyy")                   //Fecha

                    );
                    if(txtTitulo.Text != "" && txtNombrePersonaje.Text != "" && txtDirector.Text != "")
                    {
                        AccesoDatos.GuardarPelicula(unaPelicula);

                        //Despues de agregado a la lista, se actualiza las visualizaciones de datos
                        InicializaVisualizacionDatos();

                        MessageBox.Show("Pelicula registrada exitosamente.",
                            "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Los valores no deben estar nulos\n");
                    }
                    
                }
                catch (NullReferenceException errorNulo)
                {
                    MessageBox.Show("Los valores no deben estar nulos\n" +
                        errorNulo.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            //Reiniciamos los controles para registrar un nuevo valor
            dtpFecha.Value = DateTime.Now;
            txtTitulo.Text = "";
            txtNombrePersonaje.Text = "";
            txtDirector.Text = "";
        }

        //botonBuscarPelicula_Click
        private void button1_Click(object sender, EventArgs e) {
            if (txtIdPeliculasEditar.Text != "")
            {
                try
                {
                    int idPelicula = int.Parse(txtIdPeliculasEditar.Text);
                    Pelicula peliculaBuscada = AccesoDatos.ObtenerPeliculaxID(idPelicula);
                    if (peliculaBuscada.Id != 0)
                    {
                        bool respuesta = AccesoDatos.EncontrarID(idPelicula);
                        if (respuesta)
                        {
                            grupoEditarPelicula.Visible = true;


                            txtTituloEditar.Text = peliculaBuscada.titulo.ToString();
                            txtNombrePersonajeEditar.Text = peliculaBuscada.nombrePersonaje.ToString();
                            dtpFechaEditar.Value = ObtieneFechaHora(peliculaBuscada.fechaEstreno, "fecha");
                            txtDirectorEditar.Text = peliculaBuscada.directorPelicula.ToString();


                            // Bloqueamos el campo de Id Sismo para evitar ediciones no controladas
                            txtIdPeliculasEditar.Enabled = false;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una pelicula asociado al id suministrado.",
                            "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtIdPeliculasEditar.Text = "";
                    }

                }
                catch (FormatException error)
                {
                    MessageBox.Show("El Id de la pelicula debe ser un valor numérico entero \n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtIdPeliculasEditar.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el ID de la pelicula a editar",
                    "Id de Sismo no suministrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBorrarPelicula_Click(object sender, EventArgs e)
        {
            if (txtIdPeliculaBorrar.Text != "")
            {
                try
                {
                    int idPelicula = int.Parse(txtIdPeliculaBorrar.Text);
                    bool respuesta = AccesoDatos.EliminarPelicula(idPelicula);

                    if (respuesta)
                    {
                        //Despues de agregado a la lista, se actualiza las visualizaciones de datos
                        InicializaVisualizacionDatos();

                        //Y se borra el valor ingresado
                        txtIdPeliculaBorrar.Text = "";

                        MessageBox.Show("Pelicula eliminada exitosamente.",
                            "Pelicula eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una pelicula asociada al id suministrado.",
                            "Pelicula no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException error)
                {
                    MessageBox.Show("El Id de la pelicula debe ser un valor numérico entero \n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor ingrese el ID de la pelicula a eliminar",
                    "Id de pelicula no suministrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnActualizarPelicula_Click(object sender, EventArgs e)
        {
            int idRegion = 0;

            //Validamos que los campos de Latidud, Longitud, Magnitud, Profundidad y Región no sean nulos
            if (ValidaCamposMinimos())
            {
                try
                {
                    Pelicula unaPelicula = new Pelicula(
                    txtTituloEditar.Text,                                         //Titulo
                    txtNombrePersonajeEditar.Text,                                //Personaje
                    txtDirectorEditar.Text,                                       //Director
                    dtpFechaEditar.Value.ToString("dd/MM/yyyy")                   //Fecha

                    );

                    unaPelicula.Id = int.Parse(txtIdPeliculasEditar.Text);

    
                    AccesoDatos.ActualizarPelicula(unaPelicula);

                    //Despues de agregado a la lista, se actualiza las visualizaciones de datos
                    InicializaVisualizacionDatos();

                    MessageBox.Show("Pelicula actualizada exitosamente.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException error)
                {
                    MessageBox.Show("Los campos de  deben ser numéricos \n" +
                        error.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException errorNulo)
                {
                    MessageBox.Show("El valor de ... no debe ser nulo\n" +
                        errorNulo.Message,
                        "Error en datos - Región", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos de ... no pueden ser nulos",
                    "Error en datos - nulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Ocultamos el grupo de controles de edición
            grupoEditarPelicula.Visible = false;

            txtIdPeliculasEditar.Text = "";
            txtIdPeliculasEditar.Enabled = true;
        }

        private DateTime ObtieneFechaHora(string dato, string tipo)
        {
            DateTime resultado = new DateTime();
            string[] elementos;

            if (tipo == "fecha")
            {
                elementos = dato.Split('/');
                resultado = new DateTime(int.Parse(elementos[2]),
                                            int.Parse(elementos[1]),
                                            int.Parse(elementos[0]));
            }

            return resultado;
        }
    }
}
