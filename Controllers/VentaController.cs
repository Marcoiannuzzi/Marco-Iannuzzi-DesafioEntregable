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

        public static List<Venta> GetVentas(long IdUsuario)
        {
            string connectionString = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Venta WHERE IdUsuario = @id", connection);
                SqlParameter param = new SqlParameter("id", IdUsuario);
                comando.Parameters.Add(param);
                
                var listaventas = new List<Venta>();

                connection.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if(reader.HasRows) 
                {
                    while(reader.Read())
                    {
                        var venta = new Venta()
                        {
                            Id = reader.GetInt64(0),
                            Comentarios = reader.GetString(1),
                            IdUsuario = reader.GetInt64(2)
                        };

                        listaventas.Add(venta);
                    }
                }

                return listaventas;
            }
        }
    }
}
