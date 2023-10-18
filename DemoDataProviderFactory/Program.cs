using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataProviderFactory
{
    public class Program
    {
        static string GetConnectionString()
        {

            IConfiguration config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", true, true)
                          .Build();
            var strConnection = config["ConnectionStrings:MyStoreDB"];
            return strConnection;


        }
        static void ViewProducts()
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
       
            using DbConnection connection = factory.CreateConnection(); 
            
            if (connection == null)
            {
                Console.WriteLine($"Unable to create the connection object.");
                return;
            }
          
            connection.ConnectionString = GetConnectionString(); 
            connection.Open();
            DbCommand command = connection.CreateCommand();
            if (command == null)
            {
                Console.WriteLine($"Unable to create the command object.");
                return;
            }
            command.Connection = connection;
            command.CommandText = "select ProductID, Name from Products";
            using DbDataReader ddDataReader = command.ExecuteReader();
            Console.WriteLine($"*****Product list*****");
            while (ddDataReader.Read())
            {
                Console.WriteLine($"Product ID: {ddDataReader["ProductID"]}, Product Name: {ddDataReader["Name"]}");
            }
        }
        static void Main(string[] args)
        {
            ViewProducts();
            Console.ReadLine();
        }

    }
}
