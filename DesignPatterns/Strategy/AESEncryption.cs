namespace DesignPatterns.Strategy
{
    public class AESEncryption : IEncryptionAlgorithm
    {
        public string Encrypt(string text) => "AES Encryption";
    }
}