using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using Microsoft.Extensions.Configuration;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyLocationRepository : BaseADORepository<CompanyLocationPoco>, IDataRepository<CompanyLocationPoco>
    {
        public void Add(params CompanyLocationPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (CompanyLocationPoco item in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Company_Locations]
                                    ([Id]
                                    ,[Company]
                                    ,[Country_Code]
                                    ,[State_Province_Code]
                                    ,[Street_Address]
                                    ,[City_Town]
                                    ,[Zip_Postal_Code])
                              VALUES
                                    (@Id
                                    ,@Company
                                     ,@Country_Code
                                    ,@State_Province_Code
                                     ,@Street_Address
                                     ,@City_Town
                                      ,@Zip_Postal_Code)";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Company", item.Company);
                    cmd.Parameters.AddWithValue("@Country_Code", item.CountryCode);
                    cmd.Parameters.AddWithValue("@State_Province_Code", item.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", item.Street);
                    cmd.Parameters.AddWithValue("@City_Town", item.City);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", item.PostalCode);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }

            }
        }

        public override IList<CompanyLocationPoco> GetAll(params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT [Id]
                       ,[Company]
                       ,[Country_Code]
                       ,[State_Province_Code]
                       ,[Street_Address]
                       ,[City_Town]
                       ,[Zip_Postal_Code]
                      ,[Time_Stamp]
                  FROM [dbo].[Company_Locations]";

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                CompanyLocationPoco[] pocos = new CompanyLocationPoco[10000];
                int index = 0;
                while (reader.Read())
                {
                    CompanyLocationPoco poco = new CompanyLocationPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Company = reader.GetGuid(1);
                    poco.CountryCode = (reader.IsDBNull(2)) ? String.Empty : reader.GetString(2);
                    poco.Province = (reader.IsDBNull(3)) ? String.Empty : reader.GetString(3);
                    poco.Street = (reader.IsDBNull(4)) ? String.Empty : reader.GetString(4);
                    poco.City = (reader.IsDBNull(5)) ? String.Empty : reader.GetString(5);
                    poco.PostalCode = (reader.IsDBNull(6)) ? String.Empty : reader.GetString(6); 
                    poco.TimeStamp = (byte[])reader[7];

                    pocos[index] = poco;
                    index++;
                }
                conn.Close();
                return pocos.Where(a => a != null).ToList();
            }

        }
        public void Update(params CompanyLocationPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (CompanyLocationPoco item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Locations]
                       SET
                          [Company] = @Company
                          ,[Country_Code] = @Country_Code
                          ,[State_Province_Code] = @State_Province_Code
                          ,[Street_Address] = @Street_Address
                            ,[City_Town] = @City_Town
                            ,[Zip_Postal_Code] = @Zip_Postal_Code
                     WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Company", item.Company);
                    cmd.Parameters.AddWithValue("@Country_Code", item.CountryCode);
                    cmd.Parameters.AddWithValue("@State_Province_Code", item.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", item.Street);
                    cmd.Parameters.AddWithValue("@City_Town", item.City);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", item.PostalCode);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

        }

    }
}
