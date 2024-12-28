using AspRPWelcomeApp.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRPWelcomeApp.Pages
{
    public class EmployeeModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Input info";
        }

        //public void OnPost(Person person)
        //{
        //    Message = $"Info: {person.Name} {person.Age}";
        //}

        public void OnPost()
        {
            Person person = new Person();
            person.Name = Request.Form["name"];
            person.Age = Int32.Parse(Request.Form["age"]);

            Message = $"Info: {person.Name} {person.Age}";
        }
    }
}
