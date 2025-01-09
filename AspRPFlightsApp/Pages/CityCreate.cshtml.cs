using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AspRPFlightsApp.Models;

namespace AspRPFlightsApp.Pages
{
    public class CityCreateModel : PageModel
    {
        FlightsAppContext context;
        
        [BindProperty]
        public City City { get; set; } = new();

        public CityCreateModel(FlightsAppContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Cities.Add(City);
            await context.SaveChangesAsync();
            return RedirectToPage("City");
        }
    }
}
