using System.Data.SqlClient;
using System.Data;

namespace Principal
{
    class Program
    {
        private static string stringConnection = @"Server=localhost;Database=promericatest;User Id=sa;Password=Str0ng_P@ssw0rd;";
        private static SqlConnection sqlConnection = new SqlConnection(stringConnection);

        private static DataSet getProducts() {
            sqlConnection.Open();
            
            DataSet products = new DataSet();

            String query = "SELECT * FROM Producto";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            
            adapter.Fill(products);

            sqlConnection.Close();

            return products;
        }

        private static void insertProduct(int producto, string descripcion) {

            sqlConnection.Open();
            
            String query = "INSERT INTO Producto(producto, descripcion) VALUES (" + producto + ", '" + descripcion + "')";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private static int updateProducts(int producto, string descripcion) {
            sqlConnection.Open();
            
            String query = "";
            if(producto != -1) {
                query = "UPDATE Producto SET descripcion = '" + descripcion + "' WHERE producto = " + producto;
            } else {
                query = "UPDATE Producto SET descripcion = '" + descripcion + "'";
            }

            SqlCommand command = new SqlCommand(query, sqlConnection);

            int affected = command.ExecuteNonQuery();

            sqlConnection.Close();

            return affected;
        }

        private static int deleteProducts(int producto) {
            sqlConnection.Open();
            
            String query = "";
            if(producto != -1) {
                query = "DELETE FROM Producto WHERE producto = " + producto;
            } else {
                query = "DELETE FROM Producto";
            }

            SqlCommand command = new SqlCommand(query, sqlConnection);

            int affected = command.ExecuteNonQuery();

            sqlConnection.Close();

            return affected;
        }

        private static int getTotalProducts() {
            sqlConnection.Open();
            
            DataSet products = new DataSet();

            String query = "SELECT * FROM Producto";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(products);

            sqlConnection.Close();

            return products.Tables[0].Rows.Count;
        }

        static void Main(string[] args)
        {
            /*DataSet products = getProducts();
            
            foreach (DataTable table in products.Tables)
            {
                foreach (DataRow row in table.Rows) {
                    Console.WriteLine("Line new: " + row["descripcion"]);
                }
            }*/


            /*String query = "SELECT * FROM Producto";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("Producto: " + reader.GetValue(0).ToString());
            }

            reader.Close();
            */

            //insertProduct(4, "Producto 4");
            //Console.WriteLine("Producto insertado");

            //Console.WriteLine("Total Products: " + getTotalProducts());

            //Console.WriteLine("Total updated: " + updateProducts(3, "Platinum"));

            Console.WriteLine("Total deleted: " + deleteProducts(4));
        }

        
    }
}