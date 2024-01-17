using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCRUD_IL29.Conexion;

namespace WCRUD_IL29.Clases
{
    internal class CredencialesBD : ConexionBD
    {
        public class Credenciales
        {
            public int UsuarioID { get; set; }
            public string NombreUsuario { get; set; }
            public string Contraseña { get; set; }
        }

        public List<Credenciales> ListarCredenciales(string filtro, string tipoFiltro)
        {
            List<Credenciales> credencialesList = new List<Credenciales>();
            string sql = "";

            using (Conexion)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = Conexion;
                command.CommandType = CommandType.Text;

                // Utilizar un switch para determinar el tipo de filtro
                switch (tipoFiltro)
                {
                    case "UsuarioID":
                        sql = "SELECT * FROM Credenciales WHERE UsuarioID = @Filtro";
                        command.Parameters.AddWithValue("@Filtro", filtro);
                        break;
                    case "NombreUsuario":
                        sql = "SELECT * FROM Credenciales WHERE NombreUsuario LIKE '%' + @Filtro + '%'";
                        command.Parameters.AddWithValue("@Filtro", filtro);
                        break;
                    default:
                        sql = "SELECT * FROM Credenciales";
                        break;
                }

                command.CommandText = sql;

                Conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Credenciales credencial = new Credenciales();
                    credencial.UsuarioID = reader.GetInt32(0);
                    credencial.NombreUsuario = reader.GetString(1);
                    credencial.Contraseña = reader.GetString(2);
                    credencialesList.Add(credencial);
                }

                reader.Close();
                Conexion.Close();
            }

            return credencialesList;
        }


        // Método para agregar una nueva credencial
        public void AgregarCredencial(Credenciales credencial)
        {
            using (Conexion)
            {
                Conexion.Open();

                string query = "INSERT INTO Credenciales (NombreUsuario, Contraseña) VALUES (@NombreUsuario, @Contraseña)";

                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", credencial.NombreUsuario);
                    command.Parameters.AddWithValue("@Contraseña", credencial.Contraseña);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener una credencial por ID
        public Credenciales ObtenerCredencialPorID(int usuarioID)
        {
            using (Conexion)
            {
                Conexion.Open();

                string query = "SELECT * FROM Credenciales WHERE UsuarioID = @UsuarioID";

                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@UsuarioID", usuarioID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Credenciales
                            {
                                UsuarioID = (int)reader["UsuarioID"],
                                NombreUsuario = (string)reader["NombreUsuario"],
                                Contraseña = (string)reader["Contraseña"]
                            };
                        }
                    }
                }
            }

            return null; // Retorna nulo si no se encuentra ninguna credencial con el ID dado
        }

        // Método para actualizar una credencial
        public void ActualizarCredencial(Credenciales credencial)
        {
            using (Conexion)
            {
                Conexion.Open();

                string query = "UPDATE Credenciales SET NombreUsuario = @NombreUsuario, Contraseña = @Contraseña WHERE UsuarioID = @UsuarioID";

                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@UsuarioID", credencial.UsuarioID);
                    command.Parameters.AddWithValue("@NombreUsuario", credencial.NombreUsuario);
                    command.Parameters.AddWithValue("@Contraseña", credencial.Contraseña);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar una credencial
        public void EliminarCredencial(int usuarioID)
        {
            using (Conexion)
            {
                Conexion.Open();

                string query = "DELETE FROM Credenciales WHERE UsuarioID = @UsuarioID";

                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@UsuarioID", usuarioID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool ValidarCredenciales(string nombreUsuario, string contraseña)
        {
            using (Conexion)
            {
                Conexion.Open();

                string query = "SELECT COUNT(*) FROM Credenciales WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";

                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    int result = (int)command.ExecuteScalar();

                    return result > 0;
                }
            }

        }
    }
}
