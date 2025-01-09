using AspRPFlightsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRPFlightsApp.Pages
{
    public class AirportCreateModel : PageModel
    {
        FlightsAppContext context;

        [BindProperty]
        public Airport Airport { get; set; } = new();
        public List<City> Cities { get; set; }
        public AirportCreateModel(FlightsAppContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Cities = context.Cities.ToList();
            Cities.Insert(0, new City() { Id = 0, Title = "" });
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Airport.CityId = (Airport.CityId == 0) ? null : Airport.CityId;
            context.Airports.Add(Airport);
            await context.SaveChangesAsync();
            return RedirectToPage("Airport");
        }
    }
}
