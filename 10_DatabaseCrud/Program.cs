using System;
using System.Collections.Generic;
using System.Data;
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
            /*
            string productName; decimal productPrice; //bool productStatus;

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
            */
            #endregion

            #region Listing

            // i already done it in 09_DatabaseProject
            // i copied that directly
            /*
            Console.WriteLine("***** C# Database Product-Catagory Info System *****");
            Console.WriteLine();
            Console.WriteLine(new string('-', 25));

            string tableNumber;

            Console.WriteLine(
                $"1- Catagories\n" +
                $"2- Products\n" +
                $"3- Orders\n" +
                $"4- Exit");
            Console.Write("Enter the table name: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine(new string('-', 25));

            SqlConnection connection = new SqlConnection("Data Source=HUAWEI\\SQLEXPRESS;" +
                "initial Catalog=EgitimKampiDb;" +
                "integrated security=true");
            connection.Open();

            SqlCommand command;
            SqlDataAdapter adapter;
            DataTable dataTable;

            switch (tableNumber)
            {
                case "1":
                    command = new SqlCommand("Select * from TblCatagory", connection);
                    adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    connection.Close();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        //foreach (var item in row.ItemArray)
                        //{
                        //    Console.Write($"{item.ToString(),-20}");
                        //}
                        Console.WriteLine($"{row.ItemArray[0],3} {row.ItemArray[1],-15}");
                    }
                    connection.Close();
                    break;

                case "2":
                    command = new SqlCommand("Select * from TblProduct", connection);
                    adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    connection.Close();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        //foreach (var item in row.ItemArray)
                        //{
                        //    Console.Write($"{item.ToString(),-20}");
                        //}
                        //Console.WriteLine();
                        Console.WriteLine($"{row.ItemArray[0],3} {row.ItemArray[1],-20} " +
                            $"{row.ItemArray[2],-9} {row.ItemArray[3],-5}");
                    }
                    connection.Close();
                    break;

                case "3":
                    command = new SqlCommand("Select * from TblOrder", connection);
                    adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    connection.Close();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        //foreach (var item in row.ItemArray)
                        //{
                        //    Console.Write($"{item.ToString(),-20}");
                        //}
                        //Console.WriteLine();
                        Console.WriteLine($"{row.ItemArray[0],3} {row.ItemArray[1],-20} " +
                            $"{row.ItemArray[2],-3} {row.ItemArray[3],-9} {row.ItemArray[4],-9}");

                    }
                    connection.Close();
                    break;

                case "4":
                    connection.Close();
                    break;

                default:
                    Console.WriteLine("Enter an invalid option.");
                    break;
            }
            */

            #endregion

            #region Delete an Item
            /*
            Console.Write("Enter the product id to del: ");
            int productId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=HUAWEI\\SQLEXPRESS;" +
                "initial Catalog=EgitimKampiDb;" +
                "integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Delete from TblProduct Where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productId",productId);
            command.ExecuteNonQuery();
            */
            #endregion

            #region Update an Item
            /*
            Console.Write("Enter the product id to update: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Enter a new name for product: ");
            string productName = Console.ReadLine();
            Console.Write("Enter a new price for product: ");
            double productPrice = double.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=HUAWEI\\SQLEXPRESS;" +
                "initial Catalog=EgitimKampiDb;" +
                "integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice" +
                " Where ProductId=@productId",connection);
            command.Parameters.AddWithValue("@productName",productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Updated successfully!");
            */
            #endregion


            Console.ReadKey();
        }
    }
}
