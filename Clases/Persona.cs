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
            public int Cedula { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }
            public DateTime FechaNacimiento { get; set; }
        }



        // Método para agregar una nueva persona
    public void AgregarPersona(Persona persona)
        {
            using (Conexion)
            {
                Conexion.Open();

                string query = "INSERT INTO Personas (Nombre, Apellido, Edad, FechaNacimiento) VALUES (@Nombre, @Apellido, @Edad, @FechaNacimiento)";

                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                    command.Parameters.AddWithValue("@Apellido", persona.Apellido);
                    command.Parameters.AddWithValue("@Edad", persona.Edad);
                    command.Parameters.AddWithValue("@FechaNacimiento", persona.FechaNacimiento);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener una persona por ID
        public Persona ObtenerPersonaPorID(int cedula)
        {
            using (Conexion)
            {
                Conexion.Open();

                string query = "SELECT * FROM Personas WHERE Cedula = @Cedula";

                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@Cedula", cedula);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Persona
                            {
                                Cedula = (int)reader["Cedula"],
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
        public void EliminarPersona(int cedula)
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
                    oPersona.Cedula = reader.GetInt32(0);
                    oPersona.Nombre = reader.GetString(1);
                    oPersona.Apellido = reader.GetString(2);
                    oPersona.Edad = reader.GetInt32(3);
                    oPersona.FechaNacimiento = reader.GetDateTime(4);
                    personas.Add(oPersona);
                }

                reader.Close();
                Conexion.Close();
            }

            return personas;
        }

    }
}
