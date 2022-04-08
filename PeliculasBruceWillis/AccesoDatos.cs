using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;



namespace PeliculasBruceWillis
{
    public class AccesoDatos
    {
        private static string ObtenerCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<string> ObtenerPelicula()
        {
            string cadenaConexion = ObtenerCadenaConexion("PeliculasBruceWillis");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var salida = cxnDB.Query<string>("select distinct titulo from peliculas order by titulo", new DynamicParameters());
                return salida.ToList();
            }
        }

        public static Pelicula ObtenerPeliculaxID(int idPelicula)
        {
            Pelicula peliculaResultado = new Pelicula();

            string cadenaConexion = ObtenerCadenaConexion("PeliculasBruceWillis");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select Id, titulo, nombrePersonaje, fechaEstreno, directorPelicula from peliculas where Id = @id";

                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@id", idPelicula, DbType.Int32, ParameterDirection.Input);

                var salida = cxnDB.Query<Pelicula>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                    peliculaResultado = salida.First();

                return peliculaResultado;
            }
        }
        public static DataTable ObtenerDetallePelicula()
        {
            DataTable tablaResultado = new DataTable();

            string cadenaConexion = ObtenerCadenaConexion("PeliculasBruceWillis");

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                SQLiteDataAdapter daPeliculas = new SQLiteDataAdapter("select Id, titulo, nombrePersonaje, fechaEstreno, directorPelicula from peliculas", cxnDB);
                daPeliculas.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        //public static int ObtieneIdPelicula(string nombreRegion)
        //{
        //    int resultado = 0;
        //    string cadenaConexion = ObtenerCadenaConexion("PeliculasBruceWillis");

        //    using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
        //    {
        //        string sentenciaSQL = "select Id from peliculas where titulo = @nombre";

        //        //El Id se asigna como parametro de la sentencia, 
        //        DynamicParameters parametrosSentencia = new DynamicParameters();
        //        parametrosSentencia.Add("@nombre", nombreRegion, DbType.String, ParameterDirection.Input);

        //        var salida = cxnDB.Query<int>(sentenciaSQL, parametrosSentencia);

        //        //validamos cuantos registros devuelve la lista
        //        if (salida.ToArray().Length != 0)
        //            resultado = salida.First();
        //    }
        //    return resultado;
        //}

        public static void GuardarPelicula(Pelicula unaPelicula)
        {
            string cadenaConexion = ObtenerCadenaConexion("PeliculasBruceWillis");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {

                cxnDB.Execute("insert into peliculas (titulo,nombrePersonaje,fechaEstreno,directorPelicula) " +
                    "values (@titulo, @nombrePersonaje, @fechaEstreno, @directorPelicula)", unaPelicula);

               /* SQLiteCommand command = new SQLiteCommand("insert into peliculas (titulo, nombrePersonaje, fechaEstreno, director) values (@titulo, @nombrePersonaje, @fechaEstreno, @director)", cxnDB);

                command.Parameters.AddWithValue("@id", br.engWord + br.spaWord + br.frequency + br.wordClass);
                command.Parameters.AddWithValue("@engWord", br.engWord);
                command.Parameters.AddWithValue("@spaWord", br.spaWord);
                command.Parameters.AddWithValue("@frequency", br.frequency);
                command.Parameters.AddWithValue("@wordClass", br.wordClass);

                command.ExecuteNonQuery();*/
            }
        }

        /// <summary>
        /// Elimina una pelicula
        /// </summary>
        /// <param name="idPelicula">ID de la pelicula a eliminar</param>
        public static bool EliminarPelicula(int idPelicula)
        {
            bool resultado = false;
            int totalRegistros = 0;

            string cadenaConexion = ObtenerCadenaConexion("PeliculasBruceWillis");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "delete from peliculas where id = @id";

                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@id", idPelicula, DbType.Int32, ParameterDirection.Input);

                totalRegistros = cxnDB.Execute(sentenciaSQL, parametrosSentencia);

                // Si la cantidad de registros es diferente de 0, se encontró y eliminó registro
                if (totalRegistros != 0)
                    resultado = true;
            }
            return resultado;
        }

        public static bool EncontrarID(int idPelicula)
        {
            bool resultado = false;
            int totalRegistros = 0;

            string cadenaConexion = ObtenerCadenaConexion("PeliculasBruceWillis");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select id from peliculas where id = @id";

                //El Id se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@id", idPelicula, DbType.Int32, ParameterDirection.Input);

                totalRegistros = cxnDB.Execute(sentenciaSQL, parametrosSentencia);

                // Si la cantidad de registros es diferente de 0, se encontró y eliminó registro
                if (totalRegistros != 0)
                    resultado = true;
            }
            return resultado;
        }
        public static void ActualizarPelicula(Pelicula unaPelicula)
        {
            string cadenaConexion = ObtenerCadenaConexion("PeliculasBruceWillis");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                cxnDB.Execute("update peliculas set " +
                    "titulo = @titulo," +
                    "nombrepersonaje = @nombrePersonaje," +
                    "fechaestreno = @fechaEstreno," +
                    "directorpelicula = @directorPelicula " +
                    "where Id = @Id", unaPelicula);
            }
        }
    }
}
