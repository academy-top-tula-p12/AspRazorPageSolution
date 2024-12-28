using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRPWelcomeApp.Pages
{
    public class AboutModel : PageModel
    {
        HttpContext context;
        public HttpRequest MyRequest;

        public string Name { get; set; }
        public int Age { get; set; }

        public AboutModel()
        {
            context = PageContext.HttpContext;
            //MyRequest = context.Request;
        }
        //public void OnGet(string name, int age)
        //{
        //    Name = name;
        //    Age = age;
        //}

        public void OnGet()
        {
            Name = Request.Query["name"];
            Age = Int32.Parse(Request.Query["age"]);
        }
    }
}
