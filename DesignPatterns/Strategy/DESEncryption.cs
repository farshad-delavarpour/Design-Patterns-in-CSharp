namespace DesignPatterns.Strategy
{
    public class DESEncryption : IEncryptionAlgorithm
    {
        public string Encrypt(string text) => "DES Encryption";
    }
}