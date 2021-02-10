using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehousing
{
    public partial class Form1 : Form
    {
        EmployeesManager em;
        ProductsManager pm;
        TransactionsManager tm;
        UsersManager um;
        public Form1()
        {
            InitializeComponent();
            em = new EmployeesManager();
            pm = new ProductsManager();
            tm = new TransactionsManager();
            um = new UsersManager();
            InitComboBoxEmployee();
            InitComboBoxProducts();
            InitComboBoxTransactions();
            InitComboBoxUsers();
            btn_userData.Visible = false;
            btn_logout.Visible = false;
            btn_userDelete.Visible = false;
            comboBox_users.Visible = false;
        }
        private void btn_insert_test_employees_Click(object sender, EventArgs e)
        {
            int count = (int)numeric_TestEmployees.Value;
            em.InsertTestEmployee(count);
            MessageBox.Show(count + " Test Employees succesfully added!");
        }
        private void InitComboBoxEmployee()
        {
            List<Employees> employees = em.Select();

            comboBox_employees.BeginUpdate();
            comboBox_employees.Items.Clear();

            foreach (Employees employee in employees)
            {
                comboBox_employees.Items.Add(employee);
            }
            comboBox_employees.EndUpdate();
        }
        private void InitComboBoxProducts()
        {
            List<Products> products = pm.Select();

            comboBox_products.BeginUpdate();
            comboBox_products.Items.Clear();

            foreach (Products product in products)
            {
                comboBox_products.Items.Add(product);
            }
            comboBox_products.EndUpdate();
        }
        private void InitComboBoxTransactions()
        {
            List<Transactions> transactions = tm.Select();

            comboBox_transactions.BeginUpdate();
            comboBox_transactions.Items.Clear();

            foreach (Transactions transaction in transactions)
            {
                comboBox_transactions.Items.Add(transaction);
            }
            comboBox_transactions.EndUpdate();
        }
        private void InitComboBoxUsers()
        {
            List<Users> users = um.Select();

            comboBox_users.BeginUpdate();
            comboBox_users.Items.Clear();
            foreach (Users user in users)
            {
                comboBox_users.Items.Add(user);
            }
            comboBox_users.EndUpdate();
        }
        private void btn_insert_employee_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees((int)numeric_employee_id.Value, tb_employee_name.Text, (int)numeric_birth_year_employee.Value, tb_address_employee.Text, tb_gender_employee.Text, tb_job_status_employee.Text);

            int result = em.Insert(employee);
            MessageBox.Show(result + " record inserted succesfully!");
            InitComboBoxEmployee();
        }
        private void btn_insert_transaction_Click(object sender, EventArgs e)
        {
            Transactions transaction = new Transactions((int)numeric_employee_id_transactions.Value, (int)numeric_transaction_id.Value, (int)numeric_product_id.Value);

            int result = tm.Insert(transaction);
            MessageBox.Show(result + " record inserted succesfully!");
            InitComboBoxTransactions();
        }
        private void btn_insert_products_Click(object sender, EventArgs e)
        {
            List<Products> prod = pm.Select();
            foreach (Products p in prod)
            {
                if (prod.Count > 0 && p.ProductID == (int)numeric_product_id_products.Value)
                {
                    MessageBox.Show("Product ID is already in use!");
                }
                else
                {
                    Products product = new Products((int)numeric_product_id_products.Value, (int)numeric_warehouse_id_products.Value, (int)numeric_stock.Value, tb_product_name.Text, tb_description.Text);
                    int result = pm.Insert(product);
                    MessageBox.Show(result + " record inserted succesfully!");
                    InitComboBoxProducts();
                }
            }
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            Users user = new Users(tb_username.Text, tb_password.Text);

            int result = um.Insert(user);
            MessageBox.Show(result + " user succesfully registered!");
            tb_username.Clear();
            tb_password.Clear();
        }
        private void btn_update_employee_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees((int)numeric_employee_id.Value, tb_employee_name.Text, (int)numeric_birth_year_employee.Value, tb_address_employee.Text, tb_gender_employee.Text, tb_job_status_employee.Text);

            int result = em.Update(employee);
            MessageBox.Show(result + " record updated succesfully!");
            InitComboBoxEmployee();
        }
        private void btn_update_transactions_Click(object sender, EventArgs e)
        {
            Transactions transaction = new Transactions((int)numeric_employee_id_transactions.Value, (int)numeric_transaction_id.Value, (int)numeric_product_id.Value);

            int result = tm.Update(transaction);
            MessageBox.Show(result + " record updated succesfully!");
            InitComboBoxTransactions();
        }
        private void btn_update_products_Click(object sender, EventArgs e)
        {
            Products product = new Products((int)numeric_product_id_products.Value, (int)numeric_warehouse_id_products.Value, (int)numeric_stock.Value, tb_product_name.Text, tb_description.Text);

            int result = pm.Update(product);
            MessageBox.Show(result + " record updated succesfully!");
            InitComboBoxProducts();
        }
        private void btn_delete_employees_Click(object sender, EventArgs e)
        {
            Employees employee = (Employees)comboBox_employees.SelectedItem;
            int count = em.Delete(employee);
            MessageBox.Show(count + " record deleted succesfully!");
            InitComboBoxEmployee();
        }
        private void btn_delete_transactions_Click(object sender, EventArgs e)
        {
            Transactions transaction = (Transactions)comboBox_transactions.SelectedItem;
            int count = tm.Delete(transaction);
            MessageBox.Show(count + " record deleted succesfully!");
            InitComboBoxTransactions();
        }
        private void btn_delete_products_Click(object sender, EventArgs e)
        {
            Products product = (Products)comboBox_products.SelectedItem;
            int count = pm.Delete(product);
            MessageBox.Show(count + " record deleted succesfully!");
            InitComboBoxProducts();
        }
        private void btn_delete_users_Click(object sender, EventArgs e)
        {
            Users user = (Users)comboBox_users.SelectedItem;
            int count = um.Delete(user);
            MessageBox.Show(count + " record deleted succesfully!");
        }
        private void btn_reload_employees_Click(object sender, EventArgs e)
        {
            InitComboBoxEmployee();
        }
        private void btn_reload_transactions_Click(object sender, EventArgs e)
        {
            InitComboBoxProducts();
        }
        private void btn_reload_products_Click(object sender, EventArgs e)
        {
            InitComboBoxTransactions();
        }
        private void comboBox_employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employees employee = (Employees)comboBox_employees.SelectedItem;
            numeric_employee_id.Value = int.Parse(employee.EmployeeID.ToString());
            tb_employee_name.Text = employee.EmployeeName.ToString();
            numeric_birth_year_employee.Value = int.Parse(employee.BirthYear.ToString());
            tb_address_employee.Text = employee.Address.ToString();
            tb_gender_employee.Text = employee.Gender.ToString();
            tb_job_status_employee.Text = employee.JobStatus.ToString();
        }
        private void comboBox_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            Products product = (Products)comboBox_products.SelectedItem;
            numeric_product_id_products.Value = int.Parse(product.ProductID.ToString());
            numeric_warehouse_id_products.Value = int.Parse(product.WarehouseID.ToString());
            numeric_stock.Value = int.Parse(product.Stock.ToString());
            tb_product_name.Text = product.ProductName.ToString();
            tb_description.Text = product.Description.ToString();
        }
        private void comboBox_transactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transactions transaction = (Transactions)comboBox_transactions.SelectedItem;
            numeric_employee_id_transactions.Value = int.Parse(transaction.EmployeeID.ToString());
            numeric_transaction_id.Value = int.Parse(transaction.TransactionID.ToString());
            numeric_product_id.Value = int.Parse(transaction.ProductID.ToString());

        }
        private void btn_validate_product_id_Click(object sender, EventArgs e)
        {
            if(pm.CheckProductId((int)numeric_product_id_products.Value))
            {
                MessageBox.Show("Product ID is Valid!");
            }
            else
            {
                MessageBox.Show("Product ID is not Valid!");
            }
        }
        private void btn_validate_warehouse_id_Click(object sender, EventArgs e)
        {
            if(pm.CheckWarehouseId((int)numeric_warehouse_id_products.Value))
            {
                MessageBox.Show("Warehouse ID is Valid!");
            }
            else
            {
                MessageBox.Show("Warehouse ID is not Valid!");
            }
        }
        private void btn_signin_Click(object sender, EventArgs e)
        {
            List<Users> users = um.Select();
            if(users.Count == 0)
            {
                MessageBox.Show("User not found!");
            }
            foreach (Users user in users)
            {
                if (tb_username.Text == user.Username && tb_password.Text == user.Password)
                {
                    btn_userData.Visible = true;
                    comboBox_users.Visible = true;
                    MessageBox.Show("Sign In Succesfull!");
                    tb_username.Clear();
                    tb_password.Clear();
                    btn_signin.Visible = false;
                    btn_logout.Visible = true;
                    btn_register.Visible = false;
                    btn_userDelete.Visible = true;
                    InitComboBoxUsers();
                    break;
                }
                else
                {
                    MessageBox.Show("Username of Password is not correct!");
                    break;
                }
            }
        }
        private void btn_list_users_Click(object sender, EventArgs e)
        {
            InitComboBoxUsers();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Succesfull!");
            btn_userData.Visible = false;
            comboBox_users.Visible = false;
            btn_signin.Visible = true;
            btn_register.Visible = true;
            btn_userDelete.Visible = false;
            btn_logout.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}