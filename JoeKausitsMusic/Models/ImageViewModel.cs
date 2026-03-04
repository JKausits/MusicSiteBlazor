namespace JoeKausitsMusic.Models
{
    public class ImageViewModel
    {
        public string Url { get; set; }

        public ImageViewModel(string url)
        {
            this.Url = url;
        }
    }
}
