namespace JoeKausitsMusic.Services
{
    public interface IVideoService
    {
        public ICollection<VideoViewModel> HomePageVideos { get; }
    }

    public class VideoService : IVideoService
    {
        public ICollection<VideoViewModel> HomePageVideos => new List<VideoViewModel>()
        {
            new("https://youtube.com/embed/ytrj0bQ8_zc?si=r4OjOSpINNNkEKt6", "Thomas Rhett", "Die a Happy Man"),
            new("https://youtube.com/embed/dfNFVZbQzDM?si=3fdrH9y8Rqv4L7uW", "George Strait", "Check Yes or No"),
            new("https://www.youtube.com/embed/5Mrg3gF6iSY", "Matt Stell", "Everywhere But On"),
            new("https://www.youtube.com/embed/MQaT2aIlXZE", "Easton Corbin", "Lovin' You is Fun")
        };
    }
}
