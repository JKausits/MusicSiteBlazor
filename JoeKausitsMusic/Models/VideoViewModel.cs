namespace JoeKausitsMusic.Models
{
    public class VideoViewModel
    {
        public VideoViewModel(string url, string artist, string title)
        {
            Url = url;
            Artist = artist;
            Title = title;
        }

        public string Url { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
    }
}
