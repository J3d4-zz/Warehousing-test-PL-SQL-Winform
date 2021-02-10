using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing
{
    class ProductsManager : OracleDatabaseConnection
    {
        public List<Products> Select()
        {
            List<Products> products = new List<Products>();

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT product_id, warehouse_id, stock, product_name, description FROM products";

            OracleConnection connection = getConnection();
            connection.Open();

            command.Connection = connection;

            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Products product = new Products();
                product.ProductID = int.Parse(reader["product_id"].ToString());
                product.WarehouseID = int.Parse(reader["warehouse_id"].ToString());
                product.Stock = int.Parse(reader["stock"].ToString());
                product.ProductName = reader["product_name"].ToString();
                product.Description = reader["description"].ToString();

                products.Add(product);
            }
            connection.Close();

            return products;
        }
        public int Delete(Products product)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM products WHERE product_id = :product_id";

            OracleParameter deleteProductById = new OracleParameter();
            deleteProductById.ParameterName = ":product_id";
            deleteProductById.Direction = ParameterDirection.Input;
            deleteProductById.DbType = DbType.Int32;
            deleteProductById.Value = product.ProductID;

            command.Parameters.Add(deleteProductById);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
        public int Insert(Products product)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO products VALUES(:product_id, :warehouse_id, :stock, :product_name, :description)";

            OracleParameter insertProductId = new OracleParameter()
            {
                ParameterName = ":product_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = product.ProductID
            };
            command.Parameters.Add(insertProductId);

            OracleParameter insertWarehouseId = new OracleParameter()
            {
                ParameterName = ":warehouse_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = product.WarehouseID
            };
            command.Parameters.Add(insertWarehouseId);

            OracleParameter insertStock = new OracleParameter()
            {
                ParameterName = ":stock",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = product.Stock
            };
            command.Parameters.Add(insertStock);

            OracleParameter insertProductName = new OracleParameter()
            {
                ParameterName = ":product_name",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = product.ProductName
            };
            command.Parameters.Add(insertProductName);

            OracleParameter insertDescription = new OracleParameter()
            {
                ParameterName = ":description",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = product.Description
            };
            command.Parameters.Add(insertDescription);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
        public int Update(Products product)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE products SET warehouse_id = :warehouse_id, stock = :stock, product_name = :product_name, description = :description WHERE product_id = :product_id";

            OracleParameter updateProductId = new OracleParameter()
            {
                ParameterName = ":product_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = product.ProductID
            };
            command.Parameters.Add(updateProductId);

            OracleParameter updateWarehouseId = new OracleParameter()
            {
                ParameterName = ":warehouse_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = product.WarehouseID
            };
            command.Parameters.Add(updateWarehouseId);

            OracleParameter updateStock = new OracleParameter()
            {
                ParameterName = ":stock",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = product.Stock
            };
            command.Parameters.Add(updateStock);

            OracleParameter updateProductName = new OracleParameter()
            {
                ParameterName = ":product_name",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = product.ProductName
            };
            command.Parameters.Add(updateProductName);

            OracleParameter updateDescription = new OracleParameter()
            {
                ParameterName = ":description",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = product.Description
            };
            command.Parameters.Add(updateDescription);

            OracleConnection connection = getConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }

        // needs to be updated accordingly
        public bool CheckProductId(int product_id)
        {
            OracleConnection conn = getConnection();
            conn.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sf_checkProductId",
                Connection = conn
            };

            OracleParameter returnValue = new OracleParameter()
            {
                Direction = ParameterDirection.ReturnValue,
                DbType = DbType.Int32
            };
            command.Parameters.Add(returnValue);

            OracleParameter ProductIdParam = new OracleParameter()
            {
                ParameterName="inp_product_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = product_id
            };
            command.Parameters.Add(ProductIdParam);

            command.ExecuteNonQuery();

            conn.Close();
            return (int)returnValue.Value != 0;
        }
        public bool CheckWarehouseId(int warehouse_id)
        {
            OracleConnection conn = getConnection();
            conn.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sf_checkWarehouseId",
                Connection = conn
            };

            OracleParameter returnValue = new OracleParameter()
            {
                Direction = ParameterDirection.ReturnValue,
                DbType = DbType.Int32
            };
            command.Parameters.Add(returnValue);

            OracleParameter WarehouseIdParam = new OracleParameter()
            {
                ParameterName = "inp_warehouse_id",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = warehouse_id
            };
            command.Parameters.Add(WarehouseIdParam);

            command.ExecuteNonQuery();

            conn.Close();
            return (int)returnValue.Value != 0;
        }
    }
}
