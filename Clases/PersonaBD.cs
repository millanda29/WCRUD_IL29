using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCRUD_IL29.Conexion;
using static WCRUD_IL29.Clases.CredencialesBD;

namespace WCRUD_IL29.Clases
{
    internal class PersonaBD : ConexionBD
    {
        public class Persona
        {
            public int PersonaID { get; set; } 
            public string Cedula { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }
            public DateTime FechaNacimiento { get; set; }
        }

        public bool ValidarConexion()
        {
            try
            {
                Conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                Conexion.Close();
            }
        }

        // Método para obtener una persona por Cédula
        public Persona ObtenerPersonaPorID(string cedula)
        {
            using (Conexion)
            {
                Conexion.Open();

                string query = "SELECT * FROM Personas WHERE PersonaID = @Cedula";

                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@Cedula", cedula);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Persona
                            {
                                Cedula = (string)reader["Cedula"],
                                Nombre = (string)reader["Nombre"],
                                Apellido = (string)reader["Apellido"],
                                Edad = (int)reader["Edad"],
                                FechaNacimiento = (DateTime)reader["FechaNacimiento"]
                            };
                        }
                    }
                }
            }

            return null; // Retorna nulo si no se encuentra ninguna persona con la Cédula dada
        }

        // Método para actualizar una persona
        public void ActualizarPersona(Persona persona)
        {
            using (Conexion)
            {
                Conexion.Open();

                string query = "UPDATE Personas SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, FechaNacimiento = @FechaNacimiento WHERE Cedula = @Cedula";

                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@Cedula", persona.Cedula);
                    command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                    command.Parameters.AddWithValue("@Apellido", persona.Apellido);
                    command.Parameters.AddWithValue("@Edad", persona.Edad);
                    command.Parameters.AddWithValue("@FechaNacimiento", persona.FechaNacimiento);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar una persona
        public void EliminarPersona(string cedula)
        {
            using (Conexion)
            {
                Conexion.Open();

                string query = "DELETE FROM Personas WHERE Cedula = @Cedula";

                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@Cedula", cedula);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para listar personas con filtros
        public List<Persona> ListarPersonas(string filtro, string tipoFiltro)
        {
            List<Persona> personas = new List<Persona>();
            string sql = "";

            using (Conexion)
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion;
                comando.CommandType = CommandType.Text;

                // Utilizar un switch para determinar el tipo de filtro
                switch (tipoFiltro)
                {
                    case "ID":
                        sql = "SELECT * FROM Personas WHERE ID = @Filtro";
                        comando.Parameters.AddWithValue("@Filtro", filtro);
                        break;
                    case "Cedula":
                        sql = "SELECT * FROM Personas WHERE Cedula = @Filtro";
                        comando.Parameters.AddWithValue("@Filtro", filtro);
                        break;
                    case "Nombre":
                        sql = "SELECT * FROM Personas WHERE Nombre LIKE '%' + @Filtro + '%'";
                        comando.Parameters.AddWithValue("@Filtro", filtro);
                        break;
                    case "Apellido":
                        sql = "SELECT * FROM Personas WHERE Apellido LIKE '%' + @Filtro + '%'";
                        comando.Parameters.AddWithValue("@Filtro", filtro);
                        break;
                    case "Edad":
                        sql = "SELECT * FROM Personas WHERE Edad = @Filtro";
                        comando.Parameters.AddWithValue("@Filtro", filtro);
                        break;
                    case "FechaNacimiento":
                        sql = "SELECT * FROM Personas WHERE FechaNacimiento = @Filtro";
                        comando.Parameters.AddWithValue("@Filtro", filtro);
                        break;
                    default:
                        sql = "SELECT * FROM Personas";
                        break;
                }

                comando.CommandText = sql;

                Conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Persona oPersona = new Persona();

                    oPersona.PersonaID = reader.GetInt32(0);
                    oPersona.Cedula = reader.GetString(1);
                    oPersona.Nombre = reader.GetString(2);
                    oPersona.Apellido = reader.GetString(3);
                    oPersona.Edad = reader.GetInt32(4);
                    oPersona.FechaNacimiento = reader.GetDateTime(5);
                    personas.Add(oPersona);
                }

                reader.Close();
                Conexion.Close();
            }

            return personas;
        }
    }

}

