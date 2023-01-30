using System;
using System.Data.SqlClient;
using ApiDataAccess.General;
using ApiModel.User;
using ApiRepositories.User;
using Dapper;

namespace ApiDataAccess.User
{
    public class UserRepository : Repository<Users>, IUserRepository
    {
        public UserRepository(string connectionsString) : base(connectionsString)
        {
        }

        public Users ValidateUsername(string username)
        {
            var parameters = new DynamicParameters(new
            {
                p_username = username
            });
            string sql = "SELECT * FROM Users WHERE username = @p_username ";
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<Users>(
                    sql, parameters);
            }
        }
    }
}
