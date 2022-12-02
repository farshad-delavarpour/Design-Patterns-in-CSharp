namespace DesignPatterns.Strategy
{
    public class ChatClient
    {
        private readonly IEncryptionAlgorithm _encryptionAlgorithm;

        public ChatClient(IEncryptionAlgorithm encryptionAlgorithm)
        {
            _encryptionAlgorithm = encryptionAlgorithm;
        }

        public void Send(string message)
        {
            System.Console.WriteLine(_encryptionAlgorithm.Encrypt(message));
        }
    }
}