using POO.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Controllers
{
    public class ProductoVendidoController
    {
        //Traer ProductosVendidos(recibe el id del usuario y devuelve una lista de productos vendidos por ese usuario)

        public static List<ProductoVendido> GetProductoVendido(long IdVenta)
        {
            var connectionString = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (var connection = new  SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductoVendido WHERE IdVenta = @id",connection);
                var param = new SqlParameter("id", IdVenta);
                cmd.Parameters.Add(param);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                List<ProductoVendido> listaProductos= new List<ProductoVendido>();

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        var produtoVendido = new ProductoVendido()
                        {
                            Id = reader.GetInt64(0),
                            Stock = reader.GetInt32(1),
                            IdProducto = reader.GetInt64(2),
                            IdVenta = reader.GetInt64(3),
                        };

                        listaProductos.Add(produtoVendido);
                    }
                }
                return listaProductos;
            }

        }
    }
}
