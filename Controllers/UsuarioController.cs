using POO.Models;
using System.Data.SqlClient;

namespace POO.Controllers
{
    public class UsuarioController
    {
        public static Usuario GetUsuario(long id)
        {
            string connectionString = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE Id = @id", connection);
                var param = new SqlParameter("id",id);
                comando.Parameters.Add(param);

                connection.Open();

                SqlDataReader reader = comando.ExecuteReader();
                Usuario usuario = new Usuario();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        {
                            usuario.Id = reader.GetInt64(0);
                            usuario.Nombre = reader.GetString(1);
                            usuario.Apellido = reader.GetString(2);
                            usuario.NombreUsuario = reader.GetString(3);
                            usuario.Contraseña = reader.GetString(4);
                            usuario.Mail = reader.GetString(5);
                        };
                    }
                }
                return usuario;
            }
        }

        public static Usuario GetUsuario(string nombreUsuario, string contrasena)
        {
            string connectionString = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE NombreUsuario= @NombreUsuario AND Contraseña=@Contraseña", connection);
                var param = new SqlParameter("NombreUsuario", nombreUsuario);
                var param2 = new SqlParameter("Contraseña", contrasena);
                comando.Parameters.Add(param);
                comando.Parameters.Add(param2);

                connection.Open();

                SqlDataReader reader = comando.ExecuteReader();

                Usuario usuario = new Usuario();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        {
                            usuario.Id = reader.GetInt64(0);
                            usuario.Nombre = reader.GetString(1);
                            usuario.Apellido = reader.GetString(2);
                            usuario.NombreUsuario = reader.GetString(3);
                            usuario.Contraseña = reader.GetString(4);
                            usuario.Mail = reader.GetString(5);
                        };
                    }
                }
                return usuario;
            }
        }

    }
}
