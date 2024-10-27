using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create, read, update, delete
            Console.WriteLine("***** Menu Order Panel *****");
            Console.WriteLine();
            Console.WriteLine("-----------------");

            #region Catagory Addition
            /*
            Console.Write("Enter a name to add catagory: ");
            string catagoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=HUAWEI\\SQLEXPRESS;" +
                "initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblCatagory (CatagoryName) values (@p1)",connection);
            command.Parameters.AddWithValue("@p1", catagoryName);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("The catagory successfully added.");
            */
            #endregion

            #region Product Addition

            string productName; decimal productPrice; bool productStatus;

            Console.Write("Enter a prdouct to add products: ");
            productName = Console.ReadLine();
            Console.Write("Enter the price of the product: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=HUAWEI\\SQLEXPRESS;" +
                "initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) " +
                "values (@productName,@productPrice,@productStatus)",connection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", true);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("The Product was added.");

            #endregion



            Console.ReadKey();
        }
    }
}
