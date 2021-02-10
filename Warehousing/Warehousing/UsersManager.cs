using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing
{
    class UsersManager : OracleDatabaseConnection
    {
        public List<Users> Select()
        {
            List<Users> users = new List<Users>();

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT username, password FROM users";

            OracleConnection connection = getConnection();
            connection.Open();

            command.Connection = connection;

            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Users user = new Users();
                user.Username = reader["username"].ToString();
                user.Password = reader["password"].ToString();

                users.Add(user);
            }
            connection.Close();

            return users;
        }
        public int Insert(Users user)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO users VALUES(:username, :password)";

            OracleParameter insertUsername = new OracleParameter()
            {
                ParameterName = ":username",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = user.Username
            };
            command.Parameters.Add(insertUsername);

            OracleParameter insertPassword = new OracleParameter()
            {
                ParameterName = ":password",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = user.Password
            };
            command.Parameters.Add(insertPassword);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
        public int Delete(Users user)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM users WHERE username = :username";

            OracleParameter deleteUserByName = new OracleParameter();
            deleteUserByName.ParameterName = ":username";
            deleteUserByName.Direction = ParameterDirection.Input;
            deleteUserByName.DbType = DbType.String;
            deleteUserByName.Value = user.Username;

            command.Parameters.Add(deleteUserByName);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
    }
}
