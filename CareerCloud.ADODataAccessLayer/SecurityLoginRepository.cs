﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using Microsoft.Extensions.Configuration;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginRepository : BaseADORepository<SecurityLoginPoco>, IDataRepository<SecurityLoginPoco>
    {
        public void Add(params SecurityLoginPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (SecurityLoginPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Security_Logins]
                                    ([Id]
                                    ,[Login]
                                    ,[Password]
                                    ,[Created_Date]
                                    ,[Password_Update_Date]
                                    ,[Agreement_Accepted_Date]
                                    ,[Is_Locked]
                                    ,[Is_Inactive]
                                    ,[Email_Address]
                                    ,[Phone_Number]
                                    ,[Full_Name]
                                    ,[Force_Change_Password]
                                    ,[Prefferred_Language])
                                    
                              VALUES
                                    (@Id
                                    ,@Login
                                    ,@Password
                                    ,@Created_Date
                                    ,@Password_Update_Date
                                    ,@Agreement_Accepted_Date
                                    ,@Is_Locked
                                    ,@Is_Inactive
                                    ,@Email_Address
                                    ,@Phone_Number
                                    ,@Full_Name
                                    ,@Force_Change_Password
                                    ,@Prefferred_Language)";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Login", item.Login);
                    cmd.Parameters.AddWithValue("@Password", item.Password);
                    cmd.Parameters.AddWithValue("@Created_Date", item.Created);
                    cmd.Parameters.AddWithValue("@Password_Update_Date", item.PasswordUpdate);
                    cmd.Parameters.AddWithValue("@Agreement_Accepted_Date", item.AgreementAccepted);
                    cmd.Parameters.AddWithValue("@Is_Locked", item.IsLocked);
                    cmd.Parameters.AddWithValue("@Is_Inactive", item.IsInactive);
                    cmd.Parameters.AddWithValue("@Email_Address", item.EmailAddress);
                    cmd.Parameters.AddWithValue("@Phone_Number", item.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Full_Name", item.FullName);
                    cmd.Parameters.AddWithValue("@Force_Change_Password", item.ForceChangePassword);
                    cmd.Parameters.AddWithValue("@Prefferred_Language", item.PrefferredLanguage);
                   
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }

            }
        }

        public override IList<SecurityLoginPoco> GetAll(params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT [Id]
                       ,[Login]
                                    ,[Password]
                                    ,[Created_Date]
                                    ,[Password_Update_Date]
                                    ,[Agreement_Accepted_Date]
                                    ,[Is_Locked]
                                    ,[Is_Inactive]
                                    ,[Email_Address]
                                    ,[Phone_Number]
                                    ,[Full_Name]
                                    ,[Force_Change_Password]
                                    ,[Prefferred_Language]
                       ,[Time_Stamp]
                  FROM [dbo].[Security_Logins]";

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                SecurityLoginPoco[] pocos = new SecurityLoginPoco[10000];
                int index = 0;
                while (reader.Read())
                {
                    SecurityLoginPoco poco = new SecurityLoginPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Login = reader.GetString(1);
                    poco.Password = reader.GetString(2);
                    poco.Created = reader.GetDateTime(3);
                    poco.PasswordUpdate = (reader.IsDBNull(4)) ? new DateTime() : reader.GetDateTime(4);
                    poco.AgreementAccepted = (reader.IsDBNull(5)) ? new DateTime() : reader.GetDateTime(5);
                    poco.IsLocked = reader.GetBoolean(6);
                    poco.IsInactive = reader.GetBoolean(7);
                    poco.EmailAddress = reader.GetString(8);
                    poco.PhoneNumber = (reader.IsDBNull(9)) ? String.Empty : reader.GetString(9);
                    poco.FullName = (reader.IsDBNull(10)) ? String.Empty : reader.GetString(10);
                    poco.ForceChangePassword = reader.GetBoolean(11);
                    poco.PrefferredLanguage = (reader.IsDBNull(12)) ? String.Empty : reader.GetString(12);
                    poco.TimeStamp = (byte[])reader[13];

                    pocos[index] = poco;
                    index++;
                }
                conn.Close();
                return pocos.Where(a => a != null).ToList();
            }

        }
        public void Update(params SecurityLoginPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (SecurityLoginPoco item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Security_Logins]
                       SET
                          [Login] = @Login
                          ,[Password] = @Password
                          ,[Created_Date] = @Created_Date
                          ,[Password_Update_Date] = @Password_Update_Date
                            ,[Agreement_Accepted_Date] = @Agreement_Accepted_Date
                                    ,[Is_Locked] = @Is_Locked
                                    ,[Is_Inactive] = @Is_Inactive
                                    ,[Email_Address] = @Email_Address
                                    ,[Phone_Number] = @Phone_Number
                                    ,[Full_Name] = @Full_Name
                                    ,[Force_Change_Password] = @Force_Change_Password
                                    ,[Prefferred_Language] = @Prefferred_Language
                      WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Login", item.Login);
                    cmd.Parameters.AddWithValue("@Password", item.Password);
                    cmd.Parameters.AddWithValue("@Created_Date", item.Created);
                    cmd.Parameters.AddWithValue("@Password_Update_Date", item.PasswordUpdate);
                    cmd.Parameters.AddWithValue("@Agreement_Accepted_Date", item.AgreementAccepted);
                    cmd.Parameters.AddWithValue("@Is_Locked", item.IsLocked);
                    cmd.Parameters.AddWithValue("@Is_Inactive", item.IsInactive);
                    cmd.Parameters.AddWithValue("@Email_Address", item.EmailAddress);
                    cmd.Parameters.AddWithValue("@Phone_Number", item.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Full_Name", item.FullName);
                    cmd.Parameters.AddWithValue("@Force_Change_Password", item.ForceChangePassword);
                    cmd.Parameters.AddWithValue("@Prefferred_Language", item.PrefferredLanguage);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

        }

    }
}
