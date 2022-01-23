using System;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepositoryWithRemove<Employee>();
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Anna" });
            employeeRepository.Add(new Employee { FirstName = "Thomas" });
            employeeRepository.Save();

            var organizationRepository = new GenericRepository<Organization>();
            organizationRepository.Add(new Organization { Name = "PluralSight" });
            organizationRepository.Add(new Organization { Name = "Mosadex" });
            organizationRepository.Save();

            Console.ReadLine();
        }
    }
}
