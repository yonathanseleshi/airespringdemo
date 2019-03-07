using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AireSpringDemo.DAOs;
using AireSpringDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AireSpringDemo.Repositories
{
    public class EmployeesRepoImpl : IEmployeesRepo
    {
        
        
        private EmployeeDbContext _dbContext;

        public EmployeesRepoImpl(EmployeeDbContext context)
        {
            this._dbContext = context;

        }
        
        
        [BindProperty]
        public Employee Employee{ get; set; }
        
        
        public async Task<List<Employee>> GetAllEmployees()
        {
            List<Employee> employees = await _dbContext.Employees.ToListAsync();

            return employees;
        }

        public async Task<Employee> PostEmployee(Employee employee)
        {
            
            employee.EmployeeId = new Guid();

            try
            {
                _dbContext.Employees.Add(employee);
           
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            

            return employee;

        }

        public async Task<Employee> FindEmployeeByFirstName(string name)
        {
            Employee employee = await _dbContext.Employees.FindAsync(name);
            
            return employee;
        }

        public async Task<Employee> FindEmployeeByID(long id)
        {
            Employee employee = await _dbContext.Employees.FindAsync(id);

            return employee;
        }
    }
}