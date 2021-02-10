
namespace Warehousing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_employees = new System.Windows.Forms.ComboBox();
            this.btn_employees_reload = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_nev = new System.Windows.Forms.Label();
            this.lb_szuletesiEv = new System.Windows.Forms.Label();
            this.lb_cim = new System.Windows.Forms.Label();
            this.lb_nem = new System.Windows.Forms.Label();
            this.lb_beosztas = new System.Windows.Forms.Label();
            this.numeric_employee_id = new System.Windows.Forms.NumericUpDown();
            this.tb_employee_name = new System.Windows.Forms.TextBox();
            this.tb_address_employee = new System.Windows.Forms.TextBox();
            this.tb_gender_employee = new System.Windows.Forms.TextBox();
            this.tb_job_status_employee = new System.Windows.Forms.TextBox();
            this.btn_insert_employee = new System.Windows.Forms.Button();
            this.btn_reload_employees = new System.Windows.Forms.Button();
            this.btn_delete_employees = new System.Windows.Forms.Button();
            this.numeric_TestEmployees = new System.Windows.Forms.NumericUpDown();
            this.btn_generate_employees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_products = new System.Windows.Forms.ComboBox();
            this.btn_products_reload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_product_name = new System.Windows.Forms.TextBox();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.btn_insert_products = new System.Windows.Forms.Button();
            this.btn_reload_products = new System.Windows.Forms.Button();
            this.btn_delete_products = new System.Windows.Forms.Button();
            this.btn_validate_product_id = new System.Windows.Forms.Button();
            this.btn_validate_warehouse_id = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_transactions = new System.Windows.Forms.ComboBox();
            this.btn_transactions_reload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numeric_employee_id_transactions = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_insert_transactions = new System.Windows.Forms.Button();
            this.btn_reload_transactions = new System.Windows.Forms.Button();
            this.btn_delete_transactions = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_signin = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_userData = new System.Windows.Forms.Button();
            this.btn_userDelete = new System.Windows.Forms.Button();
            this.comboBox_users = new System.Windows.Forms.ComboBox();
            this.numeric_birth_year_employee = new System.Windows.Forms.NumericUpDown();
            this.numeric_transaction_id = new System.Windows.Forms.NumericUpDown();
            this.numeric_product_id = new System.Windows.Forms.NumericUpDown();
            this.numeric_stock = new System.Windows.Forms.NumericUpDown();
            this.numeric_warehouse_id_products = new System.Windows.Forms.NumericUpDown();
            this.numeric_product_id_products = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_employee_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_TestEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_employee_id_transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_birth_year_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_transaction_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_product_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_warehouse_id_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_product_id_products)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_employees
            // 
            this.comboBox_employees.FormattingEnabled = true;
            this.comboBox_employees.Location = new System.Drawing.Point(41, 34);
            this.comboBox_employees.Name = "comboBox_employees";
            this.comboBox_employees.Size = new System.Drawing.Size(286, 21);
            this.comboBox_employees.TabIndex = 0;
            this.comboBox_employees.SelectedIndexChanged += new System.EventHandler(this.comboBox_employees_SelectedIndexChanged);
            // 
            // btn_employees_reload
            // 
            this.btn_employees_reload.Location = new System.Drawing.Point(41, 61);
            this.btn_employees_reload.Name = "btn_employees_reload";
            this.btn_employees_reload.Size = new System.Drawing.Size(137, 23);
            this.btn_employees_reload.TabIndex = 1;
            this.btn_employees_reload.Text = "Reload";
            this.btn_employees_reload.UseVisualStyleBackColor = true;
            this.btn_employees_reload.Click += new System.EventHandler(this.btn_reload_employees_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(42, 128);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(70, 13);
            this.lb_id.TabIndex = 2;
            this.lb_id.Text = "Employee ID:";
            // 
            // lb_nev
            // 
            this.lb_nev.AutoSize = true;
            this.lb_nev.Location = new System.Drawing.Point(42, 156);
            this.lb_nev.Name = "lb_nev";
            this.lb_nev.Size = new System.Drawing.Size(38, 13);
            this.lb_nev.TabIndex = 3;
            this.lb_nev.Text = "Name:";
            // 
            // lb_szuletesiEv
            // 
            this.lb_szuletesiEv.AutoSize = true;
            this.lb_szuletesiEv.Location = new System.Drawing.Point(42, 183);
            this.lb_szuletesiEv.Name = "lb_szuletesiEv";
            this.lb_szuletesiEv.Size = new System.Drawing.Size(68, 13);
            this.lb_szuletesiEv.TabIndex = 4;
            this.lb_szuletesiEv.Text = "Year of Birth:";
            // 
            // lb_cim
            // 
            this.lb_cim.AutoSize = true;
            this.lb_cim.Location = new System.Drawing.Point(42, 208);
            this.lb_cim.Name = "lb_cim";
            this.lb_cim.Size = new System.Drawing.Size(48, 13);
            this.lb_cim.TabIndex = 5;
            this.lb_cim.Text = "Address:";
            // 
            // lb_nem
            // 
            this.lb_nem.AutoSize = true;
            this.lb_nem.Location = new System.Drawing.Point(42, 234);
            this.lb_nem.Name = "lb_nem";
            this.lb_nem.Size = new System.Drawing.Size(45, 13);
            this.lb_nem.TabIndex = 6;
            this.lb_nem.Text = "Gender:";
            // 
            // lb_beosztas
            // 
            this.lb_beosztas.AutoSize = true;
            this.lb_beosztas.Location = new System.Drawing.Point(42, 260);
            this.lb_beosztas.Name = "lb_beosztas";
            this.lb_beosztas.Size = new System.Drawing.Size(60, 13);
            this.lb_beosztas.TabIndex = 7;
            this.lb_beosztas.Text = "Job Status:";
            // 
            // numeric_employee_id
            // 
            this.numeric_employee_id.Location = new System.Drawing.Point(207, 126);
            this.numeric_employee_id.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numeric_employee_id.Name = "numeric_employee_id";
            this.numeric_employee_id.Size = new System.Drawing.Size(120, 20);
            this.numeric_employee_id.TabIndex = 8;
            // 
            // tb_employee_name
            // 
            this.tb_employee_name.Location = new System.Drawing.Point(207, 153);
            this.tb_employee_name.Name = "tb_employee_name";
            this.tb_employee_name.Size = new System.Drawing.Size(120, 20);
            this.tb_employee_name.TabIndex = 9;
            // 
            // tb_address_employee
            // 
            this.tb_address_employee.Location = new System.Drawing.Point(207, 205);
            this.tb_address_employee.Name = "tb_address_employee";
            this.tb_address_employee.Size = new System.Drawing.Size(120, 20);
            this.tb_address_employee.TabIndex = 11;
            // 
            // tb_gender_employee
            // 
            this.tb_gender_employee.Location = new System.Drawing.Point(207, 231);
            this.tb_gender_employee.Name = "tb_gender_employee";
            this.tb_gender_employee.Size = new System.Drawing.Size(120, 20);
            this.tb_gender_employee.TabIndex = 12;
            // 
            // tb_job_status_employee
            // 
            this.tb_job_status_employee.Location = new System.Drawing.Point(207, 257);
            this.tb_job_status_employee.Name = "tb_job_status_employee";
            this.tb_job_status_employee.Size = new System.Drawing.Size(120, 20);
            this.tb_job_status_employee.TabIndex = 13;
            // 
            // btn_insert_employee
            // 
            this.btn_insert_employee.Location = new System.Drawing.Point(187, 283);
            this.btn_insert_employee.Name = "btn_insert_employee";
            this.btn_insert_employee.Size = new System.Drawing.Size(140, 23);
            this.btn_insert_employee.TabIndex = 14;
            this.btn_insert_employee.Text = "Insert";
            this.btn_insert_employee.UseVisualStyleBackColor = true;
            this.btn_insert_employee.Click += new System.EventHandler(this.btn_insert_employee_Click);
            // 
            // btn_reload_employees
            // 
            this.btn_reload_employees.Location = new System.Drawing.Point(44, 283);
            this.btn_reload_employees.Name = "btn_reload_employees";
            this.btn_reload_employees.Size = new System.Drawing.Size(137, 23);
            this.btn_reload_employees.TabIndex = 15;
            this.btn_reload_employees.Text = "Update";
            this.btn_reload_employees.UseVisualStyleBackColor = true;
            this.btn_reload_employees.Click += new System.EventHandler(this.btn_update_employee_Click);
            // 
            // btn_delete_employees
            // 
            this.btn_delete_employees.Location = new System.Drawing.Point(184, 61);
            this.btn_delete_employees.Name = "btn_delete_employees";
            this.btn_delete_employees.Size = new System.Drawing.Size(143, 23);
            this.btn_delete_employees.TabIndex = 16;
            this.btn_delete_employees.Text = "Delete";
            this.btn_delete_employees.UseVisualStyleBackColor = true;
            this.btn_delete_employees.Click += new System.EventHandler(this.btn_delete_employees_Click);
            // 
            // numeric_TestEmployees
            // 
            this.numeric_TestEmployees.Location = new System.Drawing.Point(41, 90);
            this.numeric_TestEmployees.Name = "numeric_TestEmployees";
            this.numeric_TestEmployees.Size = new System.Drawing.Size(160, 20);
            this.numeric_TestEmployees.TabIndex = 17;
            // 
            // btn_generate_employees
            // 
            this.btn_generate_employees.Location = new System.Drawing.Point(207, 90);
            this.btn_generate_employees.Name = "btn_generate_employees";
            this.btn_generate_employees.Size = new System.Drawing.Size(120, 20);
            this.btn_generate_employees.TabIndex = 18;
            this.btn_generate_employees.Text = "Generate";
            this.btn_generate_employees.UseVisualStyleBackColor = true;
            this.btn_generate_employees.Click += new System.EventHandler(this.btn_insert_test_employees_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Employees";
            // 
            // comboBox_products
            // 
            this.comboBox_products.FormattingEnabled = true;
            this.comboBox_products.Location = new System.Drawing.Point(676, 34);
            this.comboBox_products.Name = "comboBox_products";
            this.comboBox_products.Size = new System.Drawing.Size(288, 21);
            this.comboBox_products.TabIndex = 20;
            this.comboBox_products.SelectedIndexChanged += new System.EventHandler(this.comboBox_products_SelectedIndexChanged);
            // 
            // btn_products_reload
            // 
            this.btn_products_reload.Location = new System.Drawing.Point(676, 61);
            this.btn_products_reload.Name = "btn_products_reload";
            this.btn_products_reload.Size = new System.Drawing.Size(134, 23);
            this.btn_products_reload.TabIndex = 21;
            this.btn_products_reload.Text = "Reload";
            this.btn_products_reload.UseVisualStyleBackColor = true;
            this.btn_products_reload.Click += new System.EventHandler(this.btn_reload_transactions_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Warehouse ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Product Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(674, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Description:";
            // 
            // tb_product_name
            // 
            this.tb_product_name.Location = new System.Drawing.Point(816, 201);
            this.tb_product_name.Name = "tb_product_name";
            this.tb_product_name.Size = new System.Drawing.Size(149, 20);
            this.tb_product_name.TabIndex = 31;
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(816, 227);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(149, 20);
            this.tb_description.TabIndex = 32;
            // 
            // btn_insert_products
            // 
            this.btn_insert_products.Location = new System.Drawing.Point(816, 283);
            this.btn_insert_products.Name = "btn_insert_products";
            this.btn_insert_products.Size = new System.Drawing.Size(148, 23);
            this.btn_insert_products.TabIndex = 33;
            this.btn_insert_products.Text = "Insert";
            this.btn_insert_products.UseVisualStyleBackColor = true;
            this.btn_insert_products.Click += new System.EventHandler(this.btn_insert_products_Click);
            // 
            // btn_reload_products
            // 
            this.btn_reload_products.Location = new System.Drawing.Point(676, 283);
            this.btn_reload_products.Name = "btn_reload_products";
            this.btn_reload_products.Size = new System.Drawing.Size(135, 23);
            this.btn_reload_products.TabIndex = 34;
            this.btn_reload_products.Text = "Update";
            this.btn_reload_products.UseVisualStyleBackColor = true;
            this.btn_reload_products.Click += new System.EventHandler(this.btn_update_products_Click);
            // 
            // btn_delete_products
            // 
            this.btn_delete_products.Location = new System.Drawing.Point(816, 61);
            this.btn_delete_products.Name = "btn_delete_products";
            this.btn_delete_products.Size = new System.Drawing.Size(149, 23);
            this.btn_delete_products.TabIndex = 35;
            this.btn_delete_products.Text = "Delete";
            this.btn_delete_products.UseVisualStyleBackColor = true;
            this.btn_delete_products.Click += new System.EventHandler(this.btn_delete_products_Click);
            // 
            // btn_validate_product_id
            // 
            this.btn_validate_product_id.Location = new System.Drawing.Point(676, 254);
            this.btn_validate_product_id.Name = "btn_validate_product_id";
            this.btn_validate_product_id.Size = new System.Drawing.Size(134, 23);
            this.btn_validate_product_id.TabIndex = 36;
            this.btn_validate_product_id.Text = "Validate Product ID";
            this.btn_validate_product_id.UseVisualStyleBackColor = true;
            this.btn_validate_product_id.Click += new System.EventHandler(this.btn_validate_product_id_Click);
            // 
            // btn_validate_warehouse_id
            // 
            this.btn_validate_warehouse_id.Location = new System.Drawing.Point(816, 253);
            this.btn_validate_warehouse_id.Name = "btn_validate_warehouse_id";
            this.btn_validate_warehouse_id.Size = new System.Drawing.Size(148, 23);
            this.btn_validate_warehouse_id.TabIndex = 37;
            this.btn_validate_warehouse_id.Text = "Validate Warehouse ID";
            this.btn_validate_warehouse_id.UseVisualStyleBackColor = true;
            this.btn_validate_warehouse_id.Click += new System.EventHandler(this.btn_validate_warehouse_id_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Transactions";
            // 
            // comboBox_transactions
            // 
            this.comboBox_transactions.FormattingEnabled = true;
            this.comboBox_transactions.Location = new System.Drawing.Point(356, 34);
            this.comboBox_transactions.Name = "comboBox_transactions";
            this.comboBox_transactions.Size = new System.Drawing.Size(289, 21);
            this.comboBox_transactions.TabIndex = 39;
            this.comboBox_transactions.SelectedIndexChanged += new System.EventHandler(this.comboBox_transactions_SelectedIndexChanged);
            // 
            // btn_transactions_reload
            // 
            this.btn_transactions_reload.Location = new System.Drawing.Point(356, 61);
            this.btn_transactions_reload.Name = "btn_transactions_reload";
            this.btn_transactions_reload.Size = new System.Drawing.Size(141, 23);
            this.btn_transactions_reload.TabIndex = 40;
            this.btn_transactions_reload.Text = "Reload";
            this.btn_transactions_reload.UseVisualStyleBackColor = true;
            this.btn_transactions_reload.Click += new System.EventHandler(this.btn_reload_products_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Employee ID:";
            // 
            // numeric_employee_id_transactions
            // 
            this.numeric_employee_id_transactions.Location = new System.Drawing.Point(472, 123);
            this.numeric_employee_id_transactions.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numeric_employee_id_transactions.Name = "numeric_employee_id_transactions";
            this.numeric_employee_id_transactions.Size = new System.Drawing.Size(173, 20);
            this.numeric_employee_id_transactions.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Transaction ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(353, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Product ID:";
            // 
            // btn_insert_transactions
            // 
            this.btn_insert_transactions.Location = new System.Drawing.Point(503, 283);
            this.btn_insert_transactions.Name = "btn_insert_transactions";
            this.btn_insert_transactions.Size = new System.Drawing.Size(142, 23);
            this.btn_insert_transactions.TabIndex = 47;
            this.btn_insert_transactions.Text = "Insert";
            this.btn_insert_transactions.UseVisualStyleBackColor = true;
            this.btn_insert_transactions.Click += new System.EventHandler(this.btn_insert_transaction_Click);
            // 
            // btn_reload_transactions
            // 
            this.btn_reload_transactions.Location = new System.Drawing.Point(357, 283);
            this.btn_reload_transactions.Name = "btn_reload_transactions";
            this.btn_reload_transactions.Size = new System.Drawing.Size(140, 23);
            this.btn_reload_transactions.TabIndex = 48;
            this.btn_reload_transactions.Text = "Update";
            this.btn_reload_transactions.UseVisualStyleBackColor = true;
            this.btn_reload_transactions.Click += new System.EventHandler(this.btn_update_transactions_Click);
            // 
            // btn_delete_transactions
            // 
            this.btn_delete_transactions.Location = new System.Drawing.Point(503, 61);
            this.btn_delete_transactions.Name = "btn_delete_transactions";
            this.btn_delete_transactions.Size = new System.Drawing.Size(142, 23);
            this.btn_delete_transactions.TabIndex = 49;
            this.btn_delete_transactions.Text = "Delete";
            this.btn_delete_transactions.UseVisualStyleBackColor = true;
            this.btn_delete_transactions.Click += new System.EventHandler(this.btn_delete_transactions_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Username:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Password:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(106, 312);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(155, 20);
            this.tb_username.TabIndex = 53;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(333, 313);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(164, 20);
            this.tb_password.TabIndex = 54;
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(503, 312);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(110, 20);
            this.btn_signin.TabIndex = 55;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(619, 312);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(101, 20);
            this.btn_register.TabIndex = 56;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(503, 312);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(110, 20);
            this.btn_logout.TabIndex = 57;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_userData
            // 
            this.btn_userData.Location = new System.Drawing.Point(619, 312);
            this.btn_userData.Name = "btn_userData";
            this.btn_userData.Size = new System.Drawing.Size(101, 20);
            this.btn_userData.TabIndex = 59;
            this.btn_userData.Text = "List Users";
            this.btn_userData.UseVisualStyleBackColor = true;
            this.btn_userData.Click += new System.EventHandler(this.btn_list_users_Click);
            // 
            // btn_userDelete
            // 
            this.btn_userDelete.Location = new System.Drawing.Point(875, 312);
            this.btn_userDelete.Name = "btn_userDelete";
            this.btn_userDelete.Size = new System.Drawing.Size(90, 20);
            this.btn_userDelete.TabIndex = 62;
            this.btn_userDelete.Text = "Delete User";
            this.btn_userDelete.UseVisualStyleBackColor = true;
            this.btn_userDelete.Click += new System.EventHandler(this.btn_delete_users_Click);
            // 
            // comboBox_users
            // 
            this.comboBox_users.FormattingEnabled = true;
            this.comboBox_users.Location = new System.Drawing.Point(726, 312);
            this.comboBox_users.Name = "comboBox_users";
            this.comboBox_users.Size = new System.Drawing.Size(143, 21);
            this.comboBox_users.TabIndex = 63;
            // 
            // numeric_birth_year_employee
            // 
            this.numeric_birth_year_employee.Location = new System.Drawing.Point(207, 179);
            this.numeric_birth_year_employee.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numeric_birth_year_employee.Name = "numeric_birth_year_employee";
            this.numeric_birth_year_employee.Size = new System.Drawing.Size(120, 20);
            this.numeric_birth_year_employee.TabIndex = 64;
            // 
            // numeric_transaction_id
            // 
            this.numeric_transaction_id.Location = new System.Drawing.Point(472, 176);
            this.numeric_transaction_id.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numeric_transaction_id.Name = "numeric_transaction_id";
            this.numeric_transaction_id.Size = new System.Drawing.Size(173, 20);
            this.numeric_transaction_id.TabIndex = 65;
            // 
            // numeric_product_id
            // 
            this.numeric_product_id.Location = new System.Drawing.Point(472, 231);
            this.numeric_product_id.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numeric_product_id.Name = "numeric_product_id";
            this.numeric_product_id.Size = new System.Drawing.Size(173, 20);
            this.numeric_product_id.TabIndex = 66;
            // 
            // numeric_stock
            // 
            this.numeric_stock.Location = new System.Drawing.Point(816, 176);
            this.numeric_stock.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numeric_stock.Name = "numeric_stock";
            this.numeric_stock.Size = new System.Drawing.Size(149, 20);
            this.numeric_stock.TabIndex = 67;
            // 
            // numeric_warehouse_id_products
            // 
            this.numeric_warehouse_id_products.Location = new System.Drawing.Point(816, 149);
            this.numeric_warehouse_id_products.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numeric_warehouse_id_products.Name = "numeric_warehouse_id_products";
            this.numeric_warehouse_id_products.Size = new System.Drawing.Size(148, 20);
            this.numeric_warehouse_id_products.TabIndex = 68;
            // 
            // numeric_product_id_products
            // 
            this.numeric_product_id_products.Location = new System.Drawing.Point(816, 123);
            this.numeric_product_id_products.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numeric_product_id_products.Name = "numeric_product_id_products";
            this.numeric_product_id_products.Size = new System.Drawing.Size(148, 20);
            this.numeric_product_id_products.TabIndex = 69;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 363);
            this.Controls.Add(this.numeric_product_id_products);
            this.Controls.Add(this.numeric_warehouse_id_products);
            this.Controls.Add(this.numeric_stock);
            this.Controls.Add(this.numeric_product_id);
            this.Controls.Add(this.numeric_transaction_id);
            this.Controls.Add(this.numeric_birth_year_employee);
            this.Controls.Add(this.comboBox_users);
            this.Controls.Add(this.btn_userDelete);
            this.Controls.Add(this.btn_userData);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_delete_transactions);
            this.Controls.Add(this.btn_reload_transactions);
            this.Controls.Add(this.btn_insert_transactions);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numeric_employee_id_transactions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_transactions_reload);
            this.Controls.Add(this.comboBox_transactions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_validate_warehouse_id);
            this.Controls.Add(this.btn_validate_product_id);
            this.Controls.Add(this.btn_delete_products);
            this.Controls.Add(this.btn_reload_products);
            this.Controls.Add(this.btn_insert_products);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.tb_product_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_products_reload);
            this.Controls.Add(this.comboBox_products);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generate_employees);
            this.Controls.Add(this.numeric_TestEmployees);
            this.Controls.Add(this.btn_delete_employees);
            this.Controls.Add(this.btn_reload_employees);
            this.Controls.Add(this.btn_insert_employee);
            this.Controls.Add(this.tb_job_status_employee);
            this.Controls.Add(this.tb_gender_employee);
            this.Controls.Add(this.tb_address_employee);
            this.Controls.Add(this.tb_employee_name);
            this.Controls.Add(this.numeric_employee_id);
            this.Controls.Add(this.lb_beosztas);
            this.Controls.Add(this.lb_nem);
            this.Controls.Add(this.lb_cim);
            this.Controls.Add(this.lb_szuletesiEv);
            this.Controls.Add(this.lb_nev);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.btn_employees_reload);
            this.Controls.Add(this.comboBox_employees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_employee_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_TestEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_employee_id_transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_birth_year_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_transaction_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_product_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_warehouse_id_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_product_id_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_employees;
        private System.Windows.Forms.Button btn_employees_reload;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_nev;
        private System.Windows.Forms.Label lb_szuletesiEv;
        private System.Windows.Forms.Label lb_cim;
        private System.Windows.Forms.Label lb_nem;
        private System.Windows.Forms.Label lb_beosztas;
        private System.Windows.Forms.NumericUpDown numeric_employee_id;
        private System.Windows.Forms.TextBox tb_employee_name;
        private System.Windows.Forms.TextBox tb_address_employee;
        private System.Windows.Forms.TextBox tb_gender_employee;
        private System.Windows.Forms.TextBox tb_job_status_employee;
        private System.Windows.Forms.Button btn_insert_employee;
        private System.Windows.Forms.Button btn_reload_employees;
        private System.Windows.Forms.Button btn_delete_employees;
        private System.Windows.Forms.NumericUpDown numeric_TestEmployees;
        private System.Windows.Forms.Button btn_generate_employees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_products;
        private System.Windows.Forms.Button btn_products_reload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_product_name;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Button btn_insert_products;
        private System.Windows.Forms.Button btn_reload_products;
        private System.Windows.Forms.Button btn_delete_products;
        private System.Windows.Forms.Button btn_validate_product_id;
        private System.Windows.Forms.Button btn_validate_warehouse_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_transactions;
        private System.Windows.Forms.Button btn_transactions_reload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numeric_employee_id_transactions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_insert_transactions;
        private System.Windows.Forms.Button btn_reload_transactions;
        private System.Windows.Forms.Button btn_delete_transactions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_userData;
        private System.Windows.Forms.Button btn_userDelete;
        private System.Windows.Forms.ComboBox comboBox_users;
        private System.Windows.Forms.NumericUpDown numeric_birth_year_employee;
        private System.Windows.Forms.NumericUpDown numeric_transaction_id;
        private System.Windows.Forms.NumericUpDown numeric_product_id;
        private System.Windows.Forms.NumericUpDown numeric_stock;
        private System.Windows.Forms.NumericUpDown numeric_warehouse_id_products;
        private System.Windows.Forms.NumericUpDown numeric_product_id_products;
    }
}

