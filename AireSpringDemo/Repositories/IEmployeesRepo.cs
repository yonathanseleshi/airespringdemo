using System.Collections.Generic;
using System.Threading.Tasks;
using AireSpringDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AireSpringDemo.Repositories
{
    public interface IEmployeesRepo
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> PostEmployee(Employee employee);
        Task<Employee> FindEmployeeByFirstName(string name);
        Task<Employee> FindEmployeeByID(long id);
    }
}