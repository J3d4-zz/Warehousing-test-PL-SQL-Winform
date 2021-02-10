using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing
{
    class Transactions
    {
        private int employee_id;
        public int EmployeeID
        {
            get { return employee_id; }
            set { employee_id = value; }
        }
        private int transaction_id;
        public int TransactionID
        {
            get { return transaction_id; }
            set { transaction_id = value; }
        }
        private int product_id;
        public int ProductID
        {
            get { return product_id; }
            set { product_id = value; }
        }
        public Transactions(int employee_id, int transaction_id, int product_id)
        {
            EmployeeID = employee_id;
            TransactionID = transaction_id;
            ProductID = product_id;
        }
        public Transactions()
        {

        }
        public override string ToString()
        {
            return string.Format("Seller's ID: {0}, Product: {1}", EmployeeID, ProductID);
        }
    }
}
