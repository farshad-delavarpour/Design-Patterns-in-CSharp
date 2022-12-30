namespace DesignPatterns.Decorator
{
    public class CompressedCloudStream : IStream
    {
        private IStream _stream;

        public CompressedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            data = Compress(data);
            _stream.Write(data);
        }

        private string Compress(string data) => data.Substring(0, 3);
    }

}