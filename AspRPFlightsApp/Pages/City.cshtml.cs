using AspRPFlightsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRPFlightsApp.Pages
{
    public class CityModel : PageModel
    {
        FlightsAppContext context;

        public List<City> Cities { get; set; } = new();

        public CityModel(FlightsAppContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Cities = context.Cities.ToList();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            City city = await context.Cities.FindAsync(id);

            if(city is not null)
            {
                context.Cities.Remove(city);
                await context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
