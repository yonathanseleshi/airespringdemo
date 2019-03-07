using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AireSpringDemo.DAOs;
using AireSpringDemo.Models;
using AireSpringDemo.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AireSpringDemo.Pages
{
    public class SearchModel : PageModel
    {
        private EmployeeDbContext _dbContext;
        private IEmployeesRepo _repo;
        
        
        
       
       
        IEnumerable<Employee> employees = new List<Employee>();
        
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        

        public IEnumerable<Employee> Employees
        {
            get => employees;
            set => employees = value;
        }

        public SearchModel(EmployeeDbContext context, IEmployeesRepo repo)
        {
            this._dbContext = context;
            this._repo = repo;

        }
        
        
        [BindProperty]
        public Employee Employee{ get; set; }
      
        
        public async Task OnGetAsync()
        {
          
            employees = await _repo.GetAllEmployees();
            
           
            
            if (!string.IsNullOrEmpty(SearchString))
            {
                employees = employees.Where(s => s.FirstName.Contains(SearchString));
            }
            

          

            employees.OrderBy(o => o.HireDate);

        }
    }
}