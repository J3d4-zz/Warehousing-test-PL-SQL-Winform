using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing
{
    class Employees
    {
        private int employee_id;
        public int EmployeeID
        {
            get { return employee_id; }
            set { employee_id = value; }
        }
        private string employee_name;
        public string EmployeeName
        {
            get { return employee_name; }
            set { employee_name = value; }
        }
        private int birth_year;
        public int BirthYear
        {
            get { return birth_year; }
            set { birth_year = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string job_status;
        public string JobStatus
        {
            get { return job_status; }
            set { job_status = value; }
        }
        public Employees(int employee_id, string employee_name, int birth_year, string address, string gender, string job_status)
        {
            EmployeeID = employee_id;
            EmployeeName = employee_name;
            BirthYear = birth_year;
            Address = address;
            Gender = gender;
            JobStatus = job_status;
        }
        public Employees() 
        { 

        }
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}", EmployeeID, EmployeeName);
        }
    }
}
