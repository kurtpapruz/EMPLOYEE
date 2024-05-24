using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public string FirstName
        {
            get { return first_name;}
            set{ first_name = value; }
        }
        public string LastName
        {
            get{ return last_name;}
            set{ last_name = value;}
        }
        public string JobTitle
        {
            get{ return job_title;}
            set{ JobTitle = value;}
        }
        public string Department
        {
            get{ return department;}
            set{ department = value;}
        }
        public double BasicSalary
        {
            get { return basic_salary;}
            set { basic_salary = value; }
        }
        public PartTimeEmployee(string Fname, string Lname, string Dept, string job)
        {
            first_name = Fname;
            last_name = Lname;
            department = Dept;
            job_title = job;
        }
        public void ComputeSalary(int hoursPerWorked, double ratePerHour)
        {
           basic_salary = hoursPerWorked * ratePerHour;
        }
    }
}
