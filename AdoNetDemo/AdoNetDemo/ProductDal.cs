using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal //DAL : DATA ACCESS OBJECT
    {
        public List<Product> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open(); // Bağlantı açma işlemi kontrolle yapılır
            }
            SqlCommand command = new SqlCommand("Select * from Products",connection);

            SqlDataReader reader = command.ExecuteReader(); // Select komutu için bu metod kullanılır

            List<Product> products = new List<Product>();
            while (reader.Read()) // Datayı tek tek okumaya yarar
            {
                Product product = new Product 
                { 
                    Id = Convert.ToInt32(reader["Id"]) ,
                    Name = Convert.ToString(reader["Name"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            // DataTable dt = new DataTable();
            // dt.Load(reader);

            reader.Close();
            connection.Close();
            return products;
        }
    }
}
