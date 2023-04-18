﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaceDesign
{
    internal class FluentEmployee
    {
        private Employee employee = new Employee();
        public FluentEmployee NameOfEmployee(string fullName)
        {
            employee.FullName = fullName;
            return this;
        }
        public FluentEmployee EmployeeDateOfBirth(string dateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(dateOfBirth);
            return this;
        }
        public FluentEmployee EmployeeDeoartment(string department)
        {
            employee.Department = department;
            return this;
        }
        public FluentEmployee EmployeeAddress(string address)
        {
            employee.Address = address;
            return this;
        }

        public void ShowDetailsOfEmployee()
        {
            Console.WriteLine($"Name: {employee.FullName} - {employee.Department} - {employee.DateOfBirth} - {employee.Address}");
        }
    }
}
