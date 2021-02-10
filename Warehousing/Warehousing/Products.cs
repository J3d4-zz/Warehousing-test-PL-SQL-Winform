using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing
{
    class Products
    {
        private int product_id;
        public int ProductID
        {
            get { return product_id; }
            set { product_id = value; }
        }
        private int warehouse_id;
        public int WarehouseID
        {
            get { return warehouse_id; }
            set { warehouse_id = value; }
        }
        private int stock;
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        private string product_name;
        public string ProductName
        {
            get { return product_name; }
            set { product_name = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Products(int product_id, int warehouse_id, int stock, string product_name, string description)
        {
            ProductID = product_id;
            WarehouseID = warehouse_id;
            Stock = stock;
            ProductName = product_name;
            Description = description;
        }
        public Products()
        {

        }
        public override string ToString()
        {
            return string.Format("Product ID: {0}, Product Name: {1}, Description: {2}", ProductID, ProductName, Description);
        }
    }
}
