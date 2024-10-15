using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal interface IEmployee
    {
         
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double BasicSalary { get; set; }

        public void ComputeSalary(int HoursWorked, double ratePerHour)
        {
            BasicSalary = ratePerHour * HoursWorked;
        }
    }
}
