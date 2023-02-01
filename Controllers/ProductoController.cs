using POO.Models;
using System.Data;
using System.Data.SqlClient;

namespace POO.Controllers
{
    public class ProductoController
    {

       public static List<Producto> GetProductos()
        {
            string connectionString = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Producto", connection);
                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();

                List<Producto> list = new List<Producto>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto temporalProd= new Producto()
                        {
                            Id = reader.GetInt64(0),
                            Descripciones= reader.GetString(1),
                            Costo = reader.GetDecimal(2),
                            PrecioDeVenta=reader.GetDecimal(3),
                            Stock=reader.GetInt32(4),
                            IdUsuario=reader.GetInt64(5),
                        };
                        list.Add(temporalProd);
                    }
                }

                foreach (var item in list)
                {
                    Console.WriteLine(item.Id);
                }

                return list;
            }

        }
    }
}
