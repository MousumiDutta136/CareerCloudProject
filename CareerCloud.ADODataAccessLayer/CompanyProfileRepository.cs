using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using Microsoft.Extensions.Configuration;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyProfileRepository : BaseADORepository<CompanyProfilePoco>, IDataRepository<CompanyProfilePoco>
    {
        public void Add(params CompanyProfilePoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (CompanyProfilePoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Company_Profiles]
                                    ([Id]
                                    ,[Registration_Date]
                                    ,[Company_Website]
                                    ,[Contact_Phone]
                                    ,[Contact_Name]
                                    ,[Company_Logo])
                                    
                              VALUES
                                    (@Id
                                    ,@Registration_Date
                                     ,@Company_Website
                                    ,@Contact_Phone
                                     ,@Contact_Name
                                     ,@Company_Logo)";
                                   
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Registration_Date", item.RegistrationDate);
                    cmd.Parameters.AddWithValue("@Company_Website", item.CompanyWebsite);
                    cmd.Parameters.AddWithValue("@Contact_Phone", item.ContactPhone);
                    cmd.Parameters.AddWithValue("@Contact_Name", item.ContactName);
                    cmd.Parameters.AddWithValue("@Company_Logo", item.CompanyLogo);
                    

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }

            }
        }

        public override IList<CompanyProfilePoco> GetAll(params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT [Id]
                       ,[Registration_Date]
                       ,[Company_Website]
                       ,[Contact_Phone]
                       ,[Contact_Name]
                       ,[Company_Logo]
                       ,[Time_Stamp]
                  FROM [dbo].[Company_Profiles]";

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                CompanyProfilePoco[] pocos = new CompanyProfilePoco[10000];
                int index = 0;
                while (reader.Read())
                {
                    CompanyProfilePoco poco = new CompanyProfilePoco();
                    poco.Id = reader.GetGuid(0);
                    poco.RegistrationDate = reader.GetDateTime(1);
                    poco.CompanyWebsite = (reader.IsDBNull(2)) ? String.Empty : reader.GetString(2);
                    poco.ContactPhone = reader.GetString(3);
                    poco.ContactName = (reader.IsDBNull(4)) ? String.Empty : reader.GetString(4);
                    poco.CompanyLogo = (reader.IsDBNull(5)) ? Array.Empty<byte>() : (byte[])reader[5];
                    poco.TimeStamp = (byte[])reader[6];

                    pocos[index] = poco;
                    index++;
                }
                conn.Close();
                return pocos.Where(a => a != null).ToList();
            }

        }
        public void Update(params CompanyProfilePoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (CompanyProfilePoco item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Profiles]
                       SET
                          [Registration_Date] = @Registration_Date
                          ,[Company_Website] = @Company_Website
                          ,[Contact_Phone] = @Contact_Phone
                          ,[Contact_Name] = @Contact_Name
                            ,[Company_Logo] = @Company_Logo
                      WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Registration_Date", item.RegistrationDate);
                    cmd.Parameters.AddWithValue("@Company_Website", item.CompanyWebsite);
                    cmd.Parameters.AddWithValue("@Contact_Phone", item.ContactPhone);
                    cmd.Parameters.AddWithValue("@Contact_Name", item.ContactName);
                    cmd.Parameters.AddWithValue("@Company_Logo", item.CompanyLogo);
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

        }

    }
}
