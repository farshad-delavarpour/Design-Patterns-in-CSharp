namespace DesignPatterns.Adapter
{
    public class Image
    {

    }

    public interface Filter
    {
        void Apply(Image image);
    }

    public class VividFilter : Filter
    {
        public void Apply(Image image)
        {
            System.Console.WriteLine("Vivid Filter Applied.");
        }
    }

    public class ImageView
    {
        private Image _image;

        public ImageView(Image image)
        {
            _image = image;
        }

        public void Apply(Filter filter)
        {
            filter.Apply(_image);
        }
    }
}