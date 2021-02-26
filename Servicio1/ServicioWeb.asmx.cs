using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data; //acceso a bufer de memopria para base de datos
using System.Data.SqlClient; // acceso a sql
using System.Configuration; // acceso a cadena de conexion

namespace Servicio1
{
    /// <summary>
    /// Descripción breve de ServicioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb : System.Web.Services.WebService
    {
        //acceso a cadena de conexion
        private static string Cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        [WebMethod(Description = "Mostrar Tabla TTiempo")]
        public DataSet ListarTTiempo()
        {
            //using hace uso de memoria hasta q ya no sea nacesario y se elimina
            using (SqlConnection Conexion = new SqlConnection(Cadena))
            {
                string Consulta = "select * from TTiempo";
                SqlCommand Comando = new SqlCommand(Consulta, Conexion);
                SqlDataAdapter Adaptador = new SqlDataAdapter(Comando);
                DataSet Data = new DataSet();
                Adaptador.Fill(Data);
                return Data;
            }
        }

        [WebMethod(Description = "Mostrar por Departamento")]
        public DataSet ListarDepartamento(String Nombre)
        {
            //using hace uso de memoria hasta q ya no sea nacesario y se elimina
            using (SqlConnection Conexion = new SqlConnection(Cadena))
            {
                string Consulta = "uspListarDepartamento @Nombre";
                SqlCommand Comando = new SqlCommand(Consulta, Conexion);
                SqlDataAdapter Adaptador = new SqlDataAdapter(Comando);
                Comando.Parameters.AddWithValue("@Nombre", Nombre);
                DataSet Data = new DataSet();
                Adaptador.Fill(Data);
                return Data;
            }
        }
    }
}
