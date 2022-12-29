namespace DesignPatterns.Decorator
{
    public class EncryptedCloudStream : CloudStream
    {
        public override void Write(string data)
        {
            data = Encrypt(data);
            base.Write(data);
        }

        private string Encrypt(string data) => "$#fs#!$@#^&$%#";
    }
}