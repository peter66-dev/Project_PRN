using Business_Object;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace DataAccess
{
    public class BillDetailDAO
    {
        private static BillDetailDAO instance = null;
        private static readonly object intanceLock = new object();
        private BillDetailDAO() { }
        public static BillDetailDAO Instance
        {
            get
            {
                lock (intanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BillDetailDAO();
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

        public List<BillDetailObject> GetBillDetailList()
        {
            List<BillDetailObject> list = new List<BillDetailObject>();
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select BillDetailID, BillID, PetID, " +
                "QuantityBuy, SubTotal, Discount from tblBillDetails", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        BillDetailObject b = new BillDetailObject()
                        {
                            BillDetailID = rs.GetInt32("BillDetailID"),
                            BillID = rs.GetInt32("BillID"),
                            PetID = rs.GetInt32("PetID"),
                            QuantityBuy = rs.GetInt32("QuantityBuy"),
                            SubTotal = rs.GetDecimal("SubTotal"),
                            Discount = rs.GetDouble("Discount")
                        };
                        list.Add(b);
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

        public void InsertBillDetail(BillDetailObject bill)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("insert into tblBillDetails(BillID, PetID,  QuantityBuy,  SubTotal,  Discount) " +
                "values(@BillID, @PetID, @QuantityBuy, @SubTotal, @Discount)", connection);
            command.Parameters.AddWithValue("@BillID", bill.BillID);
            command.Parameters.AddWithValue("@PetID", bill.PetID);
            command.Parameters.AddWithValue("@QuantityBuy", bill.QuantityBuy);
            command.Parameters.AddWithValue("@SubTotal", bill.SubTotal);
            command.Parameters.AddWithValue("@Discount", bill.Discount);
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
