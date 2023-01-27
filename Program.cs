
using POO.Models;
using System.Data.SqlClient;

string connectionString = "Data Source=DESKTOP-DN4H68E\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand comando = new SqlCommand("SELECT * FROM Usuario", connection);
    connection.Open();
    SqlDataReader reader = comando.ExecuteReader();

    List<Usuario> list = new List<Usuario>();

    if (reader.HasRows)
    {
        while (reader.Read())
        {
            list.Add(new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
        }
    }

    foreach (var item in list)
    {
        Console.WriteLine(item.NombreUsuario);
    }

}



