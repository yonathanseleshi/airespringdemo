using System.Threading.Tasks;
using AireSpringDemo.DAOs;
using AireSpringDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AireSpringDemo.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly EmployeeDbContext _dbContext;


        [BindProperty]
        public Employee Employee{ get; set; }
        
        public RegisterModel(EmployeeDbContext context)
        {

            _dbContext = context;
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

            _dbContext.Employees.Add(Employee);
            await _dbContext.SaveChangesAsync();
            return RedirectToPage("/Search");
        }
    }

}