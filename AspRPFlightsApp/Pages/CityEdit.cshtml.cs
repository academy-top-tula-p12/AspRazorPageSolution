using AspRPFlightsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRPFlightsApp.Pages
{
    public class CityEditModel : PageModel
    {

        FlightsAppContext context;

        [BindProperty]
        public City? City { get; set; }

        public CityEditModel(FlightsAppContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            City = await context.Cities.FindAsync(id);
            if(City is null) return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            context.Cities.Update(City!);
            await context.SaveChangesAsync();
            return RedirectToPage("City");
        }
    }
}
