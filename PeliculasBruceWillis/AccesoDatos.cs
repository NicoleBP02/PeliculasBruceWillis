using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;



namespace PeliculasBruceWillis
{
    class AccesoDatos
    {
        private static string ObtenerCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<string> ObtenerTitulo()
        {
            string cadenaConexion = ObtenerCadenaConexion("PeliculasBruceWillis");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var salida = cxnDB.Query<string>("select distinct Titulo from Peliculas order by Titulo", new DynamicParameters());
                return salida.ToList();
            }
        }
        public static DataTable ObtenerDetallePeliculas()
        {
            DataTable tablaResultado = new DataTable();

            string cadenaConexion = ObtenerCadenaConexion("BDPeliculasBW");

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                SQLiteDataAdapter daPeliculas = new SQLiteDataAdapter("select distinct id, region, fecha, hora, latitud, longitud, magnitud, profundidad from v_detalle_sismos", cxnDB);
                daPeliculas.Fill(tablaResultado);
                return tablaResultado;
            }
        }
    }
}
