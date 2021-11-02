using Business_Object;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace DataAccess
{
    public class BillDAO
    {
        private static BillDAO instance = null;
        private static readonly object instanceLock = new object();
        private BillDAO()
        {

        }
        public static BillDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BillDAO();
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
        public List<BillObject> GetBillList()
        {
            connection = new SqlConnection(GetConnectionString());
            List<BillObject> list = new List<BillObject>();
            command = new SqlCommand("select BillID, CustomerID, Total, Date, Status from tblBills where status = 1", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        BillObject bill = new BillObject();
                        bill.BillID = rs.GetInt32("BillID");
                        bill.CustomerID = rs.GetInt32("CustomerID");
                        bill.Total = Math.Round(rs.GetDecimal("Total"));
                        bill.Date = rs.GetDateTime("Date");
                        bill.Status = rs.GetBoolean("Status");
                        list.Add(bill);
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
        public List<BillObject> SortByTotalAscending()
        {
            connection = new SqlConnection(GetConnectionString());
            List<BillObject> list = new List<BillObject>();
            command = new SqlCommand("select BillID, CustomerID, Total, Date, Status from tblBills where status = 1 ORDER BY Total asc", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        BillObject bill = new BillObject();
                        bill.BillID = rs.GetInt32("BillID");
                        bill.CustomerID = rs.GetInt32("CustomerID");
                        bill.Total = Math.Round(rs.GetDecimal("Total"));
                        bill.Date = rs.GetDateTime("Date");
                        bill.Status = rs.GetBoolean("Status");
                        list.Add(bill);
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

        public List<BillObject> SortByTotalDescending()
        {
            connection = new SqlConnection(GetConnectionString());
            List<BillObject> list = new List<BillObject>();
            command = new SqlCommand("select BillID, CustomerID, Total, Date, Status from tblBills where status = 1 ORDER BY Total desc", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        BillObject bill = new BillObject();
                        bill.BillID = rs.GetInt32("BillID");
                        bill.CustomerID = rs.GetInt32("CustomerID");
                        bill.Total = Math.Round(rs.GetDecimal("Total"));
                        bill.Date = rs.GetDateTime("Date");
                        bill.Status = rs.GetBoolean("Status");
                        list.Add(bill);
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

        public BillObject GetBillByID(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            BillObject bill = new BillObject();
            command = new SqlCommand("select CustomerID, Total, Date, Status from tblBills where BillID = @BillID", connection);
            command.Parameters.AddWithValue("@BillID", id);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    if (rs.Read())
                    {
                        bill.BillID = id;
                        bill.CustomerID = rs.GetInt32("CustomerID");
                        bill.Total = rs.GetDecimal("Total");
                        bill.Date = rs.GetDateTime("Date");
                        bill.Status = rs.GetBoolean("Status");
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
            return bill;
        }

        public int GetTotalBill()
        {
            int count = 0;
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select count(BillID) as Total from tblBills", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    if (rs.Read())
                    {
                        count = rs.GetInt32("Total");
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

            return count;
        }

        public void InsertBill(int billID, int cusID, decimal total, decimal freight)// không nên để khóa chính tự tăng ở đây
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Insert into tblBills (BillID, CustomerID, Total, Date, Status, Freight) " +
                "values(@BillID, @CustomerID, @Total, getdate(), 1, @Freight)", connection);
            command.Parameters.AddWithValue("@BillID", billID);
            command.Parameters.AddWithValue("@CustomerID", cusID);
            command.Parameters.AddWithValue("@Total", total);
            command.Parameters.AddWithValue("@Freight", freight);
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

        public void UpdateBill(int id, decimal total)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update tblBills set Total = @Total where BillID = @BillID", connection);
            command.Parameters.AddWithValue("@Total", total);
            command.Parameters.AddWithValue("@BillID", id);
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

        public void RemoveBill(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update tblBills set Status = 0 where BillID = @BillID", connection);
            command.Parameters.AddWithValue("@BillID", id);
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
        public List<BillObject> GetBillListByDate(DateTime start, DateTime end)
        {
            connection = new SqlConnection(GetConnectionString());
            List<BillObject> list = new List<BillObject>();
            command = new SqlCommand("select BillID, CustomerID, Total, Date, Status from tblBills " +
                "where @StartDate <= [Date] AND @EndDate >= [Date] and Status = 1", connection);
            command.Parameters.AddWithValue("@StartDate", start);
            command.Parameters.AddWithValue("@EndDate", end);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        BillObject bill = new BillObject();
                        bill.BillID = rs.GetInt32("BillID");
                        bill.CustomerID = rs.GetInt32("CustomerID");
                        bill.Total = Math.Round(rs.GetDecimal("Total") ,2);
                        bill.Date = rs.GetDateTime("Date");
                        bill.Status = true;
                        list.Add(bill);
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

        public decimal GetTotalImportMoney()
        {
            decimal total = 0;
            string sql = "select Statistic.PetID, p.ImportPrice, Statistic.total as [Sold Quantity] " +
                "from (select PetID, sum(QuantityBuy) as total from tblBillDetails where BillID in " +
                "(select BillID from tblBills where Status = 1) group by PetID) Statistic " +
                "left join tblPets p on Statistic.PetID = p.PetID";
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        total += rs.GetDecimal("ImportPrice") * rs.GetInt32("Sold Quantity");
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Math.Round(total, 2);
        }
    }
}
