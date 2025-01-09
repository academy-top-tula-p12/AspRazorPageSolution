using AspRPAdvancedApp.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRPAdvancedApp.Pages
{
    public class EmplModel : PageModel
    {
        List<Employee> employees = new()
        {
            new(){ Id = 1, Name = "Sammy", Age = 25 },
            new(){ Id = 2, Name = "Tommy", Age = 41 },
            new(){ Id = 3, Name = "Bobby", Age = 32 },
        };

        public List<Employee> EmployeesViews { get; set; } = new();
        public void OnGet()
        {
            EmployeesViews = employees;
        }

        public void OnGetByName()
        {
            EmployeesViews = employees.OrderBy(e => e.Name).ToList();
        }

        public void OnGetByAge()
        {
            EmployeesViews = employees.OrderBy(e => e.Age).ToList();
        }

        public IActionResult OnPost()
        {
            Employee employee = new();
            employee.Id = employees.Max(e => e.Id) + 1;
            employee.Name = Request.Form["Name"];
            employee.Age = Int32.Parse(Request.Form["Age"]);

            employees.Add(employee);

            return Redirect("");
        }
    }
}
