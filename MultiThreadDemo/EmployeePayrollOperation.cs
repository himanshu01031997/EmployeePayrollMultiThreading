using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadDemo
{
    public class EmployeePayrollOperation
    {
        List<EmployeeDetails> employeeDetails=new List<EmployeeDetails>();
        public void AddEmployeeToPayroll(List<EmployeeDetails> listemp)
        {
            listemp.ForEach(empdata =>
            {
                Console.WriteLine("employee being added:" + empdata.EmployeeName);
                this.AddEmployeeToPayroll(empdata);
                Console.WriteLine("employee added:" + empdata.EmployeeName);
            });

        }

        private void AddEmployeeToPayroll(EmployeeDetails emp)
        {
            employeeDetails.Add(emp);
        }
    }
}
