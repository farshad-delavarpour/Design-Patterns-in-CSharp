namespace DesignPatterns.Decorator
{
    public class EncryptedCloudStream : IStream
    {
        private IStream _stream;

        public EncryptedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            data = Encrypt(data);
            _stream.Write(data);
        }

        private string Encrypt(string data) => "$#fs#!$@#^&$%#";
    }
}