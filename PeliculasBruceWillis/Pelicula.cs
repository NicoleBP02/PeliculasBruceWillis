using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasBruceWillis
{
    public class Pelicula
    {
        public int Id { get; set; }

        //Las propiedades de titulo, nombrePersonaje, directorPelicula y Fecha son utilizadas
        //al momento de insertar/actualizar información de un sismo
        public string titulo { get; set; }
        public string nombrePersonaje { get; set; }
        public string directorPelicula { get; set; }
        public string Fecha { get; set; }

        /// <summary>
        /// Constructor de la clase usando parámetros
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="nombrepersonaje"></param>
        /// <param name="directorpelicula"></param>
        /// <param name="fecha"></param>

        public Pelicula(string titulo, string nombrepersonaje, string directorpelicula, string fecha)
        {
            Id = 0;
            this.titulo = titulo;
            nombrePersonaje = nombrepersonaje;
            directorPelicula = directorpelicula;
            Fecha = fecha;
        }
        /// <summary>
        /// Constructor predeterminado de la clase
        /// </summary>
        public Pelicula()
        {
            Id = default(int);
            this.titulo = "";
            nombrePersonaje = "";
            directorPelicula = "";
            Fecha = "";
        }
        /// <summary>
        /// Obtiene la cadena de caracteres que describe el sismo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(
                $"Id: {Id} " + Environment.NewLine +
                $"titulo: {titulo} " + Environment.NewLine +
                $"Nombre Personaje: {nombrePersonaje} " + Environment.NewLine +
                $"Fecha: {Fecha} " + Environment.NewLine +
                $"directorPelicula: {directorPelicula} "
                );
        }
    }
}
