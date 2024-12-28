using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRPWelcomeApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Title { get; set; }

        public IndexModel()
        {
            Title = "Index page";
        }

        public string DateNow() => DateTime.Now.ToLongDateString();
            

        public void OnGet()
        {

        }
    }
}
