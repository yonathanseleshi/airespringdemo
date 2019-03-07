using System;
using AireSpringDemo.Models;
using Microsoft.EntityFrameworkCore;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace AireSpringDemo.DAOs
{
    public class EmployeeDbContext : DbContext
    {
        
        public static string GetDBConnectionString()
        {
 

            // Using UsWest2
            var ssmClient = new AmazonSimpleSystemsManagementClient(Amazon.RegionEndpoint.USWest2);

        
            var response = ssmClient.GetParameterAsync(new GetParameterRequest
            {
                Name = "airespringendpoint",
                WithDecryption = true
            });

            return response.Result.Parameter.ToString();
        }
        
        
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(GetDBConnectionString());
        
     
        
       
        
    }
    
    
    
}