using MultiThreadDemo;

namespace MultiThreadDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenEmployeeAddedtotest()
        {
            List<EmployeeDetails> empdetails = new List<EmployeeDetails>();
            {
                empdetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "himanshu", "7898323", "manager"));
                empdetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "sam", "7898323", "hr"));
                empdetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "bruce", "7898323", "tech"));
                empdetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "joe", "7898323", "account"));
                empdetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "singham", "7898323", "cleaning"));

                EmployeePayrollOperation employeepayroll = new EmployeePayrollOperation();
                //employeepayroll.AddEmployeeToPayroll(empdetails);
                employeepayroll.addEmployeeToPayrollThread(empdetails);

            }


        }
    }
}