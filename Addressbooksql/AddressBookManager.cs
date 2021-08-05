﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Addressbooksql
{
    public class AddressBookManager
    {
        public static string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Addressbook_services";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        
        public int insertIntoTable(ContactDetails details)
        {
            using (sqlConnection)
                try
                {
                    //passing query in terms of stored procedure
                    SqlCommand sqlCommand = new SqlCommand("dbo.InsertingIntoAddressBook", sqlConnection);
                    //passing command type as stored procedure
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlConnection.Open();
                    //adding the values to the stored procedure
                    sqlCommand.Parameters.AddWithValue("@firstName", details.firstName);
                    sqlCommand.Parameters.AddWithValue("@lastName", details.lastName);
                    sqlCommand.Parameters.AddWithValue("@address", details.address);
                    sqlCommand.Parameters.AddWithValue("@city", details.city);
                    sqlCommand.Parameters.AddWithValue("@state", details.state);
                    sqlCommand.Parameters.AddWithValue("@zipCode", details.zipCode);
                    sqlCommand.Parameters.AddWithValue("@phoneNumber", details.phoneNumber);
                    sqlCommand.Parameters.AddWithValue("@email", details.emailAddress);
                    int result = sqlCommand.ExecuteNonQuery();
                    //if result is greater than 0 then record is inserted
                    if (result > 0)
                        return 1;
                    else
                        return 0;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
        }
        public int EditContactDetail(int id, string firstName, long phoneNumber)
        {
            using (sqlConnection)
                try
                {
                    //passing query in terms of stored procedure
                    SqlCommand sqlCommand = new SqlCommand("dbo.EditPhoneNumber", sqlConnection);
                    //passing command type as stored procedure
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlConnection.Open();
                    //adding the values to the stored procedure
                    sqlCommand.Parameters.AddWithValue("@firstName", firstName);
                    sqlCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    int result = sqlCommand.ExecuteNonQuery();
                    //if result is greater than 0 then record is inserted
                    if (result > 0)
                        return 1;
                    else
                        return 0;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
        }
        public int DeletetheRecord(int id, string firstName)
        {
            using (sqlConnection)
                try
                {
                    //passing query in terms of stored procedure
                    SqlCommand sqlCommand = new SqlCommand("dbo.DeleteRecord", sqlConnection);
                    //passing command type as stored procedure
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlConnection.Open();
                    //adding the values to the stored procedure
                    sqlCommand.Parameters.AddWithValue("@firstName", firstName);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    int result = sqlCommand.ExecuteNonQuery();
                    //if result is greater than 0 then record is inserted
                    if (result > 0)
                        return 1;
                    else
                        return 0;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
        }
        
        public ContactDetails ReadData(ContactDetails contactDetails)
        {
            contactDetails.firstName = "Hari";
            contactDetails.lastName = "Bala";
            contactDetails.address = "cross street";
            contactDetails.city = "Theni";
            contactDetails.state = "Tamil Nadu";
            contactDetails.zipCode = 600024;
            contactDetails.phoneNumber = 8796541230;
            contactDetails.emailAddress = "hari@gmail.com";
            return contactDetails;
        }
    }
}
