namespace DesignPatterns.Strategy
{
    public interface IEncryptionAlgorithm
    {
        string Encrypt(string text);
    }
}