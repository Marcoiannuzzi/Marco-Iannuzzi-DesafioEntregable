using POO.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Controllers
{
    public class VentaController
    {
        public static List<Venta> GetVentas(int IdUsuario)
        {
            string connectionString = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Producto", connection);
                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();





                var listaventas = new List<Venta>();

                return listaventas;
            }
        }
    }
}
