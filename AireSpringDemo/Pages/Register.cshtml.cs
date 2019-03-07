using System;
using System.Threading.Tasks;
using AireSpringDemo.DAOs;
using AireSpringDemo.Models;
using AireSpringDemo.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AireSpringDemo.Pages
{
    public class RegisterModel : PageModel
    {
        
        //Get a reference to the Database
        private readonly EmployeeDbContext _dbContext;

        //Getting a reference to the Repository of Database methods
        private IEmployeesRepo _repo;

        
        //Binding the EmployeeObj to the the Registration Form
        [BindProperty]
        public Employee EmployeeObj{ get; set; }
        
        public RegisterModel(EmployeeDbContext context, IEmployeesRepo repo)
        {
            this._repo = repo;

            this._dbContext = context;
        }

        public void OnGet()
        {

        }
        
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            

            //Assigning a globally unique id to the Employee 
            EmployeeObj.EmployeeId = new Guid();
            
            //Retrieve the Hire Year, Hire Month, and Hire Day and assign to the Hire Date property
           DateTime hireDate = new DateTime(EmployeeObj.HireYear, EmployeeObj.HireMonth, EmployeeObj.HireDay);
           
            EmployeeObj.HireDate = hireDate;
               
            
            //Call the repository PostEmployee method and pass the Employee object created by the form
            await _repo.PostEmployee(EmployeeObj);
            
            //Redirect to the Employee Search page
            return RedirectToPage("/Search");
        }
    }

}