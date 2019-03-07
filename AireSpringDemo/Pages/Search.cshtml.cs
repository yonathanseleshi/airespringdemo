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
        
        //Getting a reference to the Database Context and the Repository
        private EmployeeDbContext _dbContext;
        private IEmployeesRepo _repo;
        
        
        
       
        //Initializing an IEnumerable of employees which is used to store the employees retrieved from the database
        IEnumerable<Employee> employees = new List<Employee>();
        
        
        
        //Binding the SearchString property to the search input
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
      
        
        //OnGetAsync is called upon loading the Search Page
        //All employees stored from the database are retrieved unless the Search box has contents
        //If the search box has input is bound to the SearchString variable and employees with a first name
        //matching the search string are retrieved
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