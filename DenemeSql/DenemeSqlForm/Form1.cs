using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeSqlForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ProductDal productDal = new ProductDal();

            dgwProducts.DataSource = productDal.GetAll();
        }
    }
    class ProductDal
    {    
        public DataTable GetAll()
        {

            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }   
            SqlCommand command = new SqlCommand("select * from Product", connection);

            SqlDataReader reader = command.ExecuteReader();
            
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();

            return dataTable;
        }   

    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set;}

    }
}
