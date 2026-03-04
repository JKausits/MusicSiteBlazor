namespace JoeKausitsMusic.Services
{
    public interface IImageService
    {
        public ICollection<ImageViewModel> Images { get; }
    }

    public class ImageService : IImageService
    {
        public ICollection<ImageViewModel> Images => new List<ImageViewModel>
        {
            new ("/imgs/20250614_183751.jpg"),
            new ("/imgs/20250829_174010.jpg"),
            new ("/imgs/20251017_183607(1).jpg"),
            new ("/imgs/20251107_195021.jpg"),
            new ("/imgs/DSC_0312.jpg"),
        };
    }
}
