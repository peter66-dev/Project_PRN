using Business_Object;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDAO
    {
        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        private CategoryDAO()
        {

        }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }

        static string GetConnectionString()
        {
            string connection = "";
            IConfiguration config = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("connectionString.json", true, true)
                                .Build();
            connection = config["ConnectionString:PetStoreDB"];
            return connection;
        }
        SqlConnection connection;
        SqlCommand command;
        public List<CategoryObject> GetCategoryList()
        {
            connection = new SqlConnection(GetConnectionString());
            List<CategoryObject> list = new List<CategoryObject>();
            command = new SqlCommand("select * from tblCategories", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        CategoryObject category = new CategoryObject();
                        category.CategoryID = rs.GetInt32("CategoryID");
                        category.CategoryName = rs.GetString("CategoryName");
                        list.Add(category);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }
    }
}
