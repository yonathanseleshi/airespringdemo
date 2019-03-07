using System;
using AireSpringDemo.Models;
using Microsoft.EntityFrameworkCore;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace AireSpringDemo.DAOs
{
    public class EmployeeDbContext : DbContext
    {
       

        public DbSet<Employee> Employees { get; set; }

      
      
        public EmployeeDbContext(DbContextOptions options)
            : base(options)
        {
            
        }
        
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
        
       
        
    
     
        
       
        
    }
    
    
    
}