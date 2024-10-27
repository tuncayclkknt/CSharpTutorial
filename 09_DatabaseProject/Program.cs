using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net

            Console.WriteLine("***** C# Database Product-Catagory Info System *****");
            Console.WriteLine();
            Console.WriteLine(new string('-',25));

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
                        Console.WriteLine($"{row.ItemArray[0],3} {row.ItemArray[1],-15}");
                    
                    connection.Close();
                    break;

                case "2":
                    command = new SqlCommand("Select * from TblProduct", connection);
                    adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    connection.Close();

                    foreach (DataRow row in dataTable.Rows)
                        Console.WriteLine($"{row.ItemArray[0],3} {row.ItemArray[1],-20} " +
                            $"{row.ItemArray[2],-9} {row.ItemArray[3],-5}");

                    connection.Close();
                    break;

                case "3":
                    command = new SqlCommand("Select * from TblOrder", connection);
                    adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    connection.Close();

                    foreach (DataRow row in dataTable.Rows)
                        Console.WriteLine($"{row.ItemArray[0],3} {row.ItemArray[1],-20} " +
                            $"{row.ItemArray[2],-3} {row.ItemArray[3],-9} {row.ItemArray[4],-9}");

                    connection.Close();
                    break;

                case "4":
                    connection.Close();
                    break;

                default:
                    Console.WriteLine("Enter an invalid option.");
                    break;
            }


            Console.ReadKey();
        }
    }
}
