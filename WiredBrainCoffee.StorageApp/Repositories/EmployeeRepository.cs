using System;
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class EmployeeRepository
    {
        private readonly List<Employee> _employees = new ();

        public void Add(Employee employee)
        {
            _employees.Add (employee);
        }

        public void Save()
        {
            foreach (Employee employee in _employees)
            {
                Console.WriteLine (employee);
            }
        }
    }
}
