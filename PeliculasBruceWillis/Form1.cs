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
            ActualizaComboBoxPeliculas();
            InicializaVisualizacionDatos();
        }

        private void ActualizaComboBoxPeliculas()
        {
            /*
            comboAgregarPelicula.DataSource = null;
            comboAgregarPelicula.DataSource = AccesoDatos.ObtenerPelicula();
            comboAgregarPelicula.DisplayMember = "region";
            */
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

                    AccesoDatos.GuardarPelicula(unaPelicula);

                    //Despues de agregado a la lista, se actualiza las visualizaciones de datos
                    InicializaVisualizacionDatos();

                    MessageBox.Show("Pelicula registrada exitosamente.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (NullReferenceException errorNulo)
                {
                    MessageBox.Show("Los valores no deben estar nulos\n" +
                        errorNulo.Message,
                        "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            /*else
            {         
                MessageBox.Show("Los campos de titulo, nombre del personaje, fecha o nombre del director no pueden ser nulos",
                "Error en datos - nulos", MessageBoxButtons.OK, MessageBoxIcon.Error);      
            }*/

            //Reiniciamos los controles para registrar un nuevo valor
            dtpFecha.Value = DateTime.Now;
            txtTitulo.Text = "";
            txtNombrePersonaje.Text = "";
            txtDirector.Text = "";
        }

        //botonBuscarPelicula_Click
        private void button1_Click(object sender, EventArgs e) {}

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
    }
}
