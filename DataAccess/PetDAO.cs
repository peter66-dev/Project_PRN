using Business_Object;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Data;
using System.Collections.Generic;

namespace DataAccess
{
    public class PetDAO
    {
        private static PetDAO instance = null;
        private static readonly object instanceLock = new object();
        private PetDAO()
        {

        }
        public static PetDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PetDAO();
                    }
                    return instance;
                }
            }
        }
        SqlConnection connection;
        SqlCommand command;
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

        public List<PetObject> GetPetList()
        {
            connection = new SqlConnection(GetConnectionString());
            List<PetObject> list = new List<PetObject>();
            command = new SqlCommand("select PetID, PetName, Age, Gender, Color, QuantityInStock, " +
                "CategoryID, ImportPrice, ExportPrice, Status from tblPets", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        PetObject pet = new PetObject();
                        pet.PetID = rs.GetInt32("PetID");
                        pet.PetName = rs.GetString("PetName");
                        pet.Age = rs.GetInt32("Age");
                        pet.Gender = rs.GetBoolean("Gender");
                        pet.QuantityInStock = rs.GetInt32("QuantityInStock");
                        pet.Color = rs.GetString("Color");
                        pet.CategoryID = rs.GetInt32("CategoryID");
                        pet.ImportPrice = Math.Round(rs.GetDecimal("ImportPrice"));
                        pet.ExportPrice = Math.Round(rs.GetDecimal("ExportPrice"));
                        pet.Status = rs.GetBoolean("Status");
                        list.Add(pet);
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

        public PetObject GetPetByPetID(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            PetObject pet = new PetObject();
            command = new SqlCommand("select PetID, PetName, Age, Gender, Color, QuantityInStock, " +
                "CategoryID, ImportPrice, ExportPrice, Status from tblPets where PetID = @PetID", connection);
            command.Parameters.AddWithValue("@PetID", id);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    if (rs.Read())
                    {
                        pet.PetID = rs.GetInt32("PetID");
                        pet.PetName = rs.GetString("PetName");
                        pet.Age = rs.GetInt32("Age");
                        pet.Gender = rs.GetBoolean("Gender");
                        pet.QuantityInStock = rs.GetInt32("QuantityInStock");
                        pet.Color = rs.GetString("Color");
                        pet.CategoryID = rs.GetInt32("CategoryID");
                        pet.ImportPrice = rs.GetDecimal("ImportPrice");
                        pet.ExportPrice = rs.GetDecimal("ExportPrice");
                        pet.Status = rs.GetBoolean("Status");
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
            return pet;
        }

        public List<PetObject> GetPetByPetName(string name)
        {
            connection = new SqlConnection(GetConnectionString());
            List<PetObject> list = new List<PetObject>();
            command = new SqlCommand("select PetID, PetName, Age, Gender, Color, QuantityInStock, " +
                "CategoryID, ImportPrice, ExportPrice, Status from tblPets where PetName LIKE @PetName", connection);
            command.Parameters.AddWithValue("@PetName", "%" + name + "%");
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        PetObject pet = new PetObject();
                        pet.PetID = rs.GetInt32("PetID");
                        pet.PetName = rs.GetString("PetName");
                        pet.Age = rs.GetInt32("Age");
                        pet.Gender = rs.GetBoolean("Gender");
                        pet.QuantityInStock = rs.GetInt32("QuantityInStock");
                        pet.Color = rs.GetString("Color");
                        pet.CategoryID = rs.GetInt32("CategoryID");
                        pet.ImportPrice = rs.GetDecimal("ImportPrice");
                        pet.ExportPrice = rs.GetDecimal("ExportPrice");
                        pet.Status = rs.GetBoolean("Status");
                        list.Add(pet);
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
            return list;
        }


        public void InsertPet(PetObject pet)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Insert into tblPets (PetName, Age, Gender, Color, QuantityInStock, CategoryID, ImportPrice, ExportPrice, Status) " +
                "values(@PetName, @Age, @Gender, @Color, @QuantityInStock, @CategoryID, @ImportPrice, @ExportPrice, 1)", connection);
            command.Parameters.AddWithValue("@PetName", pet.PetName);
            command.Parameters.AddWithValue("@Age", pet.Age);
            command.Parameters.AddWithValue("@Gender", pet.Gender);
            command.Parameters.AddWithValue("@Color", pet.Color);
            command.Parameters.AddWithValue("@QuantityInStock", pet.QuantityInStock);
            command.Parameters.AddWithValue("@CategoryID", pet.CategoryID);
            command.Parameters.AddWithValue("@ImportPrice", pet.ImportPrice);
            command.Parameters.AddWithValue("@ExportPrice", pet.ExportPrice);
            command.Parameters.AddWithValue("@Status", pet.Status);
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

        public void UpdatePet(PetObject pet)//Phải có PetID
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update tblPets set PetName = @PetName, Age = @Age, Gender = @Gender, " +
                "Color = @Color, QuantityInStock = @QuantityInStock, CategoryID = @CategoryID, ImportPrice = @ImportPrice, " +
                "ExportPrice = @ExportPrice, Status = @status where PetID = @PetID", connection);
            command.Parameters.AddWithValue("@PetName", pet.PetName);
            command.Parameters.AddWithValue("@PetID", pet.PetID);
            command.Parameters.AddWithValue("@Age", pet.Age);
            command.Parameters.AddWithValue("@Gender", pet.Gender);
            command.Parameters.AddWithValue("@Color", pet.Color);
            command.Parameters.AddWithValue("@QuantityInStock", pet.QuantityInStock);
            command.Parameters.AddWithValue("@CategoryID", pet.CategoryID);
            command.Parameters.AddWithValue("@ImportPrice", pet.ImportPrice);
            command.Parameters.AddWithValue("@ExportPrice", pet.ExportPrice);
            if (pet.QuantityInStock == 0)
            {
                pet.Status = false;
            }
            else
            {
                pet.Status = true;
            }
            command.Parameters.AddWithValue("@status", pet.Status);

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

        public void RemovePet(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update tblPets set Status = 0 where PetID = @PetID", connection);
            command.Parameters.AddWithValue("@PetID", id);
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

        public List<string> CheckQuantity(List<PetObject> cart)
        {
            List<string> result = new List<string>();
            foreach (var pet in cart)
            {
                int quantity = GetQuantityByPetID(pet.PetID);// Số lượng trong kho
                if (quantity < pet.QuantityInStock)// kho < số mua
                {
                    result.Add(pet.PetName);
                }
            }
            return result;
        }

        int GetQuantityByPetID(int petID)
        {
            int quantity = 0;
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("select QuantityInStock from tblPets where PetID = @PetID", connection);
            command.Parameters.AddWithValue("@PetID", petID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        quantity = reader.GetInt32("QuantityInStock");
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
            return quantity;
        }

        public void SubQuantityProduct(List<PetObject> cart)
        {
            connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();
                foreach (var pet in cart)
                {
                    command = new SqlCommand("update tblPets set  QuantityInStock = QuantityInStock - @QuantityBuy where PetID = @PetID", connection);
                    command.Parameters.AddWithValue("@QuantityBuy", pet.QuantityInStock);
                    command.Parameters.AddWithValue("@PetID", pet.PetID);
                    command.ExecuteNonQuery();
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
        }

        public void SetStatusPet()
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update tblPets set Status = 0 where QuantityInStock = 0", connection);
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
