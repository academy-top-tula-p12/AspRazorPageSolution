using AspRPFlightsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AspRPFlightsApp.Pages
{
    public class AirportModel : PageModel
    {
        FlightsAppContext context;

        public List<Airport> Airports { get; set; } = new();
        public AirportModel(FlightsAppContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Airports = context.Airports.Include(a => a.City).ToList();
        }
    }
}
