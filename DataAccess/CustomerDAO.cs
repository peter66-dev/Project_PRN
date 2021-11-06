using Business_Object;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace DataAccess
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        private static readonly object instanceLock = new object();
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        static string GetConnectionString()
        {
            string connection = "";
            IConfiguration config = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("connectionString.json", true, true).
                Build();
            connection = config["ConnectionString:PetStoreDB"];
            return connection;
        }
        SqlConnection connection;
        SqlCommand command;

        public List<CustomerObject> GetCustomerList()
        {
            List<CustomerObject> list = new List<CustomerObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Select CustomerID, CustomerName, Gender, Email, " +
                "Phone, Address, AccumulatedPoint From tblCustomers where Status = @Status", connection);
            command.Parameters.AddWithValue("@Status", 1);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        CustomerObject cus = new CustomerObject()
                        {
                            CustomerID = rs.GetInt32("CustomerID"),
                            CustomerName = rs.GetString("CustomerName"),
                            Email = rs.GetString("Email"),
                            Phone = rs.GetString("Phone"),
                            Address = rs.GetString("Address"),
                            Gender = rs.GetBoolean("Gender"),
                            AccumulatedPoint = rs.GetInt32("AccumulatedPoint"),
                            Status = true
                        };
                        list.Add(cus);
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
        public List<CustomerObject> SortCustomerAscendingName()
        {
            List<CustomerObject> list = new List<CustomerObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Select CustomerID, CustomerName, Gender, Email, " +
                "Phone, Address, AccumulatedPoint From tblCustomers where Status = @Status ORDER BY CustomerName asc", connection);
            command.Parameters.AddWithValue("@Status", 1);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        CustomerObject cus = new CustomerObject()
                        {
                            CustomerID = rs.GetInt32("CustomerID"),
                            CustomerName = rs.GetString("CustomerName"),
                            Email = rs.GetString("Email"),
                            Phone = rs.GetString("Phone"),
                            Address = rs.GetString("Address"),
                            Gender = rs.GetBoolean("Gender"),
                            AccumulatedPoint = rs.GetInt32("AccumulatedPoint"),
                            Status = true
                        };
                        list.Add(cus);
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

        public List<CustomerObject> SortCustomerDescendingName()
        {
            List<CustomerObject> list = new List<CustomerObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Select CustomerID, CustomerName, Gender, Email, " +
                "Phone, Address, AccumulatedPoint From tblCustomers where Status = @Status ORDER BY CustomerName desc", connection);
            command.Parameters.AddWithValue("@Status", 1);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        CustomerObject cus = new CustomerObject()
                        {
                            CustomerID = rs.GetInt32("CustomerID"),
                            CustomerName = rs.GetString("CustomerName"),
                            Email = rs.GetString("Email"),
                            Phone = rs.GetString("Phone"),
                            Address = rs.GetString("Address"),
                            Gender = rs.GetBoolean("Gender"),
                            AccumulatedPoint = rs.GetInt32("AccumulatedPoint"),
                            Status = true
                        };
                        list.Add(cus);
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

        public void InsertCustomer(CustomerObject cus)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("INSERT INTO tblCustomers (CustomerName, Gender, Email, Phone, Address, AccumulatedPoint, Status) " +
                "values(@CustomerName, @Gender, @Email, @Phone, @Address, @AccumulatedPoint, 1)", connection);
            command.Parameters.AddWithValue("@CustomerName", cus.CustomerName);
            command.Parameters.AddWithValue("@Gender", cus.Gender);
            command.Parameters.AddWithValue("@Email", cus.Email);
            command.Parameters.AddWithValue("@Phone", cus.Phone);
            command.Parameters.AddWithValue("@Address", cus.Address);
            command.Parameters.AddWithValue("@AccumulatedPoint", cus.AccumulatedPoint);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateCustomer(CustomerObject cus)//KHÔNG UPDATE CUSTOMERID
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Update tblCustomers set CustomerName = @CustomerName, Gender = @Gender, " +
                "Email = @Email, Phone = @Phone, [Address] = @Address, AccumulatedPoint = @AccumulatedPoint, " +
                "Status = @Status where CustomerID = @CustomerID", connection);
            command.Parameters.AddWithValue("@CustomerID", cus.CustomerID);
            command.Parameters.AddWithValue("@CustomerName", cus.CustomerName);
            command.Parameters.AddWithValue("@Email", cus.Email);
            command.Parameters.AddWithValue("@Phone", cus.Phone);
            command.Parameters.AddWithValue("@Address", cus.Address);
            command.Parameters.AddWithValue("@AccumulatedPoint", cus.AccumulatedPoint);
            command.Parameters.AddWithValue("@Status", cus.Status);
            command.Parameters.AddWithValue("@Gender", cus.Gender);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public CustomerObject GetCustomerByID(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select CustomerName, Gender, Email, " +
                "Phone, Address, AccumulatedPoint From tblCustomers " +
                "where CustomerID = @CustomerID and Status = 1", connection);
            command.Parameters.AddWithValue("@CustomerID", id);
            CustomerObject cus = new CustomerObject();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        cus.CustomerID = id;
                        cus.CustomerName = reader.GetString("CustomerName");
                        cus.Gender = reader.GetBoolean("Gender");
                        cus.Email = reader.GetString("Email");
                        cus.Phone = reader.GetString("Phone");
                        cus.Address = reader.GetString("Address");
                        cus.AccumulatedPoint = reader.GetInt32("AccumulatedPoint");
                        cus.Status = true;
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
            return cus;
        }

        public bool CheckCustomerByEmailAndPhone(string email, string phone) // check exist when create a new customer
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select AccumulatedPoint From tblCustomers where Email = @Email or Phone = @Phone", connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            bool check = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        check = true;
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
            return check;
        }

        public bool CheckCustomerByIDandEmailAndPhone(int id, string email, string phone) // check exist when updating a new customer
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select AccumulatedPoint From tblCustomers " +
                "where Email = @Email and Phone = @Phone and CustomerID != @CustomerID", connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@CustomerID", id);
            bool check = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        check = true;
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
            return check;
        }

        public List<CustomerObject> GetCustomerByEmail(string email)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select CustomerID, CustomerName, Gender, Email, " +
                "Phone, Address, AccumulatedPoint From tblCustomers " +
                "where Email like @Email and Status = 1", connection);
            command.Parameters.AddWithValue("@Email", "%" + email + "%");
            List<CustomerObject> list = new List<CustomerObject>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CustomerObject cus = new CustomerObject();
                        cus.CustomerID = reader.GetInt32("CustomerID");
                        cus.CustomerName = reader.GetString("CustomerName");
                        cus.Gender = reader.GetBoolean("Gender");
                        cus.Email = reader.GetString("Email");
                        cus.Phone = reader.GetString("Phone");
                        cus.Address = reader.GetString("Address");
                        cus.AccumulatedPoint = reader.GetInt32("AccumulatedPoint");
                        cus.Status = true;
                        list.Add(cus);
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

        public CustomerObject GetACustomerByEmail(string email)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select CustomerID, CustomerName, Gender, Email, " +
                "Phone, Address, AccumulatedPoint From tblCustomers " +
                "where Email like @Email and Status = 1", connection);
            command.Parameters.AddWithValue("@Email", "%" + email + "%");
            CustomerObject cus = new CustomerObject();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        cus.CustomerID = reader.GetInt32("CustomerID");
                        cus.CustomerName = reader.GetString("CustomerName");
                        cus.Gender = reader.GetBoolean("Gender");
                        cus.Email = reader.GetString("Email");
                        cus.Phone = reader.GetString("Phone");
                        cus.Address = reader.GetString("Address");
                        cus.AccumulatedPoint = reader.GetInt32("AccumulatedPoint");
                        cus.Status = true;
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
            return cus;
        }
        public CustomerObject GetACustomerByPhone(string phone)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select CustomerID, CustomerName, Gender, Email, " +
                "Phone, Address, AccumulatedPoint From tblCustomers " +
                "where Phone = @Phone and Status = 1", connection);
            command.Parameters.AddWithValue("@Phone", phone );
            CustomerObject cus = new CustomerObject();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        cus.CustomerID = reader.GetInt32("CustomerID");
                        cus.CustomerName = reader.GetString("CustomerName");
                        cus.Gender = reader.GetBoolean("Gender");
                        cus.Email = reader.GetString("Email");
                        cus.Phone = reader.GetString("Phone");
                        cus.Address = reader.GetString("Address");
                        cus.AccumulatedPoint = reader.GetInt32("AccumulatedPoint");
                        cus.Status = true;
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
            return cus;
        }

        public CustomerObject GetCustomerForeignKey(int cusID)
        {
            CustomerObject cus = new CustomerObject();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select CustomerName, Gender, Email, " +
                "Phone, Address, AccumulatedPoint, Status From tblCustomers where CustomerID in " +
                "(select CustomerID from tblBills Where customerid = @CustomerID)", connection);
            command.Parameters.AddWithValue("@CustomerID", cusID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cus.CustomerID = cusID;
                        cus.CustomerName = reader.GetString("CustomerName");
                        cus.Gender = reader.GetBoolean("Gender");
                        cus.Email = reader.GetString("Email");
                        cus.Phone = reader.GetString("Phone");
                        cus.Address = reader.GetString("Address");
                        cus.AccumulatedPoint = reader.GetInt32("AccumulatedPoint");
                        cus.Status = reader.GetBoolean("Status");
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
            return cus;
        }

        public void DeleteCustomer(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update tblCustomers set status = 0 where customerid = @customerid", connection);
            command.Parameters.AddWithValue("@customerid", id);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
