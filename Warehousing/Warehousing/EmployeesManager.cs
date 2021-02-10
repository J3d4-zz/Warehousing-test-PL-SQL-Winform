using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing
{
    class EmployeesManager : OracleDatabaseConnection
    {
        public List<Employees> Select()
        {
            List<Employees> employees = new List<Employees>();

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT employee_id, employee_name, birth_year, address, gender, job_status FROM employees";

            OracleConnection connection = getConnection();
            connection.Open();

            command.Connection = connection;

            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Employees employee = new Employees();
                employee.EmployeeID = int.Parse(reader["employee_id"].ToString());
                employee.EmployeeName = reader["employee_name"].ToString();
                employee.BirthYear = int.Parse(reader["birth_year"].ToString());
                employee.Address = reader["address"].ToString();
                employee.Gender = reader["gender"].ToString();
                employee.JobStatus = reader["job_status"].ToString();

                employees.Add(employee);
            }
            connection.Close();

            return employees;
        }
        public int Delete(Employees employee)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM employees WHERE employee_id = :employee_id";

            OracleParameter deleteEmployeeById = new OracleParameter();
            deleteEmployeeById.ParameterName = ":employee_id";
            deleteEmployeeById.Direction = ParameterDirection.Input;
            deleteEmployeeById.DbType = DbType.Int32;
            deleteEmployeeById.Value = employee.EmployeeID;

            command.Parameters.Add(deleteEmployeeById);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
        public int Insert(Employees employee)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO employees VALUES(:employee_id, :employee_name, :birth_year, :address, :gender, :job_status)";

            OracleParameter insertEmployeeId = new OracleParameter()
            {
                ParameterName = ":employee_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = employee.EmployeeID
            };
            command.Parameters.Add(insertEmployeeId);

            OracleParameter insertEmployeeName = new OracleParameter()
            {
                ParameterName = ":employee_name",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = employee.EmployeeName
            };
            command.Parameters.Add(insertEmployeeName);

            OracleParameter insertEmployeeBirthYear = new OracleParameter()
            {
                ParameterName = ":birth_year",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = employee.BirthYear
            };
            command.Parameters.Add(insertEmployeeBirthYear);

            OracleParameter insertEmployeeAddress = new OracleParameter()
            {
                ParameterName = ":address",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = employee.Address
            };
            command.Parameters.Add(insertEmployeeAddress);

            OracleParameter insertEmployeeGender = new OracleParameter()
            {
                ParameterName = ":gender",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = employee.Gender
            };
            command.Parameters.Add(insertEmployeeGender);

            OracleParameter insertEmployeeJobStatus = new OracleParameter()
            {
                ParameterName = ":job_status",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = employee.JobStatus
            };
            command.Parameters.Add(insertEmployeeJobStatus);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
        public int Update(Employees employee)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE employees SET employee_name = :employee_name, birth_year = :birth_year, address = :address, gender = :gender, job_status = :job_status WHERE employee_id = :employee_id";

            OracleParameter updateEmployeeName = new OracleParameter()
            {
                ParameterName = ":employee_name",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = employee.EmployeeName
            };
            command.Parameters.Add(updateEmployeeName);

            OracleParameter updateEmployeeBirthYear  = new OracleParameter()
            {
                ParameterName = ":birth_year",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = employee.BirthYear
            };
            command.Parameters.Add(updateEmployeeBirthYear);

            OracleParameter updateEmployeeAddress = new OracleParameter()
            {
                ParameterName = ":address",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = employee.Address
            };
            command.Parameters.Add(updateEmployeeAddress);

            OracleParameter updateEmployeeGender = new OracleParameter()
            {
                ParameterName = ":gender",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = employee.Gender
            };
            command.Parameters.Add(updateEmployeeGender);

            OracleParameter updateEmployeeJobStatus = new OracleParameter()
            {
                ParameterName = ":job_status",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = employee.JobStatus
            };
            command.Parameters.Add(updateEmployeeJobStatus);

            OracleParameter employeeId = new OracleParameter()
            {
                ParameterName = ":employee_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = employee.EmployeeID
            };
            command.Parameters.Add(employeeId);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
        public void InsertTestEmployee(int count)
        {
            OracleConnection conn = getConnection();
            conn.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "SP_INSERT_TESTEMPLOYEE",
                Connection = conn
            };

            OracleParameter countParam = new OracleParameter()
            {
                ParameterName = "p_Count",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = count
            };
            command.Parameters.Add(countParam);

            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
