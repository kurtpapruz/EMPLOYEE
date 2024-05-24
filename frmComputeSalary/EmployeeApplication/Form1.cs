using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

      
        private void ComputeButton_Click(object sender, EventArgs e)
        {
            PartTimeEmployee pte = new PartTimeEmployee(FnameBox.Text, LNameBox.Text, DepBox.Text, JobBox.Text);
            pte.ComputeSalary(Convert.ToInt32(TotalWorkedBox.Text), Convert.ToDouble(RateBox.Text));


            Result.Text = "First Name: " + pte.FirstName + "\nLast Name : " + pte.LastName + "\nJob Title : " + pte.JobTitle + " \nBasic Salary: " + Convert.ToString(pte.BasicSalary);
            
        }
    }
}
