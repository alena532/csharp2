using System;
using System.Collections.Generic;
namespace Files
{
    public class EmployeeComparer_Employee_:IComparer<Employee>
    {
        public EmployeeComparer_Employee_()
        {
        }

        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
