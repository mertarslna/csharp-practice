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
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open(); // Bağlantı açma işlemi kontrolle yapılır
            }
            SqlCommand command = new SqlCommand("Select * from Products", _connection);

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
            _connection.Close();
            return products;
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("" +
                "INSERT INTO Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery(); // int kayıt sayısını döndürür kullanılabilir
            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("" +
                "UPDATE Products SET Name=@Name,UnitPrice=@unitPrice,StockAmount=@stockAmount where id = @id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id",product.Id);
            command.ExecuteNonQuery(); 

            _connection.Close();
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
