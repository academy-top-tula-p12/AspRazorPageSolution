using AspRPWelcomeApp.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRPWelcomeApp.Pages
{
    public class BindModel : PageModel
    {
        //[BindProperty]
        //public string Name { get; set; }

        //[BindProperty]
        //public int Age { get; set; }

        [BindProperty(SupportsGet = true)]
        public Person Person { get; set; }


        public void OnGet()
        {
        }
    }
}
