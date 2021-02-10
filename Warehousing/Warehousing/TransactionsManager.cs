using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing
{
    class TransactionsManager : OracleDatabaseConnection
    {
        public List<Transactions> Select()
        {
            List<Transactions> transactions = new List<Transactions>();

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT product_id, transaction_id, employee_id FROM transactions";

            OracleConnection connection = getConnection();
            connection.Open();

            command.Connection = connection;

            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Transactions transaction = new Transactions();
                transaction.ProductID = int.Parse(reader["product_id"].ToString());
                transaction.TransactionID = int.Parse(reader["transaction_id"].ToString());
                transaction.EmployeeID = int.Parse(reader["employee_id"].ToString());

                transactions.Add(transaction);
            }
            connection.Close();
            return transactions;
        }
        public int Delete(Transactions transaction)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM transactions WHERE product_id = :product_id";

            OracleParameter deleteTransactionByProductId = new OracleParameter();
            deleteTransactionByProductId.ParameterName = ":product_id";
            deleteTransactionByProductId.Direction = ParameterDirection.Input;
            deleteTransactionByProductId.DbType = DbType.Int32;
            deleteTransactionByProductId.Value = transaction.ProductID;

            command.Parameters.Add(deleteTransactionByProductId);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
        public int Insert(Transactions transaction)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO transactions VALUES(:product_id, :transaction_id, :employee_id)";

            OracleParameter insertProductId = new OracleParameter()
            {
                ParameterName = ":product_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = transaction.ProductID
            };
            command.Parameters.Add(insertProductId);

            OracleParameter insertTransactionId = new OracleParameter()
            {
                ParameterName = ":transaction_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = transaction.TransactionID
            };
            command.Parameters.Add(insertTransactionId);

            OracleParameter insertEmployeeId = new OracleParameter()
            {
                ParameterName = ":employee_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = transaction.EmployeeID
            };
            command.Parameters.Add(insertEmployeeId);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
        public int Update(Transactions transaction)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE transactions SET transaction_id = :transaction_id, employee_id = :employee_id WHERE product_id = :product_id";

            OracleParameter updateTransactionId = new OracleParameter()
            {
                ParameterName = ":transaction_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = transaction.TransactionID
            };
            command.Parameters.Add(updateTransactionId);

            OracleParameter updateEmployeeId = new OracleParameter()
            {
                ParameterName = ":emploee_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = transaction.EmployeeID
            };
            command.Parameters.Add(updateEmployeeId);

            OracleParameter updateProductId = new OracleParameter()
            {
                ParameterName = ":product_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = transaction.ProductID
            };
            command.Parameters.Add(updateProductId);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
    }
}
