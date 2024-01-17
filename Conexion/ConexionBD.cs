using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WCRUD_IL29.Conexion
{
    //Super Clase para establecer una conexión con el origen de datos (SQL Server)
    internal class ConexionBD
    {
        //Recuperar ConnectionString del archivo App.config
        static readonly string strconexion = ConfigurationManager.ConnectionStrings["WFCRUD2_MD"].ConnectionString;
        //Definición de Conexion protegida
        protected SqlConnection Conexion = new SqlConnection(strconexion);
    }
}
