namespace JoeKausitsMusic.Services
{
    public interface IShowService
    {
        public ICollection<ShowViewModel> UpcomingShows { get; }

        public Task FetchUpcomingShows();
    }

    public class ShowService : IShowService
    {
        public ICollection<ShowViewModel> UpcomingShows { get; private set; } = [];

        public Task FetchUpcomingShows()
        {
            // TODO: Replace with DB Call.
            UpcomingShows = new List<ShowViewModel>()
            {
                new()
                {
                    StartAt = new DateTime(2026, 3, 18, 21, 0, 0),
                    EndAt = new DateTime(2026, 3, 19, 0, 0, 0),
                    Venue = new()
                    {
                        Name = "Sam's Wedge Inn"
                    }
                },
                new()
                {
                    StartAt = new DateTime(2026, 3, 20, 19, 30, 0),
                    EndAt = new DateTime(2026, 3, 20, 22, 30, 0),
                    Venue = new()
                    {
                        Name = "Jimmy Neno's"
                    }
                },
                new()
                {
                    StartAt = new DateTime(2026, 3, 27, 19, 30, 0),
                    EndAt = new DateTime(2026, 3, 27, 22, 30, 0),
                    Venue = new()
                    {
                        Name = "Gorant Dessert Bar"
                    }
                },
            }
            .Where(x => x.EndAt >= DateTime.Now)
            .ToList();

            return Task.CompletedTask;
        }
    }
}
