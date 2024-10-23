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
            Console.WriteLine("\n");
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

            SqlCommand command = new SqlCommand("Select * from TblCatagory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();

            }


            Console.ReadKey();
        }
    }
}
