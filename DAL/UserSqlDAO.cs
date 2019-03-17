using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AsanaBuilder.Models;

namespace AsanaBuilder.DAL
{
    public class UserSqlDAO : IUserDAO
    {
        public string ConnectionString { get; set; }
        public UserSqlDAO(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string username)
        {
            User user = new User();
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AsanaBuilder;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE email = @email", conn);
                    cmd.Parameters.AddWithValue("@email", username);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        user = ConvertReaderToUser(reader);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return user;
        }

        private User ConvertReaderToUser(SqlDataReader reader)
        {
            User user = new User();
            user.Email = Convert.ToString(reader["email"]);
            user.FirstName = Convert.ToString(reader["first_name"]);
            user.LastName = Convert.ToString(reader["last_name"]);
            user.Password = Convert.ToString(reader["pass"]);
            return user;
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
