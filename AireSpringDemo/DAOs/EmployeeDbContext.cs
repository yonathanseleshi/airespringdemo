using System;
using AireSpringDemo.Models;
using Microsoft.EntityFrameworkCore;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace AireSpringDemo.DAOs
{
    
    //Establish the Database Context
    public class EmployeeDbContext : DbContext
    {
       
        
        
       //Setup an Employees Table
        public DbSet<Employee> Employees { get; set; }

      
      
        public EmployeeDbContext(DbContextOptions options)
            : base(options)
        {
            
        }
        
        /
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
        
       
        
    
     
        
       
        
    }
    
    
    
}