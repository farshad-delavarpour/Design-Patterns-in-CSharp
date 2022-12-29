namespace DesignPatterns.Adapter
{
    public class ImageView
    {
        private Image _image;

        public ImageView(Image image)
        {
            _image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(_image);
        }
    }
}