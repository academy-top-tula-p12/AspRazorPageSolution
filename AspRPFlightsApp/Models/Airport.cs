namespace AspRPFlightsApp.Models
{
    public class Airport
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public int? CityId { get; set; }
        public City? City { get; set; }
    }
}
