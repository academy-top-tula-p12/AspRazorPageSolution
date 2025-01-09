using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRPAdvancedApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Category { get; set; }

        //public void OnGet(int id)
        //{
        //    //Id = RouteData.Values["id"];
        //    //Id = id;
        //}

        //public void OnGet(string category, int id)
        //{
        //    //Id = RouteData.Values["id"];
        //    //Category = RouteData.Values["category"];
        //    //Id = id;
        //    //Category = category;
        //}
    }
}
