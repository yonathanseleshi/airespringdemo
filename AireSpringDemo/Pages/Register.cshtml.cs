using System;
using System.Threading.Tasks;
using AireSpringDemo.DAOs;
using AireSpringDemo.Models;
using AireSpringDemo.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AireSpringDemo.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly EmployeeDbContext _dbContext;

        private IEmployeesRepo _repo;

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
            
            

            EmployeeObj.EmployeeId = new Guid();
            await _repo.PostEmployee(EmployeeObj);
            return RedirectToPage("/Search");
        }
    }

}