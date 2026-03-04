namespace JoeKausitsMusic.Models
{
    public class ShowViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public decimal Rate { get; set; }
        public VenueViewModel Venue { get; set; } = null!;
    }
}
